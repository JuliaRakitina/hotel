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
        public static string Construct()
        {


            var newConnStringBuilder = new SqlConnectionStringBuilder(Properties.Settings.Default.RestoConnectionString);

            var entityConnectionBuilder = new EntityConnectionStringBuilder
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = newConnStringBuilder.ToString(),
                Metadata = @"res://*/RoomType.csdl|
                            res://*/RoomType.ssdl|
                            res://*/RoomType.msl"
            };

            return entityConnectionBuilder.ToString();
        }

    }
}
