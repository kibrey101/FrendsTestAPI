

using FrendsTestAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FrendsTestAPI.Persistence;

public class ApiDbContext(DbContextOptions<ApiDbContext> options) : DbContext(options)
{
    public DbSet<PricingOutput> PricingOutputs { get; set; }
}