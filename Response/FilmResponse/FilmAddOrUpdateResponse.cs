using DTO_s.FilmCountryDTO;
using DTO_s.ProductionYearDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Response.FilmResponse
{
    public class FilmAddOrUpdateResponse
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmDuration { get; set; }
        public string FilmDirector { get; set; }
        public bool IsHD { get; set; }
        public double IMDB { get; set; }
        public ProductionYearForGetDto ProductionYear { get; set; }
        public FilmCountryForGetDto FilmCountry { get; set; }
    }
}
