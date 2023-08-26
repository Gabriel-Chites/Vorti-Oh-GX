using AutoMapper;
using Vorti_Oh.Model.Dtos.Request.DeckDtos;
using Vorti_Oh.Model.Dtos.Request.Decks;
using Vorti_Oh.Model.Dtos.Response.DeckDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Profiles;

public class DeckProfile : Profile
{
    public DeckProfile()
    {
        CreateMap<CreateDeckDto, Deck>();
        CreateMap<UpdateDeckDto, Deck>();
        CreateMap<UpdateDeckDto, CreateDeckDto>();

        CreateMap<Deck, ReadDeckDto>();
        CreateMap<Deck, ReadDeckDtoWithRelations>();
    }
}
