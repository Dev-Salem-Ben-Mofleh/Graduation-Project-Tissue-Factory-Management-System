using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessesLayerApi
{
    public static class clsAccesseSetting
    {
        public static string? ConnectionString;
        public static void Initialize(IConfiguration configuration)
        {
            ConnectionString = configuration.GetSection("ConnectionString").Value;
        }
    }
}
