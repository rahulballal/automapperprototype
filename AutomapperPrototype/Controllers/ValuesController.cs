using System.Collections.Generic;
using System.Web.Http;
using AutomapperPrototype.Domain;
using AutomapperPrototype.ViewModel;
using AutoMapper;

namespace AutomapperPrototype.Controllers
{
    public class ValuesController : ApiController
    {
        // Can mock the mapping now
        private readonly IMappingEngine _mappingEngine;

        public ValuesController(IMappingEngine mappingEngine)
        {
            _mappingEngine = mappingEngine;
        }

        // GET api/values
        // using the static mapper method
        public IEnumerable<PersonViewModel> Get()
        {
            var personDom = new Person
            {
                Age = (decimal)30.00,
                FirstName = "Rahul",
                LastName = "Ballal",
                Id = 10
            };

            // basic mapping
            var personVm = Mapper.Map<PersonViewModel>(personDom);
            
            // reverse mapping 
            var pdom2 = Mapper.Map<Person>(personVm);

            // using custom mapping
            var plistvm = Mapper.Map<PersonListViewModel>(personDom);
            
            return new[] {personVm};
        }

        // GET api/values/5
        //using the injected mapper
        public PersonViewModel Get(int id)
        {
            var personDom = new Person
            {
                Age = (decimal)30.00,
                FirstName = "Rahul",
                LastName = "Ballal",
                Id = 10
            };


            return _mappingEngine.Map<PersonViewModel>(personDom);
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
