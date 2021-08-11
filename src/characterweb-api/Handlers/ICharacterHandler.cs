using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Genshin.Characters.Core.ProjectCore.V1.Entities;

namespace Genshin.Characters.Api.Handlers
{
    public interface ICharacterHandler
    {
        Task<IEnumerable<Character>> GetAll();
        Task<Character> GetById(Guid id);
        Task<Character> GetByName(string name);
    }
}
