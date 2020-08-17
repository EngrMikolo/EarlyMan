using System.Linq;

namespace Telefin.Models
{
    public interface IPromotionRepository
    {
        IQueryable<Promotion> Promos { get; }
    }
}