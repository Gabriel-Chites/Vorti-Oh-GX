using System.ComponentModel.DataAnnotations;
using Vorti_Oh.Model.Dtos.Response.CardDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Dtos.Response.DeckDtos;

public class ReadDeckDtoWithRelations
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<ReadCardDto> Cards { get; set; }
}
