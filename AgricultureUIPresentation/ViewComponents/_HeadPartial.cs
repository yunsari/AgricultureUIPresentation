using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.ViewComponents
{
	public class _HeadPartial : ViewComponent
	{
        public IViewComponentResult Invoke()
		{ 
			return View();
		}
    }
}
