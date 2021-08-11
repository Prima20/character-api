using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Genshin.Characters.Api.Handlers;
using Genshin.Characters.Core.ProjectCore.V1.Entities;
using static Genshin.Characters.Core.ProjectCore.V1.Response.CharacterResponse;

namespace Genshin.Characters.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private ICharacterHandler _characterHandler;
        public CharacterController(ICharacterHandler characterHandler)
        {
            _characterHandler = characterHandler;
        }

        //GET
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCharacterResponse), 200)]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Character> character = await _characterHandler.GetAll();
            var response = CreateGetCharacterResponse(character);
            return Ok(response);
        }

        //GET /{id}
        [HttpGet("{id}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(GetCharacterResponse), 200)]
        public async Task<IActionResult> GetById(Guid id)
        {
            Character character = await _characterHandler.GetById(id);
            if(character is null)
            {
                return NotFound();
            }
            var response = CreateGetCharacterResponse(character);
            return Ok(response);
        }

    }
}
