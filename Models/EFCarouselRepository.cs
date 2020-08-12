using System.Linq;
using Telefin.Models;

namespace Telefin.Models
{
    public class EFCarouselRepository : IPrintRepository
    {
        public ApplicationDbContext context;

        public EFCarouselRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Print> Prints => context.Carousel;
    }
}