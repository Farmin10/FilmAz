using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FilmCountry
    {
        public int FilmCountryId { get; set; }
        public string  CountryName { get; set; }
        public List<Film> Films { get; set; }
    }
}
