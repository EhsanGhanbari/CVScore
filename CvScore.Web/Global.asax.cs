using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CV.Presentation.SPA.App_Start;
using CvScore.Application;
using CvScore.Web.BootStrapper;

namespace CvScore.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();


            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new RazorViewEngine());


            //Dependency Injection
            IoC.Initialize();



            ////Fluent Nhibernate
            //ObjectFactory.Initialize(x =>
            //{
            //    // ISessionFactory is expensive to initialize, so create it as a singleton.
            //    x.For<ISessionFactory>()
            //        .Singleton()
            //        .Use(CreateSessionFactory());

            //    // Cache each ISession per web request. Remember to dispose this!
            //    x.For<ISession>()
            //        .HttpContextScoped()
            //        .Use(context => context.GetInstance<ISessionFactory>().OpenSession());
            //});


            //Service Automapper
            AutoMapperBootStrapper.ConfigureAutoMapper();

        }
    }
}