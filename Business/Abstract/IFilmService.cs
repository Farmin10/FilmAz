using DataAccess.Utilities.Results;
using DTO_s.FilmDTO;
using Response.FilmResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFilmService
    {
        Task<IDataResult<FilmAddOrUpdateResponse>> AddFilm(FilmForAddDto filmForAddDto);
    }
}
