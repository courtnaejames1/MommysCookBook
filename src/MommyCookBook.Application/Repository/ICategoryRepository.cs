using MommyCookBook.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MommyCookBook.Application.Repository
{
    public interface ICategoryRepository
    {        
        Task <Category?> CreateCategoryModel(Category categoryModel, CancellationToken cancellationToken);
        Task<IReadOnlyList<Category>> GetAllCategories(CancellationToken cancellationToken);
        
    }
}
