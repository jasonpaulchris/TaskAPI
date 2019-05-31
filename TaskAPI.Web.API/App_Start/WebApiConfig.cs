using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using TaskAPI.Web.Common;
using TaskAPI.Web.Common.Routing;

namespace TaskAPI.Web.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var constraintsResolver = new DefaultInlineConstraintResolver();
            constraintsResolver.ConstraintMap.Add("apiVersionConstraint", typeof(ApiVersionConstraint));

            // Web API routes
            config.MapHttpAttributeRoutes(constraintsResolver);

            config.Services.Replace(typeof(IHttpControllerSelector),
                new NamespaceHttpControllerSelector(config));
        }
    }
}
