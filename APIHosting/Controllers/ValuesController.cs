using APIHosting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIHosting.Controllers
{
    public class ValuesController : ApiController
    {
        CowboysEntities db = new CowboysEntities();

        // GET api/values
        public IEnumerable<Cowboy> Get()
        {
            return db.Cowboys.ToList();
        }

        // GET api/values/5
        public Cowboy Get(int id)
        {
            Cowboy boy = db.Cowboys.Find(id);
            return boy;
        }

        public Cowboy GetRandomCowboy()
        {
            Random r = new Random();
            int pick = r.Next(1, db.Cowboys.Count());
            Cowboy c = db.Cowboys.Find(pick);
            return c;
        }

        // POST api/values
        //Put in a paramater in the method for each property in our model
        public string Post([FromBody]string value)
        {
            return "hello world";
        }

        // PUT api/values/5
        public string Put(int id, string property, string value)
        {
            Cowboy c = db.Cowboys.Find(id);
            if(c != null)
            {
                switch (property.ToLower())
                {
                    case "loses":
                        c.Loses = int.Parse(value);
                        break;
                }
                db.Cowboys.AddOrUpdate(c);
                db.SaveChanges();
            }
            else
            {
                return $"No record found at {id} please try another index. Db not updated.";
            }

            return $"Record at id {id} Successfully updated";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            Cowboy c = db.Cowboys.Find(id);

            if (c == null)
            {
                return $"Nothing found at {id}. Db not updated";
            }
            else
            {
                db.Cowboys.Remove(c);
                db.SaveChanges();
                return $"That cowboy at {id} is now pushing up daisies. Cowboy removed from DB.";
            }
        }
    }
}
