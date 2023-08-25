using System.ComponentModel.DataAnnotations;

namespace Vorti_Oh.Model.Entities;

public class Deck
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Card> Cards { get; set; }
    
    public Deck()
    {
        Cards = new List<Card>();
    }
}