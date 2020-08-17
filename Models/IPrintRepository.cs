using System.Linq;

namespace Telefin.Models
{
    public interface IPrintRepository
    {
        IQueryable<Print> Prints { get; }
    }
}