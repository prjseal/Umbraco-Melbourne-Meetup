using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Site.Components;

[ViewComponent(Name = "About")]
public class AboutViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}