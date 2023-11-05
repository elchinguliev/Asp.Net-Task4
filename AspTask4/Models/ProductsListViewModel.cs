using AspTask4.Entities;

namespace AspTask4.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
