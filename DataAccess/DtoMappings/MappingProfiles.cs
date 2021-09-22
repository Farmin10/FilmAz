using AutoMapper;
using DTO_s.CategoryDTO;
using DTO_s.FilmCategoryDTO;
using DTO_s.FilmCountryDTO;
using DTO_s.FilmDTO;
using DTO_s.ProductionYearDTO;
using Entities.Concrete;
using Response.FilmCategoryResponse;
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
            CreateMap<Film, ResponseForFilmCategoryAddOrUpdate>().ReverseMap();
            CreateMap<Film, FilmCategoryForGetDto>().ReverseMap();
            CreateMap<Film, FilmForGetDto>().ReverseMap();
            CreateMap<Film, CategoryForGetDto>().ReverseMap();



            CreateMap<Category, CategoryForSetDto>().ReverseMap();
            CreateMap<Category, CategoryForGetDto>().ReverseMap();


            CreateMap<FilmCategory, FilmCategoryForAddDto>().ReverseMap();
            CreateMap<FilmCategory, FilmCategoryForGetDto>().ReverseMap();
            CreateMap<FilmCategory, ResponseForFilmCategoryAddOrUpdate>().ReverseMap();
            CreateMap<FilmCategory, FilmForGetDto>().ReverseMap();
            CreateMap<FilmCategory, CategoryForGetDto>().ReverseMap();


            CreateMap<ProductionYear, ProductionYearForGetDto>().ReverseMap();




            CreateMap<FilmCountry, FilmCountryForGetDto>().ReverseMap();
        }
    }
}
