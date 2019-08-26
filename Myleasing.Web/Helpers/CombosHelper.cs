using Microsoft.AspNetCore.Mvc.Rendering;
using Myleasing.Web.Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myleasing.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContex;

        public CombosHelper(DataContext dataContext)
        {
            _dataContex = dataContext;
        }

        public IEnumerable<SelectListItem> GetComboLessees()
        {
            var list = _dataContex.Lessees.Select(p => new SelectListItem
            {
                Text = p.User.FullNameWithDocument,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a lessee...)",
                Value = "0"
            });

            return list;

        }

        public IEnumerable<SelectListItem> GetComboPropertyTypes()
        {
            var list = _dataContex.PropertyTypes.Select(p => new SelectListItem
            {
                Text = p.Name,
                Value = p.Id.ToString()
            }).OrderBy(p => p.Text).ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "(Select a property type...)",
                Value = "0"
            });

            return list;
        }


    }
}
