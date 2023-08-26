using Vorti_Oh.Model.Dtos.Request.DeckDtos;
using Vorti_Oh.Model.Dtos.Request.Decks;
using Vorti_Oh.Model.Dtos.Response.DeckDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Mapper.Interfaces;

public interface IDeckMapper : IGeneralMapping
    <Deck, CreateDeckDto, UpdateDeckDto, ReadDeckDto, ReadDeckDtoWithRelations>
{
}
