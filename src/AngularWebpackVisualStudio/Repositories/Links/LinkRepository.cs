using System.Collections.Generic;
using System.Threading.Tasks;
using Angular2WebpackVisualStudio.Data;
using Angular2WebpackVisualStudio.Models;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public class LinkRepository : ILinkRepository
    {

        private readonly LinkContext _context = null;
        public LinkRepository(IOptions<Settings> settings)
        {
            _context = new LinkContext(settings);
        }

        public async Task AddLink(Link item)
        {
            try
            {
                await _context.Links.InsertOneAsync(item);
            }
            catch (System.Exception ex)
            {
                
                throw ex;
            }
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

        public async Task<Link> GetLink(string id)
        {
            //    return this._collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;

            var filter = Builders<Link>.Filter.Eq("Id", ObjectId.Parse(id));
            try
            {
                return await _context.Links
                                .Find(filter)
                                .FirstOrDefaultAsync();
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}