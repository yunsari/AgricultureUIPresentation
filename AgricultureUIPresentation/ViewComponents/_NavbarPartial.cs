using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
