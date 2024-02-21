using DataAccsessLayer.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace AgricultureUIPresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgricultureContext c = new AgricultureContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = c.Teams.Count();
            ViewBag.serviceCount = c.Services.Count();
            ViewBag.messageCount = c.Contacts.Count();
            ViewBag.currentMonthMessage = c.Contacts.Where(x => x.Date.Month == DateTime.Now.Month).Count();

            ViewBag.announcementTrue = c.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = c.Announcements.Where(x => x.Status == false).Count();

            ViewBag.ciftci = c.Teams.Where(x => x.Title == "Çiftçi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.hasatElemani = c.Teams.Where(x => x.Title == "Hasat Elemanı").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.urunPazarlama = c.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.tarimIscisi = c.Teams.Where(x => x.Title == "Tarım İşçisi").Select(y => y.PersonName).FirstOrDefault();

            return View();
        }
    }
}
