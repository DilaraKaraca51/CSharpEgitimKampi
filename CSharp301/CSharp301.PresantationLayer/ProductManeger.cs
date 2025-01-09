using CSharp301.BusinessLayer.Abstract;
using CSharp301.DataAccessLayer.EntityFramework;

namespace CSharp301.PresantationLayer
{
    internal class ProductManeger : ICategoryService
    {
        public ProductManeger(EfCategoryDal efCategoryDal)
        {
        }
    }
}