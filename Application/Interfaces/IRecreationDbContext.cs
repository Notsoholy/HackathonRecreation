using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRecreationDbContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        DbSet<AdditionalService> AdditionalServices { get; set; }

        DbSet<Disease> Diseases { get; set; }

        DbSet<HealingMethod> HealingMethods { get; set; }

        DbSet<RecreationObject> RecreationObjects { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<UserMessage> UserMessages { get; set; }

        DbSet<Location> Locations { get; set; }
    }
}
