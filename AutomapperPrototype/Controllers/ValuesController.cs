using System.Collections.Generic;
using System.Web.Http;
using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<PersonViewModel> Get()
        {
            var personDom = new Person
            {
                Age = (decimal)30.00,
                FirstName = "Rahul",
                LastName = "Ballal",
                Id = 10
            };

            var personVm = Mapper.Map<PersonViewModel>(personDom);
            // reverse mapping ?
            var pdom2 = Mapper.Map<Person>(personVm);

            return new[] {personVm};
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
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
