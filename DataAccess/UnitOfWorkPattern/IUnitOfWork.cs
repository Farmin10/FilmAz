using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorkPattern
{
    public interface IUnitOfWork:IDisposable
    {
         IFilmDal FilmDal { get; }
         IFilmLanguageDal FilmLanguageDal { get; }
         ICategoryDal CategoryDal { get; }
         IFamousActorDal FamousActorDal { get; }
         IFilmCategoryDal FilmCategoryDal { get; }
         IFilmFamousActorDal FilmFamousActorDal { get; }
         IFilmCountryDal FilmCountryDal { get; }
         ILanguageDal LanguageDal { get; }
         IProductionYearDal ProductionYearDal { get; }
         void SaveAsync();
    }
}
