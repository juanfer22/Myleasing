using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Myleasing.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPropertyTypes();
        IEnumerable<SelectListItem> GetComboLessees();
    }
}