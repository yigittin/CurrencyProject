using System;
using System.Collections.Generic;
using System.Text;
using CurrenyProject.Localization;
using Volo.Abp.Application.Services;

namespace CurrenyProject;

/* Inherit your application services from this class.
 */
public abstract class CurrenyProjectAppService : ApplicationService
{
    protected CurrenyProjectAppService()
    {
        LocalizationResource = typeof(CurrenyProjectResource);
    }
}
