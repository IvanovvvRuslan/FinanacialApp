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
    [Route("[controller]")]
    public class OperationTypeController : Controller
    {
        private readonly IOperationTypeService _operationTypeService;
        public OperationTypeController(IOperationTypeService operationTypeService)
        {
            _operationTypeService = operationTypeService;
        }

        // GET: OperationTypeController
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OperationTypeViewModel>>> GetAll()
        {
            var operationTypes = await _operationTypeService.GetAll();
            return Ok(operationTypes);
        }

        // GET: OperationTypeController/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OperationTypeViewModel>> GetOperationType(int id)
        {
            var operationType = await _operationTypeService.GetById(id);

            if (operationType == null)
                return NotFound();

            return Ok(operationType);
        }

        // POST: OperationTypeController/Create
        [HttpPost]
        public async Task<IActionResult> CreateOperationType(OperationTypeDto operationType)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            await _operationTypeService.Create(operationType);
            
            return Ok();
        }

        //POST: OperationTypeController/Edit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOperationType(int id, OperationTypeDto operationType)
        {
            try
            {
                await _operationTypeService.Update(id, operationType);
                return Ok();
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

        // POST: OperationTypeController/Delete/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOperationType(int id)
        {
            try
            {
                await _operationTypeService.Delete(id);
                return Ok();
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
