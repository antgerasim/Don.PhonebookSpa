using Don.PhoneBookSpa.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace Don.PhoneBookSpa.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookSpaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}