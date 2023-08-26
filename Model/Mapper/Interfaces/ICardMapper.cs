using Vorti_Oh.Model.Dtos.Request.CardDtos;
using Vorti_Oh.Model.Dtos.Response.CardDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Interfaces;

public interface ICardMapper : IGeneralMapping
    <Card, CreateCardDto, UpdateCardDto, ReadCardDto, ReadCardDtoWithRelations>
{

}
