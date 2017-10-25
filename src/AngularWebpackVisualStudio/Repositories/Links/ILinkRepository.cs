using System.Collections.Generic;
using System.Threading.Tasks;
using Angular2WebpackVisualStudio.Models;
using MongoDB.Bson;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public interface ILinkRepository
    {
        Task<Link> GetLink(string id);
        //  Link Add(Link item);
        //  void Delete(int id);
        //  Link Update(int id, Link item);
        Task<IEnumerable<Link>> GetAllLinks();
        // int Count();
    }
}
