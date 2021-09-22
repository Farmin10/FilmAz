using Business.Abstract;
using DTO_s.FilmCategoryDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmAzWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmCategoriesController : ControllerBase
    {
        IFilmCategoryService _filmCategoryService;

        public FilmCategoriesController(IFilmCategoryService filmCategoryService)
        {
            _filmCategoryService = filmCategoryService;
        }


        [HttpPost("addFilmCategory")]
        public async Task<IActionResult> AddFilmCategory(FilmCategoryForAddDto filmCategoryForAddDto)
        {
            var result= await _filmCategoryService.Add(filmCategoryForAddDto);
            return Ok(result);
        }
    }
}
