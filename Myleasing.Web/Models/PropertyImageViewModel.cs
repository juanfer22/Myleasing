using Microsoft.AspNetCore.Http;
using Myleasing.Web.Date.Entities;
using System.ComponentModel.DataAnnotations;

namespace Myleasing.Web.Models
{
    public class PropertyImageViewModel : PropertyImage
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
