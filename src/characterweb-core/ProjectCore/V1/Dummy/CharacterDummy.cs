using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Genshin.Characters.Core.ProjectCore.V1.Entities;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.RegionEnum;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.VisionEnum;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.WeaponClassEnum;

namespace Genshin.Characters.Core.ProjectCore.V1.Dummy
{
    /// <summary>
    /// Dummy character because we are not using database in here
    /// </summary>
    public static class CharacterDummy
    {
        public static List<Character> CharactersDummyList = new()
        {
            new Character { Id = Guid.NewGuid(), Name = "jean", IsLimited = false, Weapon = WeaponClass.Sword, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "diluc", IsLimited = false, Weapon = WeaponClass.Claymore, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Pyro },
            new Character { Id = Guid.NewGuid(), Name = "venti", IsLimited = true, Weapon = WeaponClass.Bow, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "klee", IsLimited = true, Weapon = WeaponClass.Catalyst, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Pyro },
            new Character { Id = Guid.NewGuid(), Name = "barbara", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Hydro },
            new Character { Id = Guid.NewGuid(), Name = "keqing", IsLimited = false, Weapon = WeaponClass.Sword, Rarity = 5, Region = Region.Liyue, Vision = Vision.Electro },
            new Character { Id = Guid.NewGuid(), Name = "zhongli", IsLimited = true, Weapon = WeaponClass.Polearm, Rarity = 5, Region = Region.Liyue, Vision = Vision.Geo },
            new Character { Id = Guid.NewGuid(), Name = "xinqiu", IsLimited = false, Weapon = WeaponClass.Sword, Rarity = 4, Region = Region.Liyue, Vision = Vision.Hydro },
            new Character { Id = Guid.NewGuid(), Name = "qiqi", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 5, Region = Region.Liyue, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "razor", IsLimited = true, Weapon = WeaponClass.Sword, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Electro },
            new Character { Id = Guid.NewGuid(), Name = "ningguang", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Liyue, Vision = Vision.Geo },
            new Character { Id = Guid.NewGuid(), Name = "childe", IsLimited = true, Weapon = WeaponClass.Bow, Rarity = 5, Region = Region.Snezhnaya, Vision = Vision.Hydro },
            new Character { Id = Guid.NewGuid(), Name = "xiao", IsLimited = true, Weapon = WeaponClass.Polearm, Rarity = 5, Region = Region.Liyue, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "yanfei", IsLimited = true, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Liyue, Vision = Vision.Pyro },
            new Character { Id = Guid.NewGuid(), Name = "xinyain", IsLimited = true, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Liyue, Vision = Vision.Pyro },
            new Character { Id = Guid.NewGuid(), Name = "sucrose", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "rosaria", IsLimited = true, Weapon = WeaponClass.Polearm, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "noelle", IsLimited = false, Weapon = WeaponClass.Claymore, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Geo },
            new Character { Id = Guid.NewGuid(), Name = "mona", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Hydro },
            new Character { Id = Guid.NewGuid(), Name = "lisa", IsLimited = false, Weapon = WeaponClass.Catalyst, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Electro },
            new Character { Id = Guid.NewGuid(), Name = "kazuha", IsLimited = true, Weapon = WeaponClass.Sword, Rarity = 5, Region = Region.Inazuma, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "hu tao", IsLimited = true, Weapon = WeaponClass.Polearm, Rarity = 5, Region = Region.Liyue, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "diona", IsLimited = true, Weapon = WeaponClass.Bow, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "eula", IsLimited = true, Weapon = WeaponClass.Claymore, Rarity = 5, Region = Region.Mondstadt, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "ganyu", IsLimited = true, Weapon = WeaponClass.Bow, Rarity = 5, Region = Region.Liyue, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "beidou", IsLimited = true, Weapon = WeaponClass.Claymore, Rarity = 4, Region = Region.Liyue, Vision = Vision.Electro },
            new Character { Id = Guid.NewGuid(), Name = "amber", IsLimited = false, Weapon = WeaponClass.Bow, Rarity = 4, Region = Region.Mondstadt, Vision = Vision.Pyro },
            new Character { Id = Guid.NewGuid(), Name = "ayaka", IsLimited = true, Weapon = WeaponClass.Sword, Rarity = 5, Region = Region.Inazuma, Vision = Vision.Cyro },
            new Character { Id = Guid.NewGuid(), Name = "sayu", IsLimited = true, Weapon = WeaponClass.Claymore, Rarity = 4, Region = Region.Inazuma, Vision = Vision.Anemo },
            new Character { Id = Guid.NewGuid(), Name = "yoimiya", IsLimited = true, Weapon = WeaponClass.Bow, Rarity = 5, Region = Region.Inazuma, Vision = Vision.Pyro }
        };
    }
}
