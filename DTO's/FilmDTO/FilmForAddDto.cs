using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_s.FilmDTO
{
    public class FilmForAddDto
    {
        public string FilmName { get; set; }
        public string FilmDuration { get; set; }
        public string FilmDirector { get; set; }
        public bool IsHD { get; set; }
        public int ProductionYearId { get; set; }
        public double IMDB { get; set; }
        public int FilmCountryId { get; set; }
    }
}
