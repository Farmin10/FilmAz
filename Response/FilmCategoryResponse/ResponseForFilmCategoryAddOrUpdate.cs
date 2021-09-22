using DTO_s.CategoryDTO;
using DTO_s.FilmCategoryDTO;
using DTO_s.FilmDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response.FilmCategoryResponse
{
    public class ResponseForFilmCategoryAddOrUpdate
    {
        public FilmForGetDto Film { get; set; }
        public CategoryForGetDto Category { get; set; }
       
    }
}
