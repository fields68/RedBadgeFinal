using RedBadgeFinal.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Models.CharacterModels
{
    public class CharacterListItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int ElementId { get; set; }
        public int WeaponId { get; set; }
        public int RegionId { get; set; }
    }
}
