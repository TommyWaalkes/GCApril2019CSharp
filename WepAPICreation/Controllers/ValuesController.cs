using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepAPICreation.Models;

namespace WepAPICreation.Controllers
{
    public class ValuesController : ApiController
    {

        List<string> db = new List<string>() { "Jimmy", "Sally", "Corporal Dan" };
        CarsEntities db2 = new CarsEntities();
        // GET api/values
        public IEnumerable<Car> Get()
        {
            return db2.Cars.ToList();
        }

        // GET api/values/5
        public Car Get(int id)
        {
            if (id >= 0 && id < db2.Cars.Count())
            {
                return db2.Cars.Find(id);
            }
            else
            {
                Car c = new Car();
                c.make = $"No name is found at id {id} nothing has been returned.";
                return c;
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
