using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular2WebpackVisualStudio.Infrastructure;
using Angular2WebpackVisualStudio.Models;
using Angular2WebpackVisualStudio.Repositories.Links;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Angular2WebpackVisualStudio.Controller
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class LinksController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly ILinkRepository _linksRepository;

        public LinksController(ILinkRepository linksRepository)
        {
            _linksRepository = linksRepository;
        }

        [NoCache]
        [HttpGet]
        public Task<IEnumerable<Link>> Get()
        {
            return GetLinkInternal();
        }

        private async Task<IEnumerable<Link>> GetLinkInternal()
        {
            return await _linksRepository.GetAllLinks();
        }

/*         [HttpPost]
        public IActionResult Add([FromBody] Link link)
        {
            if (link == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Link newLink = _linksRepository.Add(link);

            return CreatedAtRoute("GetSingleLink", new { id = newLink.Id }, newLink);
        } */

/*         [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdate(int id, [FromBody] JsonPatchDocument<Link> patchDoc)
        {
            if (patchDoc == null)
            {
                return BadRequest();
            }

            Link existingEntity = _linksRepository.GetSingle(id);

            if (existingEntity == null)
            {
                return NotFound();
            }

            Link link = existingEntity;
            patchDoc.ApplyTo(link, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Link updatedLink = _linksRepository.Update(id, link);

            return Ok(updatedLink);
        } */

/*         [HttpGet]
        [Route("{id:int}", Name = "GetSingleLink")]
        public IActionResult Single(int id)
        {
            Link link = _linksRepository.GetSingle(id);

            if (link == null)
            {
                return NotFound();
            }

            return Ok(link);
        } */

/*         [HttpDelete]
        [Route("{id:int}")]
        public IActionResult Remove(int id)
        {
            Link link = _linksRepository.GetSingle(id);

            if (link == null)
            {
                return NotFound();
            }

            _linksRepository.Delete(id);
            return NoContent();
        } */

/*         [HttpPut]
        [Route("{id:int}")]
        public IActionResult Update(int id, [FromBody]Link link)
        {
            var linkToCheck = _linksRepository.GetSingle(id);

            if (linkToCheck == null)
            {
                return NotFound();
            }

            if (id != link.Id)
            {
                return BadRequest("Ids do not match");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Link updatedLink = _linksRepository.Update(id, link);

            return Ok(updatedLink);
        } */
    }
}
