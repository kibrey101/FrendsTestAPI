
namespace FrendsTestAPI.Entities;

public class PricingOutput
{
    public required Guid Id { get; set; }
    public required string Data { get; set; }
}


public class PricingInputDto
{
    public required string Data { get; set; }
}

