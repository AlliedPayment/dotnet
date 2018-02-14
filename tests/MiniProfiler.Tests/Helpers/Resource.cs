using System.IO;
using System.Reflection;
#if NETCOREAPP1_1 || NETCOREAPP2_0

#endif

namespace StackExchange.Profiling.Tests.Helpers
{
    public static class Resource
    {
        public static string Get(string name)
        {
            using (var stream = typeof(Resource)
#if NETCOREAPP1_1 || NETCOREAPP2_0
                    .GetTypeInfo()
#endif
                    .Assembly.GetManifestResourceStream("StackExchange.Pofiling.Tests." + name))
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            return null;
        }
    }
}
