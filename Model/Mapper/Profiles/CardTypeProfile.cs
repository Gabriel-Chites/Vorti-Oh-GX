using AutoMapper;
using Vorti_Oh.Model.Dtos.Request.CardTypeDto;
using Vorti_Oh.Model.Dtos.Request.CardTypeDtos;
using Vorti_Oh.Model.Dtos.Response.CardTypeDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Profiles;

public class CardTypeProfile : Profile
{
    public CardTypeProfile()
    {
        CreateMap<CreateCardTypeDto, CardType>();
        CreateMap<UpdateCardTypeDto, CardType>();
        CreateMap<UpdateCardTypeDto, CreateCardTypeDto>();

        CreateMap<CardType, ReadCardTypeDto>();
        CreateMap<CardType, ReadCardTypeDtoWithRelations>();
    }
}
