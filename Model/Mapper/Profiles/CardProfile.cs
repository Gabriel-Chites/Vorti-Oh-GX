using AutoMapper;
using Vorti_Oh.Model.Dtos.Request.CardDtos;
using Vorti_Oh.Model.Dtos.Response.CardDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Profiles;

public class CardProfile : Profile
{
    public CardProfile()
    {
        CreateMap<CreateCardDto, Card>();
        CreateMap<UpdateCardDto, Card>();
        CreateMap<UpdateCardDto, CreateCardDto>();

        CreateMap<ReadCardDto, Card>();
        CreateMap<ReadCardDtoWithRelations, Card>();
    }
}
