using Genshin.Characters.Core.ProjectCore.V1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Genshin.Characters.Core.ProjectCore.V1.Dummy.CharacterDummy;

namespace Genshin.Characters.Api.Handlers
{
    /// <summary>
    /// Character handler using data dummy
    /// </summary>
    public class CharacterHandler : ICharacterHandler
    {
        public async Task<IEnumerable<Character>> GetAll()
        {
            return await Task.FromResult(CharactersDummyList);
        }

        public async Task<Character> GetById(Guid id)
        {
            Character character = CharactersDummyList.Where(character => character.Id == id).SingleOrDefault();
            return await Task.FromResult(character);
        }

        public async Task<Character> GetByName(string name)
        {
            Character character = CharactersDummyList.Where(character => character.Name == name).SingleOrDefault();
            return await Task.FromResult(character);
        }
    }
}
