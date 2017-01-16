using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Resto.Plugin.Hotel
{
    public class ConnectionStringBuilder
    {
        public static string Construct(String model)
        {
            var newConnStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.RestoConnectionString);

            var entityConnectionBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = newConnStringBuilder.ToString(),
                Metadata = @"res://*/"+model+ ".csdl|res://*/" + model + ".ssdl|res://*/" + model + ".msl"
            };

            return entityConnectionBuilder.ToString();
        }

    }
}
