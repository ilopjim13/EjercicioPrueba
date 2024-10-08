using EjercicioPrueba.interfaces;
using EjercicioPrueba.protections;

namespace EjercicioPrueba.equip;

public class Equip
{
    public Equip(IEquippable? handRight, IEquippable? handLeft, Protection?  helmet, Protection? bodyArmor, Protection? gauntlets, Protection? pants, Protection? boots) => (HandRight, HandLeft, Helmet, BodyArmor, Gauntlets, Pants, Boots) = (handRight, handLeft, helmet, bodyArmor, gauntlets, pants, boots);
    
    public IEquippable? HandRight { get; set; }
    public IEquippable? HandLeft { get; set; }
    
    public Protection? Helmet { get; set; }
    public Protection? BodyArmor { get; set; }
    public Protection? Gauntlets { get; set; }
    public Protection? Pants { get; set; }
    public Protection? Boots { get; set; }
}