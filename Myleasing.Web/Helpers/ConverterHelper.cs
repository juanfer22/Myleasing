using Myleasing.Web.Data.Entities;
using Myleasing.Web.Date;
using Myleasing.Web.Date.Entities;
using Myleasing.Web.Models;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(
            DataContext dataContext,
            ICombosHelper combosHelper)
        {
            _dataContext = dataContext;
            _combosHelper = combosHelper;
        }
        public async Task<Property> ToPropertyAsync(PropertyViewModel view,bool isNew)
        {
            return new Property
            {
                Address = view.Address,
                HasParkingLot = view.HasParkingLot,
                IsAvailable = view.IsAvailable,
                Neighborhood = view.Neighborhood,
                Price = view.Price,
                Rooms = view.Rooms,
                SquareMeters = view.SquareMeters,
                Stratum = view.Stratum,
                Owner = await _dataContext.Owners.FindAsync(view.OwnerId),
                PropertyType = await _dataContext.PropertyTypes.FindAsync(view.PropertyTypeId),
                Remarks = view.Remarks
            };
        }

        public PropertyViewModel ToPropertyViewModel(Property property)
        {
            return new PropertyViewModel
            {
                Address = property.Address,
                HasParkingLot = property.HasParkingLot,
                Id = property.Id,
                IsAvailable = property.IsAvailable,
                Neighborhood = property.Neighborhood,
                Price = property.Price,
                Rooms = property.Rooms,
                SquareMeters = property.SquareMeters,
                Stratum = property.Stratum,
                Owner = property.Owner,
                OwnerId = property.Owner.Id,
                PropertyType = property.PropertyType,
                PropertyTypeId = property.PropertyType.Id,
                PropertyTypes = _combosHelper.GetComboPropertyTypes(),
                Remarks = property.Remarks,
            };
        }

        public async Task<Contract> ToContractAsync(ContractViewModel view, bool isNew)
        {
            return new Contract
            {
                EndDate = view.EndDate.ToUniversalTime(),
                IsActive = view.IsActive,
                Lessee = await _dataContext.Lessees.FindAsync(view.LesseeId),
                Owner = await _dataContext.Owners.FindAsync(view.OwnerId),
                Price = view.Price,
                Property = await _dataContext.Properties.FindAsync(view.PropertyId),
                Remarks = view.Remarks,
                StartDate = view.StartDate.ToUniversalTime(),
                Id =isNew ? 0: view.Id
            };
        }

        public ContractViewModel ToContractViewModel(Contract contract)
        {
            return new ContractViewModel
            {
                EndDate = contract.EndDateLocal,
                IsActive = contract.IsActive,
                Lessee = contract.Lessee,
                Owner = contract.Owner,
                Price = contract.Price,
                Property = contract.Property,
                Remarks = contract.Remarks,
                StartDate = contract.StartDateLocal,
                Id = contract.Id,
                LesseeId = contract.Lessee.Id,
                Lessees = _combosHelper.GetComboLessees(),
                OwnerId = contract.Owner.Id,
                PropertyId = contract.Property.Id
            };
        }
    }
    }
