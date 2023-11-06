using AspTask4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspTask4.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ProductDbContext _context;

        public IndexModel(ProductDbContext context)
        {
            _context = context;
        }

        public string Info { get; set; }
        public List<Entities.Product> Products { get; set; }
        public void OnGet(string info="")
        {
            Products = _context.Products.ToList();
            Info=info;
        }

        [BindProperty]
        public Entities.Product Product { get; set; }
        public IActionResult OnPost()
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            Info = $"{Product.Name} added successfully";
            return RedirectToPage("Index", new { info = Info });
        }


        public IActionResult Delete(int id)
        {
            _context.Remove(_context.Products.Single(a => a.Id == id));
            _context.SaveChanges();
            return RedirectToPage("Index");
        }

        public IActionResult Edit(int id)
        {
            return Redirect($"Edit/Edit?id={id}");
        }



    }
}
