using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure
{
    public interface ITodayRegisteredRep : IRepository<TodayRegistered>
    {

    }

    public class TodayRegisteredRep : Repository<TodayRegistered>, ITodayRegisteredRep
    {
        public TodayRegisteredRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)Context;
    }
}