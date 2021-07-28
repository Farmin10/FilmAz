using Business.Abstract;
using DTO_s.FilmDTO;
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
    public class FilmsController : ControllerBase
    {
        IFilmService _filmService;

        public FilmsController(IFilmService filmService)
        {
            _filmService = filmService;
        }


        /// <summary>
        /// add film
        /// </summary>
        /// <param name="filmForAddDto"></param>
        /// <returns></returns>
        [HttpPost("addFilm")]
        public async Task<IActionResult> AddFilm(FilmForAddDto filmForAddDto)
        {
           var result= await _filmService.AddFilm(filmForAddDto);
            return Ok(result);
        }
    }
}
