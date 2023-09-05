using RedBadgeFinal.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Models.WeaponModels;
using RedBadgeFinal.Models.RegionModels;

namespace RedBadgeFinal.Models.CharacterModels
{
    public class CharacterDetail
    {
        public int Id { get; set; }
        public string OwnerId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public ElementListItem Element { get; set; } = null!;
        public WeaponListItem Weapon { get; set; } = null!;
        public RegionListItem Region { get; set; } = null!;
    }
}
