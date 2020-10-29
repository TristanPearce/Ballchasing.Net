using System;
using System.IO;
using System.Threading.Tasks;

namespace Ballchasing.Net
{
    public interface IBallchasingAPI : IDisposable
    {
        /// <summary>
        /// Create a new Replay Group.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replay-groups-groups-post.
        /// </remarks>
        /// <param name="info">Creation info for the replay group.</param>
        /// <returns></returns>
        Task<CreateReplayGroupResult> CreateReplayGroupAsync(ReplayGroupCreationInfo info);

        /// <summary>
        /// Delete a replay permenently.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replays-replay-delete. 
        /// </remarks>
        /// <param name="replayId">Id of the replay to delete.</param>
        /// <returns></returns>
        Task<DeleteReplayResult> DeleteReplayAsync(string replayId);

        /// <summary>
        /// Delete a replay group permanently by Id.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replay-groups-group-delete.
        /// </remarks>
        /// <param name="replayGroupId">Id of the replay group to delete permently.</param>
        /// <returns></returns>
        Task<DeleteReplayGroupResult> DeleteReplayGroupAsync(string replayGroupId);

        /// <summary>
        /// Download the replay file of a replay.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replays-replay-get-1.
        /// </remarks>
        /// <param name="replayId">Id of the replay to download.</param>
        /// <returns></returns>
        Task<DownloadReplayResult> DownloadReplayAsync(string replayId);

        /// <summary>
        /// Get a filtered list of replay groups.
        /// </summary>
        /// <param name="info">
        /// Parameters to filter replay groups by.
        /// Fields can and should be left null if not used for filtering.
        /// </param>
        /// <returns></returns>
        Task<FilterReplayGroupsResult> FilterReplayGroupsAsync(FilterReplayGroupsInfo info);

        /// <summary>
        /// Get a filtered list of replay.
        /// </summary>
        /// <param name="info">
        /// Parameters to filter replays by.
        /// Fields can and should be left null if not used for filtering.
        /// </param>
        /// <returns></returns>
        Task<FilterReplaysResult> FilterReplaysAsync(FilterReplaysInfo info);

        /// <summary>
        /// Get all existing mappings between map-codes and map-names.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#misc-maps-get.
        /// </remarks>
        /// <returns></returns>
        Task<GetMapCodeMappingsResult> GetMapCodeMappingsAsync();

        /// <summary>
        /// Get a replay by it's Id.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replays-replay-get.
        /// </remarks>
        /// <param name="replayId">The id of a replay.</param>
        /// <returns></returns>
        Task<GetReplayResult> GetReplayAsync(string replayId);

        /// <summary>
        /// Get a replay group by Id.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replay-groups-group-get.
        /// </remarks>
        /// <param name="replayGroupId">Id of the replay group to get.</param>
        /// <returns></returns>
        Task<GetReplayGroupResult> GetReplayGroupAsync(string replayGroupId);

        /// <summary>
        /// Update the details of a replay.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replays-replay-patch. 
        /// </remarks>
        /// <param name="replayId">Id of the replay to be patched.</param>
        /// <param name="replayInfo">Info to update the replay with.</param>
        /// <returns></returns>
        Task<PatchReplayResult> PatchReplayAsync(string replayId, ReplayPatchInfo replayInfo);

        /// <summary>
        /// Update the information of a Replay Group.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#replay-groups-group-patch. 
        /// </remarks>
        /// <param name="replayGroupId">Id of the replay group to update.</param>
        /// <param name="info">Information to update the replay group with.</param>
        /// <returns></returns>
        Task<PatchReplayGroupResult> PatchReplayGroupAsync(string replayGroupId, ReplayGroupPatchInfo info);

        /// <summary>
        /// Ping ballchasing.com's API.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#ping.
        /// </remarks>
        /// <returns></returns>
        Task<PingResult> PingAsync();

        /// <summary>
        /// Upload a replay.
        /// </summary>
        /// <remarks>
        /// API Documentation: https://ballchasing.com/doc/api#upload-upload-post.
        /// </remarks>
        /// <param name="stream">Rocket League replay file data.</param>
        /// <param name="fileName">File name to identify the file.</param>
        /// <returns></returns>
        Task<UploadReplayResult> UploadReplayAsync(Stream stream, string fileName, Privacy privacy);
    }
}