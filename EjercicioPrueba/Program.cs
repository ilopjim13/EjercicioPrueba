using EjercicioPrueba.interfaces;
using EjercicioPrueba.character;
using EjercicioPrueba.protections;
using EjercicioPrueba.weapons;


namespace EjercicioPrueba
{
    internal abstract class Program
    {
        private static void Main()
        {
            Weapon sword = new Sword("Steel Fang", 25, 0.06, 5);
            Protection helmet = new Helmet("Helmet", 10, 0.06, true);
            var character = new Character("Ronan", 150, 10, 20, [sword, helmet]);
            var loot = LootGenerator();
            
            var enemy = new Character("Goblin", 30, 50, 10, []);
            
            sword.Equip(character);
            helmet.Equip(character);

            var combat = true;
            Console.WriteLine("You've run into a goblin, the fight begins!");
            while (combat)
            {
                var attack = character.Attack();
                if (character.Pet != null)
                {
                    var petAttack = character.Pet.Attack();
                    attack += petAttack;
                    Console.WriteLine($"Your pet {character.Pet.Name} has attacked");
                }
                var defenseEnemy = enemy.Defense();
                if (enemy.ReceiveDamage(DamageCalculator(attack, defenseEnemy)))
                {
                    Console.WriteLine("You have missed the attack!!");
                }

                var attackEnemy = enemy.Attack();
                var defense = character.Defense();
                if (character.ReceiveDamage(DamageCalculator(attackEnemy, defense)))
                {
                    Console.WriteLine("You have dodged the attack!!");
                }

                if (character.Perks.CurrentHp == 0)
                {
                    Console.WriteLine("You lose!!");
                    combat = false;
                } else if (enemy.Perks.CurrentHp == 0)
                {
                    Console.WriteLine("You Win!!");
                    combat = false;
                    var index = new Random().Next(loot.Count);
                    var randomLoot = loot[index];
                    Console.WriteLine("The enemy has dropped an item");
                    randomLoot.AddItem(character);
                    randomLoot.Equip(character);
                    character.Heal(100);
                }

            }
            
        }
        
        
        private static int DamageCalculator(int attacker, int defender) 
        {
            if (attacker >= defender)
            {
                return attacker - defender;
            }

            return 0;
        }


        private static List<IEquippable> LootGenerator()
        {
            var loot = new List<IEquippable>
            {
                new Shield("Shield of Valor", 100,  0.05),
                new Helmet("Helmet of Insight", 50,  0.1, false),
                new BodyArmor("Chestplate of Fortitude", 150, 0.02),
                new Gauntlets("Gauntlets of Dexterity",40, 0.12),
                new Boots("Boots of Swiftness", 30, 0.15),
                new Sword("Sword of Dawn", 50,  0.2, 100),
                new Axe("Axe of Fury", 60, 0.15, 120 ),
                new Sword("Claymore", 40, 0.25, 90),
                new Dagger("Dagger of Silence", 30, 0.3, 80),
                new Hammer("Hammer of Thunder", 70, 0.1, 150)
            };

            return loot;
        }
    
    }
}




