using Microsoft.AspNetCore.Mvc;

namespace CoolCaptions.Controllers.Common
{
    public abstract class BaseController : Controller
    {
        protected void SetTitle(string title)
        {
            this.ViewData["Title"] = title;
        }
    }
}