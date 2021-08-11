using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genshin.Characters.Core.ProjectCore.V1.Entities;

namespace Genshin.Characters.Core.ProjectCore.V1.Response
{
    public class CharacterResponse
    {
        public class GetCharacterResponse
        {
            public Guid Id { set; get; }
            public string Name { set; get; }
            public int Rarity { set; get; }
            public bool IsLimited { set; get; }
            public string Vision { set; get; }
            public string Region { set; get; }
            public string Weapon { set; get; }
        }
        
        public class DefaultCharacterResponse
        {
            public Guid Id { set; get; }
            public string Name { set; get; }
            public int Rarity { set; get; }
            public string Vision { set; get; }
        }

        public static List<DefaultCharacterResponse> CreateGetCharacterResponse(IEnumerable<Character> character)
        {
            var response = new List<DefaultCharacterResponse>();
            foreach (var item in character)
            {
                response.Add(new DefaultCharacterResponse { Id = item.Id, Name = item.Name, Rarity = item.Rarity, Vision = item.Vision.ToString() });
            }
            return response;
        }

        public static GetCharacterResponse CreateGetCharacterResponse(Character character)
        {
            var response = new GetCharacterResponse
            {
                Id = character.Id,
                Name = character.Name,
                Rarity = character.Rarity,
                IsLimited = character.IsLimited,
                Vision = character.Vision.ToString(),
                Region = character.Region.ToString(),
                Weapon = character.Weapon.ToString()
            };
            return response;
        }
    }
}
