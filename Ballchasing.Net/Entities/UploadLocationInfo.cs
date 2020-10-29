using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    /// <summary>
    /// Data returned from the Upload API.
    /// </summary>
    /// <remarks>
    /// API Documentation: https://ballchasing.com/doc/api#upload-upload-post.
    /// </remarks>
    [DataContract]
    public class UploadLocationInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "location")]
        public string Location { get; set; }
    }
}
