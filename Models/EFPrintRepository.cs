using System.Linq;

namespace Telefin.Models
{
    public class EFPrintRepository : IPrintRepository
    {
        private ApplicationDbContext context;

        public EFPrintRepository(ApplicationDbContext cxt)
            => context = cxt;

        public IQueryable<Print> Prints
            => context.Prints;
    }
}