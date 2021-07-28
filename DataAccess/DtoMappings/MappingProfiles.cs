using AutoMapper;
using DTO_s.FilmCategoryDTO;
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

namespace DataAccess.DtoMappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Film, FilmForAddDto>().ReverseMap();
            CreateMap<Film, FilmAddOrUpdateResponse>().ReverseMap();


            CreateMap<FilmCategory, FilmCategoryForAddDto>().ReverseMap();


            CreateMap<ProductionYear, ProductionYearForGetDto>().ReverseMap();




            CreateMap<FilmCountry, FilmCountryForGetDto>().ReverseMap();
        }
    }
}
