using Practise103.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Services
{
    public interface IGenericService<TEntity, TDto> where TEntity : class where TDto : class 
    {
        Task<ResponseDto<TDto>> GetByIdAsync(int id);
        Task<ResponseDto<IEnumerable<TDto>>> GetAllAsync();
        Task<ResponseDto<IEnumerable<TDto>>> Where(Expression<Func<TEntity, bool>> predicate);
        Task<ResponseDto<TDto>> AddAsync(TEntity entity);
        Task<ResponseDto<NoDataDto>> Remove(TEntity entity);
        Task<ResponseDto<NoDataDto>> Update(TEntity entity);
    }
}
