using AutoMapper;
using Business.Abstract;
using DataAccess.UnitOfWorkPattern;
using DataAccess.Utilities.Results;
using DTO_s.FilmCategoryDTO;
using Entities.Concrete;
using Response.FilmCategoryResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmCategoryManager:IFilmCategoryService
    {
        IMapper _mapper;
        IUnitOfWork _unitOfWork;

        public FilmCategoryManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<ResponseForFilmCategoryAddOrUpdate>> Add(FilmCategoryForAddDto filmCategoryAddDto)
        {
            var result = new FilmCategory();
            foreach (var item in filmCategoryAddDto.CategoryId)
            {
                result = new FilmCategory() { FilmId = filmCategoryAddDto.FilmId,CategoryId=item };
                await _unitOfWork.FilmCategoryDal.AddAsync(result);
                _unitOfWork.SaveAsync();
                
            }
           
            
            var film = _unitOfWork.FilmCategoryDal.GetAll(x => x.FilmId == filmCategoryAddDto.FilmId, x => x.Category, x => x.Film);
            
            return new SuccessDataResult<ResponseForFilmCategoryAddOrUpdate>();
        }
    }
}
