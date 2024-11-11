using ED_MVC.Domain;

namespace ED_MVC.Models
{
    public class ProductIndexViewModel
    {
        public List<Category> Categories { get; set; }
        public int CountOfProducts { get; set; }
    }
}
