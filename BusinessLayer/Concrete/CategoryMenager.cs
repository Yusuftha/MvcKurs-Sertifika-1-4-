using DataAccesLayer.Concrete.Repositories;
using EntitiyLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryMenager
    {
        GenericRopository<Category> repo = new GenericRopository<Category>();

        public List<Category> GetAllBL()
        {
            return repo.List();
        }
        public void CategoriyAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51) 
            {
                //hata mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
