using System.Linq;
using Telefin.Models;

namespace Telefin.Models
{
    public class EFPrintRepository:IPrintRepository
    {
        public ApplicationDbContext context;

        public EFPrintRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Print> Prints => context.Prints;
    }
}
