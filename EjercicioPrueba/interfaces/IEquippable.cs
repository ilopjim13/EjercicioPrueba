using EjercicioPrueba.character;

namespace EjercicioPrueba.interfaces;

public interface IEquippable :ITem
{
    void UnApply(Character character);
    
    void AddItem(Character character);
    
    void Equip(Character character);
    
    void UnEquip(Character character);   
}