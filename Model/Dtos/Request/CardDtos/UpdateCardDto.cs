using Vorti_Oh.Model.Entities;
using Vorti_Oh.Model.Enums;

namespace Vorti_Oh.Model.Dtos.Request.CardDtos;

public class UpdateCardDto
{
    public string Name { get; set; }

    public int CardTypeId { get; set; }

    public int Level { get; set; }

    public string? Description { get; set; }

    public CardAttribute CardAttribute { get; set; }

    public Race Race { get; set; }

    public int? AttackPoints { get; set; }

    public int? DefensePoins { get; set; }

    public bool HasEffect { get; set; }
}
