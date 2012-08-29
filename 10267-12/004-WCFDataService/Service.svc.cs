using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Web;

namespace _004_WCFDataService
{
    public class Service : DataService<Entities>
    {
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

            //config.SetEntitySetAccessRule("Contatos", EntitySetRights.AllRead);
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);

            config.SetServiceOperationAccessRule("GetGenero", ServiceOperationRights.ReadSingle);

            //config.MaxExpandDepth = 1;
            //config.MaxExpandCount = 1;
            config.SetEntitySetPageSize("Generos", 5);
        }

        protected override void HandleException(HandleExceptionArgs args)
        {
            base.HandleException(args);

            Debug.Print("{0} {1} -> {2} {3}",
                DateTime.Now.ToShortDateString(),
                DateTime.Now.ToShortTimeString(),
                args.Exception.GetType().Name,
                args.Exception.Message);
        }

        [WebGet]
        [SingleResult]
        public Genero GetGenero(int id)
        {
            return CurrentDataSource.Generos.FirstOrDefault(c => c.Id == id);
        }
    }
}

/*
http://localhost:46243/Service.svc/
http://localhost:15047/Service.svc/$metadata
http://localhost:46243/Service.svc/Generos/
http://localhost:46243/Service.svc/Generos(1M)/
http://localhost:46243/Service.svc/Generos(1M)/Nome/
http://localhost:46243/Service.svc/Generos?$select=Nome/
http://localhost:46243/Service.svc/Generos/$count/
http://localhost:46243/Service.svc/Generos?$filter=Id%20ge%206M%20and%20Id%20le%2010M/
http://localhost:46243/Service.svc/Generos?$orderby=Nome/
http://localhost:46243/Service.svc/Generos?$top=3/
http://localhost:46243/Service.svc/Generos?$skip=5&$top=5
http://localhost:46243/Service.svc/Generos?$skiptoken=5
http://localhost:46243/Service.svc/GetGenero?id=1
*/