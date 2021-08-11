using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.RegionEnum;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.VisionEnum;
using static Genshin.Characters.Core.ProjectCore.V1.Enums.WeaponClassEnum;

namespace Genshin.Characters.Core.ProjectCore.V1.Entities
{
    public record Character
    {
        public Guid Id { init; get; }
        public string Name { init; get; }
        [Range(1, 5)]
        public int Rarity { init; get; }
        public bool IsLimited { init; get; }
        public Vision Vision { init; get; }
        public Region Region { init; get; }
        public WeaponClass Weapon { init; get; }

    }
}
