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
            //var newConnStringBuilder = new SqlConnectionStringBuilder
            //{
            //    UserID = "user",
            //    Password = "pass",
            //    InitialCatalog = "databaseName",
            //    DataSource = "serverName"
            //};


  //            < add name = "RestoEntities" connectionString = "metadata=res://*/RoomType.csdl|res://*/RoomType.ssdl|res://*/RoomType.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-3TVA44Q\RESTO;initial catalog=Resto;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName = "System.Data.EntityClient" /></ connectionStrings >

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
