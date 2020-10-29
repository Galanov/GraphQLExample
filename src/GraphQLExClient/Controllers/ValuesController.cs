using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLExClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly OwnerConsumer _consumer;

        public ValuesController(OwnerConsumer consumer)
        {
            _consumer = consumer;
        }

        /// <summary>
        /// Получение
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Get()
        {
            var owners = await _consumer.GetAllOwners();
            return Ok(owners);
        }

        
        /// <summary>
        /// Получение по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var owner = await _consumer.GetOwner(id);
            return Ok(owner);
        }

        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OwnerInput owner)
        {
            var createdOwner = await _consumer.CreateOwner(owner);
            return Ok(createdOwner);
        }

        /// <summary>
        /// Обновление
        /// </summary>
        /// <param name="id"></param>
        /// <param name="owner"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] OwnerInput owner)
        {
            var updatedOwner = await _consumer.UpdateOwner(id, owner);
            return Ok(updatedOwner);
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Put(Guid id)
        {
            var deleteOwner = await _consumer.DeleteOwner(id);
            return Ok(deleteOwner);
        }
    }
}
