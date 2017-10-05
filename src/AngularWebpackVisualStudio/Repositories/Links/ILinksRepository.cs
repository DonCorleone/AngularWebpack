using System.Collections.Generic;
using Angular2WebpackVisualStudio.Models;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public interface ILinksRepository
    {
        Link GetSingle(int id);
        Link Add(Link item);
        void Delete(int id);
        Link Update(int id, Link item);
        ICollection<Link> GetAll();
        int Count();
    }
}
