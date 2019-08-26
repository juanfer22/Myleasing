using Myleasing.Web.Data.Entities;
using Myleasing.Web.Models;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel view);

        PropertyViewModel ToPropertyViewModel(Property property);
    }
}
