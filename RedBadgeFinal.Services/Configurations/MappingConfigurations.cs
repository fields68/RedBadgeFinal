using AutoMapper;
using RedBadgeFinal.Data.Entities;
using RedBadgeFinal.Models.CharacterModels;
using RedBadgeFinal.Models.ElementModels;
using RedBadgeFinal.Models.RegionModels;
using RedBadgeFinal.Models.WeaponModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedBadgeFinal.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations() 
        { 
            CreateMap<Character, CharacterCreate>().ReverseMap();
            CreateMap<Character, CharacterListItem>().ReverseMap();
            CreateMap<Character, CharacterDetail>().ReverseMap();
            CreateMap<Character, CharacterEdit>().ReverseMap();

            CreateMap<Region, RegionCreate>().ReverseMap();
            CreateMap<Region, RegionDetail>().ReverseMap();
            CreateMap<Region, RegionEdit>().ReverseMap();
            CreateMap<Region, RegionListItem>().ReverseMap();

            CreateMap<Element, ElementCreate>().ReverseMap();            
            CreateMap<Element, ElementDetail>().ReverseMap();            
            CreateMap<Element, ElementEdit>().ReverseMap();            
            CreateMap<Element, ElementListItem>().ReverseMap();            
            
            CreateMap<Weapon, WeaponCreate>().ReverseMap();
            CreateMap<Weapon, WeaponDetail>().ReverseMap();
            CreateMap<Weapon, WeaponEdit>().ReverseMap();
            CreateMap<Weapon, WeaponListItem>().ReverseMap();
        }
    }
}
