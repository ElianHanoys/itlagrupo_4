using Microsoft.AspNetCore.Mvc;
using itlagrupo_4.Domain.Entities;
using itlagrupo_4.Infrastructure.Interfaces;
using itlagrupo_4.Infrastructure.Models;

namespace InstitucionSol.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class jobsController : ControllerBase
    {
        private readonly IjobsRepository jobsRepository;

        public jobsController (IjobsRepository jobsRepository)
        {
            this.jobsRepository = jobsRepository;
        }
        [HttpGet("GetJobs")]
        public IActionResult Get()
        {
            var jobs = this.jobsRepository.GetEntities();
            return Ok(jobs);
        }




        [HttpGet("Getjobs")]
        public IActionResult Get([FromQuery] int id)
        {
            var jobs = new jobsmodel();


            try
            {
                jobs = this.jobsRepository.GetEntities(id);
            }
            catch (jobsException ex)
            {
                var result = new { Success = false, ErrorMessage = ex.Message };
                return BadRequest(result);
            }
            return Ok(jobs);
        }



        [HttpPost("Save")]
        public IActionResult Post([FromBody] jobs jobs)
        {
            this.jobsRepository.Add(jobs);
            return Ok();
        }


        [HttpPost("Update")]
        public IActionResult Put([FromBody] jobs jobs)
        {
            this.jobsRepository.Update(jobs);
            return Ok();
        }


    }
}