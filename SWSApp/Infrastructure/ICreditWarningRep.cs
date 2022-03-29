using Microsoft.EntityFrameworkCore;
using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure;

public interface ICreditWarningRep : IRepository<CreditWarning>
{
    
}

public class CreditWarningRep : Repository<CreditWarning>, ICreditWarningRep
{
    public CreditWarningRep(ApplicationDbContext context) : base(context)
    {

    }

    private ApplicationDbContext ApplicationDbContext => Context as ApplicationDbContext;
}
