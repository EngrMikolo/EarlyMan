using System.Linq;

namespace Telefin.Models
{
    public class EFPromotionRepository : IPromotionRepository
    {
        private ApplicationDbContext context;

        public EFPromotionRepository(ApplicationDbContext ctx)
            => context = ctx;

        public IQueryable<Promotion> Promos
            => context.Promos;
    }
}