namespace InsuranceClaims.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using InsuranceClaims.Application.DTOs;
using InsuranceClaims.Application.Interfaces;
[ApiController]
[Route("api/[controller]")]
public class PolicyHolderController : ControllerBase
{
    private readonly IPolicyHolderService _service;

    public PolicyHolderController(IPolicyHolderService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<List<PolicyHolderDto>> GetAll()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{id}")]
    public ActionResult<PolicyHolderDto> GetById(int id)
    {
        var result = _service.GetById(id);
        if (result == null)
            return NotFound();
        return Ok(result);
    }

    [HttpPost]
    public ActionResult<PolicyHolderDto> Create(PolicyHolderDto dto)
    {
        var result = _service.CreateOrUpdate(dto);
        return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
    }
}