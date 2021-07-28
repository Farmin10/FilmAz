using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Film
    {
        public int FilmId { get; set; }
        public string  FilmName { get; set; }
        public string  FilmDuration { get; set; }
        public string  FilmDirector { get; set; }
        public bool IsHD { get; set; }
        public int ProductionYearId { get; set; }
        public double IMDB { get; set; }
        public ProductionYear ProductionYear { get; set; }
        public int FilmCountryId { get; set; }
        public FilmCountry FilmCountry { get; set; }
        [JsonIgnore]
        public List<FilmLanguage> FilmLanguages { get; set; }
        [JsonIgnore]
        public List<FilmFamousActor> FilmFamousActors { get; set; }
        [JsonIgnore]
        public List<FilmCategory> FilmCategories { get; set; }
    }
}
