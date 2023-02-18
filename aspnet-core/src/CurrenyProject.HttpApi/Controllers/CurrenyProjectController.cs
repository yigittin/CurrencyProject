using CurrenyProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CurrenyProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CurrenyProjectController : AbpControllerBase
{
    protected CurrenyProjectController()
    {
        LocalizationResource = typeof(CurrenyProjectResource);
    }
}
