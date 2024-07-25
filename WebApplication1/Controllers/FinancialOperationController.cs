using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task11.Data;
using Task11.DTOs;
using Task11.Exceptions;
using Task11.Models;
using Task11.Services;
using Task11.ViewModels;

namespace Task11.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class FinancialOperationController : Controller
    {
        private readonly IFinancialOperationService _financialOperationService;
                
        public FinancialOperationController(IFinancialOperationService financialOperationService)
        {
            _financialOperationService = financialOperationService;
        }

        // GET: FinancialOperationController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialOperationViewModel>>> GetAll()
        {
            var financialOperations = await _financialOperationService.GetAll();
            return Ok(financialOperations);
        }

        // GET: FinancialOperationController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FinancialOperationViewModel>> GetFinancialOperation([FromRoute]int id)
        { 
            var financialOperation = await _financialOperationService.GetById(id);

            if (financialOperation == null)
                return NotFound();
            
            return Ok(financialOperation);
        }

        // GET: FinancialOperationController/Create
        [HttpPost]
        public async Task<IActionResult> CreateFinancialOperation([FromBody]FinancialOperationDto financialOperation)
        { 
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _financialOperationService.Create(financialOperation);

            return Ok();
        }

        // GET: FinancialOperationController/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFinancialOperation([FromRoute]int id, [FromBody]FinancialOperationDto financialOperation)
        {
            try
            {
                await _financialOperationService.Update(id, financialOperation);
                return Ok();
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            { 
                return StatusCode (500, ex.Message);
            }
        }

        // GET: FinancialOperationController/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFinancialOperation([FromRoute] int id)
        {
            try
            {
                await _financialOperationService.Delete(id);
                return Ok("Financial operation deleted successfully");
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex) 
            { 
                return StatusCode(500, ex.Message);
            }
        }
    }
}
