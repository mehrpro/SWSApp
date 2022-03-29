using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure
{
    public interface IStudentRep: IRepository<Student>
    {
    }


    public class StudentRep : Repository<Student> , IStudentRep
    {
        public StudentRep(ApplicationDbContext context): base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext
        {
            get { return (ApplicationDbContext)Context; }
        }
    }
}
