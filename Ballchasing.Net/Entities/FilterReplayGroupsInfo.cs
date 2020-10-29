using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ballchasing.Net
{
    [DataContract]
    public class FilterReplayGroupsInfo
    {

        [DataMember(Name = "name", IsRequired = false)]
        public string Name { get; set; }

        [DataMember(Name = "creator", IsRequired = false)]
        public string Creator { get; set; }

        [DataMember(Name = "group", IsRequired = false)]
        public string Group { get; set; }

        [DataMember(Name = "created-before", IsRequired = false)]
        public DateTime? CreatedBefore { get; set; }

        [DataMember(Name = "created-after", IsRequired = false)]
        public DateTime? CreatedAfter { get; set; }

        [DataMember(Name = "count", IsRequired = false)]
        public int? Count { get; set; }

        [DataMember(Name = "sort-by", IsRequired = false)]
        public SortBy? SortBy { get; set; }

        [DataMember(Name = "sort-dir", IsRequired = false)]
        public SortDirection? SortDirection { get; set; }

        /// <summary>
        /// Returns the contents of this object as a url-parameter compiant string.
        /// </summary>
        /// <returns></returns>
        public string ToUrlParameters()
        {
            string json = JsonConvert.SerializeObject(this,
                            Newtonsoft.Json.Formatting.None,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });

            IDictionary<string, string> parameters = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            StringBuilder sb = new StringBuilder();
                                                       
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                sb.Append($"{pair.Key}={pair.Value}&");
            }

            if (sb.Length > 0)
                return sb.ToString(0, sb.Length - 1);
            else
                return "";
        }
    }
}
