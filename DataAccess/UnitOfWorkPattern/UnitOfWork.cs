using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWorkPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        FilmContext _context;
        EfFilmDal _efFilmDal;
        EfLanguageDal _efLanguageDal;
        EfCategoryDal _efCategoryDal;
        EfFamousActorDal _efFamousActorDal;
        EfFilmCategoryDal _efFilmCategoryDal;
        EfFilmFamousActorDal _efFilmFamousActorDal;
        EfFilmLanguageDal _efFilmLanguageDal;
        EfFilmCountryDal _efFilmCountryDal;
        EfProductionYearDal _efProductionYearDal;


        public UnitOfWork(FilmContext context)
        {
            _context = context;
        }




        public void SaveAsync()
        {
              _context.SaveChanges();
        }




        public IFilmDal FilmDal => _efFilmDal ?? new EfFilmDal(_context);
        public ICategoryDal CategoryDal => _efCategoryDal ?? new EfCategoryDal(_context);
        public IFamousActorDal FamousActorDal => _efFamousActorDal ?? new EfFamousActorDal(_context);
        public IFilmCategoryDal FilmCategoryDal => _efFilmCategoryDal ?? new EfFilmCategoryDal(_context);
        public IFilmFamousActorDal FilmFamousActorDal => _efFilmFamousActorDal ?? new EfFilmFamousActorDal(_context);
        public IFilmLanguageDal FilmLanguageDal => _efFilmLanguageDal ?? new EfFilmLanguageDal(_context);
        public IFilmCountryDal FilmCountryDal => _efFilmCountryDal ?? new EfFilmCountryDal(_context);
        public ILanguageDal LanguageDal => _efLanguageDal ?? new EfLanguageDal(_context);
        public IProductionYearDal ProductionYearDal => _efProductionYearDal ?? new EfProductionYearDal(_context);




        public void Dispose()
        {
             _context.Dispose();
        }
    }
}
