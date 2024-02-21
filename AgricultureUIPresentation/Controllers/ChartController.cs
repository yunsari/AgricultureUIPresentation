using AgricultureUIPresentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductChart()
        {
            List<ProductClass> products = new List<ProductClass>();
            products.Add(new ProductClass
            {
                productname = "Buğday",
                productvalue = 850
            });

            products.Add(new ProductClass
            {
                productname = "Mercimek",
                productvalue = 430
            });

            products.Add(new ProductClass
            {
                productname = "Arpa",
                productvalue = 480
            });

            products.Add(new ProductClass
            {
                productname = "Pirinç",
                productvalue = 680
            });

            products.Add(new ProductClass
            {
                productname = "Domates",
                productvalue = 740
            });

            return Json(new { jsonlist = products });
        }
    }
}
