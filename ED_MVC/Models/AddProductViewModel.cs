using ED_MVC.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace ED_MVC.Models
{
    public class AddProductViewModel
    {
        public Product? Product { get; set; }
        public required List<SelectListItem> Categories { get; set; }
    }
}
