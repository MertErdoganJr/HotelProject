using Microsoft.AspNetCore.Mvc;
namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _OurServicesPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
