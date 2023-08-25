using Vorti_Oh.Model.Dtos.Response.CardDtos;

namespace Vorti_Oh.Model.Dtos.Response.CardTypeDtos;

public class ReadCardTypeDto
{
    public int Id { get; set; }

    public string Description { get; set; }

    public ReadCardDto Card { get; set; }
}
