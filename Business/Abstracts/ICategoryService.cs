using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IPaginate<GetListCategoryResponse>> GetListAsync();
    Task<CreatedCategoryResponse> Add(CreateCategoryRequest createCategoryRequest);
    Task Update(Category category);
    Task Delete(Category category);
}