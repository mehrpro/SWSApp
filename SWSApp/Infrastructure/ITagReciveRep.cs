using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure
{
    public interface ITagReciveRep : IRepository<tagrecive>
    {
        Task<List<tagrecive>> GetAllSending();

    }


    public class TagReciveRep : Repository<tagrecive>, ITagReciveRep
    {
        public TagReciveRep(ApplicationDbContext context) : base(context)
        {

        }

        public ApplicationDbContext ApplicationDbContext => (ApplicationDbContext)Context;


        public async Task<List<tagrecive>> GetAllSending()
        {
            return await ApplicationDbContext.tagrecive
                .Where(x => x.Delivery == "entry" || x.Delivery == "exit")
                .Include(x => x.Receiver.Student)
                .ToListAsync();
                
        }
    }
    
    
}
