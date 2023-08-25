using System.ComponentModel.DataAnnotations;
using Vorti_Oh.Model.Enums;

namespace Vorti_Oh.Model.Entities;

public class Card
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public CardType CardType { get; set; }

    [Required]
    public int Level { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public CardAttribute CardAttribute { get; set; }

    [Required]
    public Race Race { get; set; }

    public int? AttackPoints { get; set; }

    public int? DefensePoins { get; set; }

    [Required]
    public bool HasEffect { get; set; }

    public ICollection<Deck> Decks { get; set; }

    public Card()
    {
         Decks = new List<Deck>();
    }
}
