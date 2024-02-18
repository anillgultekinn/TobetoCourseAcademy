using Business.Abstracts;
using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public async Task Add(Category category)
    {
        await _categoryDal.AddAsync(category);
    }

    public Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Category category)
    {
        await _categoryDal.DeleteAsync(category, true);
    }

    public Task<IPaginate<GetListCategoryResponse>> GetListAsync()
    {
        throw new NotImplementedException();
    }

    public async Task Update(Category category)
    {
        await _categoryDal.UpdateAsync(category);
    }

}
