using System.Net;

namespace Ballchasing.Net
{
    /// <summary>
    /// Result from a ballchasing.com API call.
    /// </summary>
    public interface IResult
    {

        /// <summary>
        /// Status code returned by the HTTP response.
        /// </summary>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Error text, can be null if no error occured.
        /// </summary>
        string Error { get; }

        /// <summary>
        /// True if the response returned succesfully.
        /// </summary>
        bool Success { get; }
    }
}
