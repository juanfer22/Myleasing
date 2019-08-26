using Myleasing.Web.Data.Entities;
using Myleasing.Web.Date.Entities;
using Myleasing.Web.Models;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Property> ToPropertyAsync(PropertyViewModel view, bool isNew);

        PropertyViewModel ToPropertyViewModel(Property property);

        Task<Contract> ToContractAsync(ContractViewModel view, bool isNew);
    }
}
