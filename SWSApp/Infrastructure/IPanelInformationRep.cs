using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWSApp.Models;
using SWSApp.Models.Entities;

namespace SWSApp.Infrastructure;

public interface IPanelInformationRep : IRepository<PanelInformation>
{
    ValueTask<PanelInformation?> FirstRecorder();
    string[] SendNumber();
    string[] WarningReceiver();
    int MinCredit();
    int MidCredit();
}

public class PanelInformationRep : Repository<PanelInformation>, IPanelInformationRep
{
    public PanelInformationRep(ApplicationDbContext context) : base(context)
    {
    }

    ApplicationDbContext ApplicationDbContext
    {
        get{return Context as ApplicationDbContext;}
    }

    public async ValueTask<PanelInformation?> FirstRecorder()
    {
        return await ApplicationDbContext.PanelInformations.FirstOrDefaultAsync(x=>x.IsActive);
    }

    public string[] SendNumber()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? new[] { "Error" } : new[] { result.SendNumber };
    }

    public string[] WarningReceiver()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? new[] { "Error" } : new[] { result.WarningReceiver };
    }

    public int MinCredit()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? 0 :  result.MinCredit ;
    }

    public int MidCredit()
    {
        var result = ApplicationDbContext.PanelInformations.FirstOrDefault();
        return result == null ? 0 : result.MidCredit;
    }
}