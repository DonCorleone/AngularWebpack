using System.Collections.Generic;
using System.Threading.Tasks;
using Angular2WebpackVisualStudio.Models;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public interface ILinkRepository
    {
      //  Link GetSingle(int id);
      //  Link Add(Link item);
      //  void Delete(int id);
      //  Link Update(int id, Link item);
        Task<IEnumerable<Link>> GetAllLinks();
       // int Count();
    }
}
