using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PopCorn.Data;
using Microsoft.Extensions.Logging;
using Popcorn.Entities;
using System.Collections;
using PopCorn.Data.Entities;
using PopCorn.Infrastructure;

//TODO: Add AutoMapper and ViewModels
//TODO: Add Async
//TODO: limit return prameters
namespace PopCorn.Controllers
{
    [Route("api/[Controller]")]
    public class TRFController : Controller
    {
        private readonly IMaterialsRepository _repository;
        private readonly ILogger<TRFController> _logger;

        public TRFController(IMaterialsRepository repository, ILogger<TRFController> logger )
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        [NoCache]
        public async Task<IActionResult> GetAsync()
        {
            try
            {
                var TRFs = await _repository.GetAllTRFs();

                if (TRFs != null)
                {
                    return Ok(TRFs);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }   
    }
}