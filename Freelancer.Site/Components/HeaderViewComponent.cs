using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Site.Components;

[ViewComponent(Name = "Header")]
public class HeaderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}