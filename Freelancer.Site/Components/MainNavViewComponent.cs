using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Site.Components;

[ViewComponent(Name = "MainNav")]
public class MainNavViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}