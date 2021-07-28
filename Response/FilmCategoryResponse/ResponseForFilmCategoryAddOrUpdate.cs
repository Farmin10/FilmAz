using DTO_s.FilmCategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response.FilmCategoryResponse
{
    public class ResponseForFilmCategoryAddOrUpdate
    {
        public int FilmId { get; set; }
        public string  FilmName { get; set; }
        public List<FilmCategoryForGetDto> FilmCategories { get; set; }
       
    }
}
