using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using shopapp.webui.Models;
using shopapp.webui.Data;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(){
            if(RouteData.Values["action"].ToString()=="list")
                ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Category);
        }
    }
}