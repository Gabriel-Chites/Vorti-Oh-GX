using Vorti_Oh.Model.Dtos.Response.CardDtos;
using Vorti_Oh.Model.Entities;

namespace Vorti_Oh.Model.Dtos.Response.CardTypeDtos;

public class ReadCardTypeDtoWithRelations
{
    public int Id { get; set; }

    public string Description { get; set; }

    public ReadCardDto Card { get; set; }

    public ICollection<Card> Cards { get; set; }
}
