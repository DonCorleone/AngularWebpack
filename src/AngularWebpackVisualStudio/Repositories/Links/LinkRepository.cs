using System.Collections.Generic;
using System.Threading.Tasks;
using Angular2WebpackVisualStudio.Data;
using Angular2WebpackVisualStudio.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public class LinkRepository  : ILinkRepository
    {

        private readonly LinkContext _context = null;
        public LinkRepository(IOptions<Settings> settings)
        {
            _context = new LinkContext(settings);
        }

        public async Task<IEnumerable<Link>> GetAllLinks()
        {
            try
            {
                return await _context.Links.Find(_ => true).ToListAsync();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}