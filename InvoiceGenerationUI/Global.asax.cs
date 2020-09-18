using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using InvoiceGenerationBAL;
using InvoiceGenerationDAL;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using Unity;

namespace InvoiceGenerationUI
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();

            container.RegisterType<IImport, Import>();
            container.RegisterType<IDataRepository, DataRepository>();
        }
    }
}