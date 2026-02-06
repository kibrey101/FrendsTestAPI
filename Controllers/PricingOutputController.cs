using FrendsTestAPI.Entities;
using FrendsTestAPI.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace FrendsTestAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PricingOutputController(ApiDbContext dbContext) : ControllerBase
{
    private readonly ApiDbContext _dbContext = dbContext;

    [HttpGet(Name = "GetPricingOutput")]
    public IEnumerable<PricingOutput> Get()
    {
        return [.. _dbContext.PricingOutputs];
    }


    [HttpPost]
    public async Task<ActionResult<PricingOutput>> SaveOutput([FromBody] PricingInputDto input)
    {
        var entity = new PricingOutput
        {
            Id = Guid.NewGuid(),
            Data = input.Data
        };

        _dbContext.PricingOutputs.Add(entity);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction("SaveOutput", new { id = entity.Id }, entity);
    }
}
