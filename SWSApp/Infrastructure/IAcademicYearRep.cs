using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure
{
    public interface IAcademicYearRep : IRepository<AcademicYear>
    {
    }


    public class AcademicYearRep : Repository<AcademicYear> , IAcademicYearRep
    {
        public AcademicYearRep(ApplicationDbContext context): base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }


}
