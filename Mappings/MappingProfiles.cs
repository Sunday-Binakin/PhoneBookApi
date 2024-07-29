using AutoMapper;
using PhoneBookApi.Dtos;
using PhoneBookApi.Models;

namespace PhoneBookApi.Mappings;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Contacts, ContactsDto>().ReverseMap();
    }
    
}