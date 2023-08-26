using Vorti_Oh.Model.Dtos.Request.CardTypeDto;
using Vorti_Oh.Model.Dtos.Request.CardTypeDtos;
using Vorti_Oh.Model.Dtos.Response.CardTypeDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Interfaces;

public interface ICardTypeMapper : 
    IGeneralMapping<CardType, CreateCardTypeDto, UpdateCardTypeDto, ReadCardTypeDto, ReadCardTypeDtoWithRelations>
{
}
