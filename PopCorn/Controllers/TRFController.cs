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
using Popcorn.Data.Entities;
using PopCorn.Data.ViewModel;

//TODO: Add AutoMapper and ViewModels
//TODO: Add Async
//TODO: limit return prameters
namespace PopCorn.Controllers
{
    /* Database Table Methods */

    [Route("api/[Controller]")]
    public class TRFController : Controller
    {
        private readonly IMaterialsRepository _repository;
        private readonly ILogger<TRFController> _logger;

        public TRFController(IMaterialsRepository repository, ILogger<TRFController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("Admin/TRF")]
        [NoCache]
        [ProducesResponseType(typeof(List<TRF>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetAsyncTRF()
        {
            try
            {
                var TRFs = await _repository.GetAllTRF();

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

        [HttpGet("Admin/TRF_LinkTable")]
        [NoCache]
        [ProducesResponseType(typeof(List<TRF_LinkTable>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetAsyncTRF_LinkTable()
        {
            try
            {
                var TRFs = await _repository.GetAllTrfViewModel();

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

        /* ViewModels Mehods */

        [HttpGet]
        [NoCache]
        [ProducesResponseType(typeof(List<TrfViewModel>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<IActionResult> GetAsyncTrfViewModel()
        {
            try
            {
                var TRFs = await _repository.GetAllTrfViewModel();

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