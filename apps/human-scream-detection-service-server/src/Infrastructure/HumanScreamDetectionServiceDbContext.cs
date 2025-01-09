using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HumanScreamDetectionService.Infrastructure;

public class HumanScreamDetectionServiceDbContext : IdentityDbContext<IdentityUser>
{
    public HumanScreamDetectionServiceDbContext(
        DbContextOptions<HumanScreamDetectionServiceDbContext> options
    )
        : base(options) { }
}
