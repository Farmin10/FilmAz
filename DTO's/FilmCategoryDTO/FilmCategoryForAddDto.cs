using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_s.FilmCategoryDTO
{
    public class FilmCategoryForAddDto
    {
        public int FilmId { get; set; }
        public List<int> CategoryId { get; set; }
    }
}
