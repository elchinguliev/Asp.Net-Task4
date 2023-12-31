﻿using AspTask4.Data;
using AspTask4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace AspTask4.ViewCoomponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly ProductDbContext _context;

        public CategoryListViewComponent(ProductDbContext context)
        {
            _context=context;
        }

        public ViewViewComponentResult Invoke()
        {

            var categories = _context.Categories.ToList().Select(c =>
            {
                return new CategoryViewModel
                {
                    Title=c.Title,

                };
            });
            return View(new CategoryListViewModel
            {
                Categories=categories.ToList()
            }
            ) ; 
        }
    }
}
