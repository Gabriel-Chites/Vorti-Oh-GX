namespace Vorti_Oh.Model.Enums.EnumExtensions;

public static class RaceExtension
{
    private static readonly Dictionary<string, Race> _map =
        new Dictionary<string, Race>
        {
            {"Wyrm", Race.Wyrm },
            {"Winged-Beast", Race.Winged_Beast },
            {"Rock", Race.Rock },
            {"Sea Serpent", Race.Sea_Serpent },
            {"Spellcaster", Race.Spellcaster},
            {"Thunder", Race.Thunder },
            {"Warrior", Race.Warrior },
            {"Beast", Race.Beast },
            {"Aqua", Race.Aqua },
            {"Dinosaur", Race.Dinosaur },
            {"Beast-Warrior", Race.Beast_Warrior },
            {"Fiend", Race.Fiend },
            {"Fairy", Race.Fairy },
            {"Cyberse", Race.Cyberse },
            {"Dragon", Race.Dragon },
            {"Reptile", Race.Reptile },
            {"Plant", Race.Plant },
            {"Creator God", Race .Creator_God},
            {"Divine-Beast", Race.Divine_Beast },
            {"Fish", Race.Fish },
            {"Zombie", Race.Zombie },
            {"Illusion", Race.Illusion },
            {"Pyro", Race.Pyro },
            {"Psychic", Race.Psychic },
            {"Machine", Race.Machine },
            {"Insect", Race.Insect},
            {"Continuos Trap", Race.ContinuosTrap},
            {"Normal Trap", Race.NormalTrap},
            {"Response Trap", Race.ResponseTrap},
            {"Continous Magic", Race.ContinuosMagic},
            {"Equipment Magic", Race.EquipmentMagic},
            {"Normal Magic", Race.NormalMagic},
            {"Quick Magic", Race.QuickMagic},
            {"Field Magic", Race.FieldMagic},
            {"Ritual Magic", Race.RitualMagic},

        };

    public static string ToString(Race race)
    {
        return _map.FirstOrDefault(map => map.Value == race).Key;
    }

    public static Race ToValue(string input)
    {
        return _map.FirstOrDefault(map => map.Key == input).Value;
    }
}
