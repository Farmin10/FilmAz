using AutoMapper;
using Business.Abstract;
using Business.Constants;
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

        public async Task<IDataResult<List<ResponseForFilmCategoryAddOrUpdate>>> Add(FilmCategoryForAddDto filmCategoryAddDto)
        {
            var result = new FilmCategory();
            foreach (var item in filmCategoryAddDto.Category)
            {
                result = new FilmCategory() { FilmId = filmCategoryAddDto.FilmId,CategoryId=item.CategoryId };
                await _unitOfWork.FilmCategoryDal.AddAsync(result);
                _unitOfWork.SaveAsync();
                
            }
            var film = _unitOfWork.FilmCategoryDal.GetAll(x => x.FilmId == filmCategoryAddDto.FilmId,x=>x.Film,x=>x.Category);
            var response = _mapper.Map<List<ResponseForFilmCategoryAddOrUpdate>>(film);
            
            
            return new SuccessDataResult<List<ResponseForFilmCategoryAddOrUpdate>>(response,Messages.DataListedSuccessfully);
        }
    }
}
