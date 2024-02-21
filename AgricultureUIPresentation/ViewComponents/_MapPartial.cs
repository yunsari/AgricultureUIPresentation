using DataAccsessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace AgricultureUIPresentation.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            AgricultureContext agricultureContext = new AgricultureContext();
            var values = agricultureContext.Addresses.Select(x => x.MapInfo).FirstOrDefault();
            ViewBag.MapInfo = values;
            return View(); 
        }
    }
}
