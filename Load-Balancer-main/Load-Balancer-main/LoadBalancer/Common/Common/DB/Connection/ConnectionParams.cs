using System.Diagnostics.CodeAnalysis;

namespace LoadBalancer.DB.Connection
{
    [ExcludeFromCodeCoverage]
    public class ConnectionParams
    {
        public static readonly string LOCAL_DATA_SOURCE = "//localhost:1521/xe";
        public static readonly string USER_ID = "Moco26";
        public static readonly string PASSWORD = "ftn";
    }
}
