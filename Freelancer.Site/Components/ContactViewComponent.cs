using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Site.Components;

[ViewComponent(Name = "Contact")]
public class ContactViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}