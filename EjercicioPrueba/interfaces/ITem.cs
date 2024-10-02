using EjercicioPrueba.character;

namespace EjercicioPrueba.interfaces;

public interface ITem
{ 
    void Apply(Character character);
    
    void UnApply(Character character);
    
    void AddItem(Character character);
    
    void Equip(Character character);
    
    void UnEquip(Character character);
}