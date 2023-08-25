namespace Vorti_Oh.Model.Enums.EnumExtensions;

public static class CardAttributeExtension
{
    private static readonly Dictionary<string, CardAttribute> _map =
        new Dictionary<string, CardAttribute>
        {
            {"Water", CardAttribute.Water },
            {"Dark", CardAttribute.Dark },
            {"Light", CardAttribute.Light },
            {"Fire", CardAttribute.Fire },
            {"Wind", CardAttribute.Wind },
            {"Earth", CardAttribute.Earth },
            {"Divine", CardAttribute.Divine }
        };

    public static string ToString(CardAttribute cardAttribute)
    {
        return _map.FirstOrDefault(map => map.Value == cardAttribute).Key;
    }

    public static CardAttribute ToValue(string input)
    {
        return _map.FirstOrDefault(map => map.Key == input).Value;
    }
}
