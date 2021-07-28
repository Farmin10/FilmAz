using AutoMapper;
using Business.Abstract;
using Business.Constants;
using DataAccess.UnitOfWorkPattern;
using DataAccess.Utilities.Results;
using DTO_s.FilmCountryDTO;
using DTO_s.FilmDTO;
using DTO_s.ProductionYearDTO;
using Entities.Concrete;
using Response.FilmResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FilmManager : IFilmService
    {
        IMapper _mapper;
        IUnitOfWork _unitOfWork;

        public FilmManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<FilmAddOrUpdateResponse>> AddFilm(FilmForAddDto filmForAddDto)
        {
            try
            {
                var mappedEntity = _mapper.Map<Film>(filmForAddDto);
                await _unitOfWork.FilmDal.AddAsync(mappedEntity);
                _unitOfWork.SaveAsync();
                var film = _unitOfWork.FilmDal.Get(x => x.FilmId == mappedEntity.FilmId, a => a.FilmCountry, a => a.ProductionYear);
                var response = _mapper.Map<FilmAddOrUpdateResponse>(film);
                return new SuccessDataResult<FilmAddOrUpdateResponse>(response, Messages.FilmAddedSuccessfully);
            }
            catch (Exception)
            {
                return new ErrorDataResult<FilmAddOrUpdateResponse>(Messages.ErrorOccured);
            }
           
        }
    }
}
