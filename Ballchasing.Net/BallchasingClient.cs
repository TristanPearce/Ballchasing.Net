using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ballchasing.Net
{
    /// <summary>
    /// Wrapper for https://ballchasing.com/'s API.
    /// </summary>
    /// <remarks>
    /// API Reference: https://ballchasing.com/doc/api. 
    /// </remarks>
    public class BallchasingClient : IBallchasingAPI
    {
        /// <summary>
        /// Used for sending HTTP Requests.
        /// </summary>
        protected HttpClient Http { get; private set; }

        /// <summary>
        /// Base address to the ballchasing.com API.
        /// </summary>
        protected string BaseAddress { get; set; } = "https://ballchasing.com/api/";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token">
        /// <para>
        /// Access Token to the ballchasing.com API.
        /// </para>
        /// <para>
        /// If you need a token, visit https://ballchasing.com/upload.
        /// </para>
        /// </param>
        /// <param name="baseAddress"></param>
        public BallchasingClient(string token, string baseAddress = null)
        {
            this.BaseAddress ??= baseAddress;

            // The token is not kept track of outside the HttpClient.
            //this.Token = token;

            Http = new HttpClient();

            Http.DefaultRequestHeaders.Add("Authorization", token);
            // I could set the base address here too.
        }

        /// <summary>
        /// Dispose the HttpClient.
        /// </summary>
        public void Dispose()
        {
            Http.Dispose();
        }


        #region Misc

        ///<inheritdoc/>
        public virtual async Task<PingResult> PingAsync()
        {
            // Create the HTTP Request.
            var method = new HttpMethod("GET");
            var requestUri = $"{BaseAddress}";
            var request = new HttpRequestMessage(method, requestUri);

            // Send HTTP Request and get contents.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string json = await response.Content.ReadAsStringAsync();

            // Parse Contents.
            Ping ping = JsonConvert.DeserializeObject<Ping>(json);

            // Create result.
            PingResult result = new PingResult()
            {
                StatusCode = response.StatusCode,
                Error = ping.Error,
                Name = ping.Name,
                SteamId = ping.SteamId
            };

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<GetMapCodeMappingsResult> GetMapCodeMappingsAsync()
        {
            // Create the HTTP Request.
            var method = new HttpMethod("GET");
            var requestUri = $"{BaseAddress}maps";
            var request = new HttpRequestMessage(method, requestUri);

            // Make HTTP Request and get content.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string json = await response.Content.ReadAsStringAsync();

            // Create result.
            GetMapCodeMappingsResult result = new GetMapCodeMappingsResult()
            {
                StatusCode = response.StatusCode
            };


            // If successful, parse mappings.
            if (result.Success)
            {
                IDictionary<string, string> mappings = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                result.Mappings = mappings;
            }
            // Else, parse error.
            else
            {
                Error error = JsonConvert.DeserializeObject<Error>(json);
                result.Error = error.Text;
            }

            return result;
        }

        #endregion

        #region Replays

        ///<inheritdoc/>
        public virtual async Task<FilterReplaysResult> FilterReplaysAsync(FilterReplaysInfo info)
        {
            // Create the HTTP Request.
            var method = new HttpMethod("GET");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays?{info.ToUrlParameters()}");

            // Send HTTP Request and get response content.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string resultJson = await response.Content.ReadAsStringAsync();

            // Create result.
            FilterReplaysResult result = new FilterReplaysResult()
            {
                StatusCode = response.StatusCode
            };

            // If successful, parse replay list.
            if (result.Success)
            {
                FilteredReplaysList list = JsonConvert.DeserializeObject<FilteredReplaysList>(resultJson);
                result.Replays = list.Replays;
                result.Next = list.Next;
            }
            // Else, parse error.
            else
            {
                Error error = JsonConvert.DeserializeObject<Error>(resultJson);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<GetReplayResult> GetReplayAsync(string replayId)
        {
            //=========================//
            // Create the HTTP Request // 
            //=========================//
            var method = new HttpMethod("GET");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays/{replayId}");

            //===================//
            // Make HTTP Request //
            //===================//
            using HttpResponseMessage response = await Http.SendAsync(request);

            //======================//
            // Get Response Content //
            //======================//
            string json = await response.Content.ReadAsStringAsync();

            //===============//
            // Create result //
            //===============//
            GetReplayResult result = new GetReplayResult()
            {
                StatusCode = response.StatusCode
            };

            // If the request was successful, parse the replay.
            if (result.Success)
            {
                Replay replay = JsonConvert.DeserializeObject<Replay>(json);
                result.Replay = replay;
            }
            // Else, parse error.
            else
            {
                Error error = JsonConvert.DeserializeObject<Error>(json);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<DownloadReplayResult> DownloadReplayAsync(string replayId)
        {
            // Create the HTTP Request.
            var method = new HttpMethod("GET");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays/{replayId}/file");

            // Send HTTP Request.
            using HttpResponseMessage response = await Http.SendAsync(request);

            // Create result.
            DownloadReplayResult result = new DownloadReplayResult()
            {
                StatusCode = response.StatusCode
            };


            // If the request was succesful, get content as a stream.
            if (result.Success)
            {
                result.Stream = await response.Content.ReadAsStreamAsync();
            }
            // Else, parse error.
            else
            {
                string json = await response.Content.ReadAsStringAsync();
                Error error = JsonConvert.DeserializeObject<Error>(json);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<DeleteReplayResult> DeleteReplayAsync(string replayId)
        {
            // Create the HTTP Request.
            var method = new HttpMethod("DELETE");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays/{replayId}");

            // Make HTTP Request.
            using HttpResponseMessage response = await Http.SendAsync(request);

            // Create result.
            DeleteReplayResult result = new DeleteReplayResult()
            {
                StatusCode = response.StatusCode
            };

            // Check for and parse error.
            if (!result.Success)
            {
                string json = await response.Content.ReadAsStringAsync();
                Error error = JsonConvert.DeserializeObject<Error>(json);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<PatchReplayResult> PatchReplayAsync(string replayId, ReplayPatchInfo replayInfo)
        {
            // Serialize replay info. 
            string requestJson = JsonConvert.SerializeObject(replayInfo,
                Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });


            // Create HTTP Request.
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays/{replayId}")
            {
                Content = new StringContent(requestJson)
            };

            // Send HTTP Request and get content.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string responseJson = await response.Content.ReadAsStringAsync();

            PatchReplayResult result = new PatchReplayResult()
            {
                StatusCode = response.StatusCode
            };

            // Check for and parse error.
            if (result.Success)
            {
                Error error = JsonConvert.DeserializeObject<Error>(responseJson);
                result.Error = error.Text;
            }

            return result;
        }

        #endregion

        #region Upload

        ///<inheritdoc/>
        public virtual async Task<UploadReplayResult> UploadReplayAsync(Stream stream, string fileName, Privacy privacy)
        {
            // Create HTTP Request.
            var method = new HttpMethod("POST");
            string requestUri = $"{BaseAddress}v2/upload?visibility={privacy.ToString().ToLower()}";
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = new MultipartFormDataContent
                {
                    {new StreamContent(stream), "file", fileName}
                }
            };

            // Send HTTP Request and get content.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string json = await response.Content.ReadAsStringAsync();

            // Create result.
            UploadReplayResult result = new UploadReplayResult()
            {
                StatusCode = response.StatusCode
            };

            // Parse upload information. 
            UploadLocationInfo upload = JsonConvert.DeserializeObject<UploadLocationInfo>(json);
            result.Upload = upload;

            // If the request is not successful, parse the error.
            if (!result.Success)
            {
                Error error = JsonConvert.DeserializeObject<Error>(json);

                if (error.Text == null)
                    result.Error = response.ReasonPhrase;
                else
                    result.Error = error.Text;
            }

            return result;
        }

        #endregion

        #region ReplayGroups

        ///<inheritdoc/>
        public virtual async Task<FilterReplayGroupsResult> FilterReplayGroupsAsync(FilterReplayGroupsInfo info)
        {
            // Create HTTP Request.
            var method = new HttpMethod("GET");
            var request = new HttpRequestMessage(method, $"{BaseAddress}replays?{info.ToUrlParameters()}");

            // Send HTTP Request and get content.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string resultJson = await response.Content.ReadAsStringAsync();

            // Create result.
            FilterReplayGroupsResult result = new FilterReplayGroupsResult()
            {
                StatusCode = response.StatusCode
            };

            // If successful, parse replay group list.
            if (result.Success)
            {
                FilteredReplayGroupsList list = JsonConvert.DeserializeObject<FilteredReplayGroupsList>(resultJson);

                result.Groups = list.Groups;
                result.Next = list.Next;
            }
            // Else parse error.
            else
            {
                Error error = JsonConvert.DeserializeObject<Error>(resultJson);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<CreateReplayGroupResult> CreateReplayGroupAsync(ReplayGroupCreationInfo info)
        {
            // Serialise creation info.
            string json = JsonConvert.SerializeObject(info,
                Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            // Create HTTP Request.
            var method = new HttpMethod("POST");
            var request = new HttpRequestMessage(method, $"{BaseAddress}groups")
            {
                Content = new StringContent(json)
            };

            // Make HTTP Request.
            using HttpResponseMessage response = await Http.SendAsync(request);

            // Get response json.
            string responseJson = await response.Content.ReadAsStringAsync();

            // Create result.
            CreateReplayGroupResult result = new CreateReplayGroupResult()
            {
                StatusCode = response.StatusCode
            };

            if (response.StatusCode == HttpStatusCode.Created) // Success
            {
                ReplayGroupLocationInfo location = JsonConvert.DeserializeObject<ReplayGroupLocationInfo>(responseJson);
                result.ReplayGroup = location;
            }
            else // Error
            {
                Error error = JsonConvert.DeserializeObject<Error>(responseJson);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<GetReplayGroupResult> GetReplayGroupAsync(string replayGroupId)
        {
            // Create the HTTP Request.
            var method = new HttpMethod("GET");
            var requestUri = $"{BaseAddress}groups/{replayGroupId}";
            var request = new HttpRequestMessage(method, requestUri);

            // Send HTTP Request and read Response.
            using HttpResponseMessage response = await Http.SendAsync(request);
            string json = await response.Content.ReadAsStringAsync();

            // Create result.
            GetReplayGroupResult result = new GetReplayGroupResult()
            {
                StatusCode = response.StatusCode
            };

            if (response.StatusCode == HttpStatusCode.OK) // Success
            {
                ReplayGroup replayGroup = JsonConvert.DeserializeObject<ReplayGroup>(json);
                result.ReplayGroup = replayGroup;
            }
            else // Error
            {
                Error error = JsonConvert.DeserializeObject<Error>(json);
                result.Error = error.Text;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<DeleteReplayGroupResult> DeleteReplayGroupAsync(string replayGroupId)
        {
            // Create the HTTP Request.
            var method = new HttpMethod("DELETE");
            var request = new HttpRequestMessage(method, $"{BaseAddress}groups/{replayGroupId}");

            // Make HTTP Request.
            using HttpResponseMessage response = await Http.SendAsync(request);

            // Parse Response.
            DeleteReplayGroupResult result = new DeleteReplayGroupResult();
            result.StatusCode = response.StatusCode;

            if (!result.Success) // if an error occurred
            {
                result.Error = response.ReasonPhrase;
            }

            return result;
        }

        ///<inheritdoc/>
        public virtual async Task<PatchReplayGroupResult> PatchReplayGroupAsync(string replayGroupId,
            ReplayGroupPatchInfo info)
        {
            // Serialize object.
            string json = JsonConvert.SerializeObject(info,
                Newtonsoft.Json.Formatting.None,
                new JsonSerializerSettings
                {
                    // this is to only serialize fields that have values.
                    NullValueHandling = NullValueHandling.Ignore
                });

            // Create HTTP Request.
            var method = new HttpMethod("PATCH");
            var requestUri = $"{BaseAddress}groups/{replayGroupId}";
            var request = new HttpRequestMessage(method, requestUri)
            {
                Content = new StringContent(json)
            };

            // Send HTTP Request.
            using HttpResponseMessage response = await Http.SendAsync(request);

            // Create result.
            PatchReplayGroupResult result = new PatchReplayGroupResult();
            result.StatusCode = response.StatusCode;

            if (!result.Success) // if an error occurred
            {
                result.Error = response.ReasonPhrase;
            }

            return result;
        }

        #endregion
    }
}