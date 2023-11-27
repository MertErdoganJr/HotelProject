using Microsoft.AspNetCore.Mvc;
namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _NewsletterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
