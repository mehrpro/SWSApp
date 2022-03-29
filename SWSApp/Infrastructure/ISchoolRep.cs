using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure
{
    public interface ISchoolRep : IRepository<School>
    {
    }

    public class SchoolRep : Repository<School>, ISchoolRep
    {
        public SchoolRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}
