using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityBreakout.Models
{
    public class ConnectionModel
    {
        public static string ConnectionString { get { return
                @"metadata = res://*/Models.People.csdl|res://*/Models.People.ssdl|res://*/Models.People.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=LAPTOP-FPF5GBKU\SQLEXPRESS;initial catalog=StarWars;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;' providerName='System.Data.EntityClient'";
 }
        }
    }
}