using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public class CategoryRepository
    {
          private static List<Category> _categories= null;

        static CategoryRepository()
        {
            _categories=new List<Category>{
                new Category{CategoryId=1,Name="tek kişilik",Description="Horror Game"},
                new Category{CategoryId=2,Name="çok kişilik",Description="Funny Game"},
                new Category{CategoryId=3,Name="iki kişilik",Description="Love Game"}
            };
        
        }
        public static List<Category> Category{
            get{
                return _categories;
            }
        }

        public static void AddCategory(Category c){
            _categories.Add(c);
        }
        public static Category GetCategoryById(int id){
            return _categories.FirstOrDefault(c=>c.CategoryId==id);
        }
    }
}