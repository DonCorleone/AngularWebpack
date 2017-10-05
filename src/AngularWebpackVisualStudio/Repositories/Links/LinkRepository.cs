using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Angular2WebpackVisualStudio.Models;
using Newtonsoft.Json;

namespace Angular2WebpackVisualStudio.Repositories.Links
{
    public class LinksRepository : ILinksRepository
    {
        private readonly ConcurrentDictionary<int, Link> _storage = new ConcurrentDictionary<int, Link>();

        public LinksRepository()
        {
            var resultsInString = @"[{
                ""Id"": ""1"",
                ""Name"": ""AikidoLuzern"",
                ""Desc"":""Aikido ist eine moderne Bewegungs- und Verteidigungskunst, die keinen Wettkampf und weder Sieger noch Verlierer kennt."",
                ""Url"":""http://www.aikido-luzern.ch/"",
                ""UrlDesc"":""www.aikido-luzern.ch""
            },
            {
                ""Id"": ""2"",
                ""Name"": ""BrunoHaechler"",
                ""Desc"":""Kinder, Lieder und Geschichten. Mit Schalk, Poesie und flockigem Groove."",
                ""Url"":""http://www.brunohaechler.ch/"",
                ""UrlDesc"":""www.brunohaechler.ch""
            },
            {
                ""Id"": ""3"",
                ""Name"": ""Funinglish"",
                ""Desc"":""Mehrere Sprachen zu beherrschen, kann Türen öffnen.<br>Angebote für Kinder, Jugendliche und Erwachsene."",
                ""Url"":""http://www.funenglish.ch/"",
                ""UrlDesc"":""www.funenglish.ch""
            },
            {
                ""Id"": ""4"",
                ""Name"": ""FamilienStadtfuehrer"",
                ""Desc"":""Ein paar Schnipsel aus unseren Rubrikzeichnungen, eine Hand voll Einträge aus dem Buch, einige neue Empfehlungen und immer aktuell."",
                ""Url"":""http://www.familienstadtfuehrer.ch/"",
                ""UrlDesc"":""www.familienstadtfuehrer.ch""
            }]";
            var resultsInArray = JsonConvert.DeserializeObject<Link[]>(resultsInString);
            foreach (var item in resultsInArray)
            {
                _storage.TryAdd(item.Id, item);
            }
        } 

        public Link GetSingle(int id)
        {
            Link link;
            return _storage.TryGetValue(id, out link) ? link : null;
        }

        public Link Add(Link item)
        {
            item.Id = !GetAll().Any() ? 1 : GetAll().Max(x => x.Id) + 1;

            if (_storage.TryAdd(item.Id, item))
            {
                return item;
            }

            throw new Exception("Item could not be added");
        }

        public void Delete(int id)
        {
            Link link;
            if (!_storage.TryRemove(id, out link))
            {
                throw new Exception("Item could not be removed");
            }
        }

        public Link Update(int id, Link item)
        {
            _storage.TryUpdate(id, item, GetSingle(id));
            return item;
        }

        public ICollection<Link> GetAll()
        {
            return _storage.Values;
        }

        public int Count()
        {
            return _storage.Count;
        }
    }
}