using DataAccess.Utilities.Results;
using DTO_s.FilmCategoryDTO;
using Response.FilmCategoryResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFilmCategoryService
    {
        Task<IDataResult<List<ResponseForFilmCategoryAddOrUpdate>>> Add(FilmCategoryForAddDto filmCategoryAddDto);
    }
}
