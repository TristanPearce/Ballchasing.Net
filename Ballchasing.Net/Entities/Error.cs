using System.Runtime.Serialization;

namespace Ballchasing.Net
{
    [DataContract]
    public class Error
    {
        /// <summary>
        /// error
        /// </summary>
        [DataMember(Name = "error")]
        public string Text { get; set; }

        /// <summary>
        /// rquest_id
        /// </summary>
        [DataMember(Name = "rquest_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// True if no error occured.
        /// </summary>
        public bool Success => (Text == null);
    }
}
