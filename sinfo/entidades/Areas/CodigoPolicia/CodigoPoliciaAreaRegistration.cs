using System.Web.Mvc;

namespace entidades.Areas.CodigoPolicia
{
    public class CodigoPoliciaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CodigoPolicia";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CodigoPolicia_default",
                "CodigoPolicia/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}