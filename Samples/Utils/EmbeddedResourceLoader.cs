using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

namespace Samples.Utils
{
    public class EmbeddedResourceLoader
    {
        private Assembly _assembly;
        private string _prefix;

        public Assembly Assembly => _assembly;
        public string Prefix => _prefix;

        public EmbeddedResourceLoader(Assembly assembly, string prefix)
        {
            _assembly = assembly;
            _prefix = prefix;
        }

        public string[] GetResourceNames()
        {
            return _assembly.GetManifestResourceNames();
        }

        public string[] GetResourceNames(string prefix = "", string contains = "", string suffix = "")
        {
            string[] all = _assembly.GetManifestResourceNames();
            return all.Where(x => x.StartsWith(prefix)).Where(x => x.Contains(contains)).Where(x => x.EndsWith(suffix)).ToArray();
        }

        public Stream GetResource(string name)
        {
            string path = _prefix + name;
            Stream s = _assembly.GetManifestResourceStream(path);

            if (s == null)
                throw new EmbeddedResourceNotFound(path);

            return s;
        }

        public string GetResourceString(string name)
        {
            Stream stream = _assembly.GetManifestResourceStream(_prefix + name);
            StreamReader streamReader = new StreamReader(stream);

            string result = streamReader.ReadToEnd();

            stream.Dispose();
            streamReader.Dispose();

            return result;
        }
    }

    public class EmbeddedResourceNotFound : Exception
    {

        public EmbeddedResourceNotFound() : base()
        {

        }

        public EmbeddedResourceNotFound(string message) : base(message)
        {

        }

        public EmbeddedResourceNotFound(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected EmbeddedResourceNotFound(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
