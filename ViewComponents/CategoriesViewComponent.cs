using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using shopapp.webui.Models;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(){
            var categories=new List<Category>()
            {
                new Category{Name="tek kişilik",Description="Horror Game"},
                new Category{Name="çok kişilik",Description="Funny Game"},
                new Category{Name="iki kişilik",Description="Love Game"}
            };
            return View(categories);
        }
    }
}