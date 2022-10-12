using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Site.Components;

[ViewComponent(Name = "Portfolio")]
public class PortfolioViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}