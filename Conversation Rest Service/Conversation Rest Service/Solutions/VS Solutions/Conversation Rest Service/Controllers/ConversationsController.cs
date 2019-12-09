using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace ConversationRESTService
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationsController : ControllerBase
    {        
        // GET
        [HttpGet]
        public IEnumerable<Conversation> Get()
        {
            return PersistencyService.Get();                
        }

      
        // GET by ID
        [HttpGet("{id}", Name = "Get")]
        public Conversation Get(string id)
        {
            return PersistencyService.Get(id);
        }

        // POST
        [HttpPost]
        public void Post([FromBody] Conversation value)
        {            
            PersistencyService.Post(value);
        }

        // PUT
        [HttpPut]
        [Route("{id}")]
        public void Put(string id, [FromBody] Conversation value)
        {
            PersistencyService.Put(PersistencyService.Get(id).ID.ToString(), value);            
        }
            
        // DELETE
        [HttpDelete]
        [Route("{id}")]
        public void Delete(string id)
        {
            PersistencyService.Delete(id);
        }

            

        
    }
}
