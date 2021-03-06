﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SiGCT
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            GlobalConfiguration.Configure(WebApiConfig.Register);

            //Ao inicializar a aplicação inicia o NHibernateSessionFactory da Aplicação
            //SiGCT.Models.DAO.NHibernateSessionManager.InitializeSessionFactory();

            //Esta linha eh responsavel por ativar o log4net
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
