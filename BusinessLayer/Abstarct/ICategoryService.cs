using EntityLayer.Concrete;
using System.Collections.Generic;
namespace BusinessLayer.Abstarct
{
    public interface ICategoryService
    {
        List<Category>GetList();
        void CategoryAdd(Category category);
        Category GetById(int id);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
    }
}
