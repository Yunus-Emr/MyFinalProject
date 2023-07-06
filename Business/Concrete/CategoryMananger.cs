using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryMananger : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryMananger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult< List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        // Select * from Categories where Category = 3 altaki kodun karşılığı.
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
