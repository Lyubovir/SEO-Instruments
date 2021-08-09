namespace SeoInstruments.Web.Areas.Administration.Controllers
{
    using SeoInstruments.Common;
    using SeoInstruments.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
