using Microsoft.AspNetCore.Mvc;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Domain.Repository;
using itlagrupo_4.Infrastructure.Core;
using Microsoft.Extensions.Logging;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace itlagrupo_4.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TitlesController : ControllerBase {

        private readonly ITitlesRepository titlesRepository;

        public TitlesController(ITitlesRepository titlesRepository)
            {
            this.titlesRepository = titlesRepository;
            }

        [HttpGet("GetTitles")]
        public IActionResult Get()
        {
            var titles = this.titlesRepository.GetEntities();
            return Ok(titles);
        }

        [HttpGet("GetTitlesById")]
        public IActionResult Get([FromQuery] int id)
        {
            TitlesModel title = null;

            try
            {
                var entity = titlesRepository.GetEntityById(id);
                title = new TitlesModel
                {
                    titlesID = entity.titlesID,
                    titles = entity.titles,
                };
            }
            catch (Exception ex)
            {
                var result = new { Success = false, ErrorMessage = ex.Message };
                return BadRequest(result);
            }

            return Ok(title);
        }


        [HttpPost("Save")]
        public IActionResult Post([FromBody] Titles title)
        {
            this.titlesRepository.save(title);
            return Ok();
        }

        [HttpPost("Update")]
        public IActionResult Put([FromBody] Titles title)
        {
            this.titlesRepository.update(title);
            return Ok();
        }
    }
}

