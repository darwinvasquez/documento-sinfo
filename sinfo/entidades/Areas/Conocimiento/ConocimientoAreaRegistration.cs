using System.Web.Mvc;

namespace entidades.Areas.Conocimiento
{
    public class ConocimientoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Conocimiento";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Conocimiento_default",
                "Conocimiento/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}