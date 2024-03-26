using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonDataOld : MonoBehaviour
{
    // Initialize the variables
    [SerializeField] string PokemonName;
    [SerializeField] int PokemonBaseHP;
    int PokemonHP;
    [SerializeField] int PokemonBaseAttack;
    [SerializeField] int PokemonBaseDefense;
    // StatsPoints = HP + Attack + Defense (?)
    int StatsPoints;
    [SerializeField] float PokemonWeight;
    enum Types
    {
        Water,
        Fire,
        Grass,
        Electric,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }
    [SerializeField] Types PokemonType;
    [SerializeField] Types[] PokemonWeaknesses;
    [SerializeField] Types[] PokemonResistances;

    void DisplayName()
    {
        // Display the name of the Pokemon
        Debug.Log("Name : " + PokemonName);
    }
    void DisplayBaseHP()
    {
        // Display the base HP of the Pokemon
        Debug.Log("Base HP : " + PokemonBaseHP);
    }
    void DisplayBaseAttack()
    {
        // Display the base Attack of the Pokemon
        Debug.Log("Base Attack : " + PokemonBaseAttack);
    }
    void DisplayBaseDefense()
    {
        // Display the base Defense of the Pokemon
        Debug.Log("Base Defense : " + PokemonBaseDefense);
    }
    void DisplayWeight()
    {
        // Display the weight of the Pokemon
        Debug.Log("Weight : " + PokemonWeight);
    }
    void DisplayWeaknesses()
    {
        // Display the weaknesses of the Pokemon
        string weaknesses = "Weaknesses : ";
        // For each Weakness in the PokemonWeaknesses array, add it to the string
        foreach (Types weakness in PokemonWeaknesses)
        {
            weaknesses += weakness + " ";
        }
        Debug.Log(weaknesses);
    }
    void DisplayResistances()
    {
        // Display the resistances of the Pokemon
        string resistances = "Resistances : ";
        // For each Resistance in the PokemonResistances array, add it to the string
        foreach (Types resistance in PokemonResistances)
        {
            resistances += resistance + " ";
        }
        Debug.Log(resistances);
    }
    void InitCurrentHP()
    {
        // Initialize the current HP of the Pokemon (Called in Awake())
        PokemonHP = PokemonBaseHP;
    }
    void InitStatsPoints()
    {
        // Initialize the StatsPoints of the Pokemon (Called in Awake())
        StatsPoints = PokemonHP + PokemonBaseAttack + PokemonBaseDefense;
    }
    int GetAttackDamage()
    {
        // Return the Attack of the Pokemon
        return PokemonBaseAttack;
    }
    void TakeDamage(int damage, string type)
    {
        // Take damage from an attack
        // If the damage is less than or equal to 0, nothing happens
        if (damage <= 0)
        {
            Debug.Log("HP : " + PokemonHP);
            return;
        }
        // For each Weakness in the PokemonWeaknesses array, if the type of the attack is the same as the weakness, the damage is doubled
        foreach (Types weakness in PokemonWeaknesses)
        {
            if (type == weakness.ToString())
            {
                damage *= 2;
                Debug.Log("The attack is of type " + type.ToString() + ", one of the weaknesses of " + PokemonName);
                Debug.Log("The damage is doubled : " + damage + " instead of " + damage / 2);
            }
        }
        // For each Resistance in the PokemonResistances array, if the type of the attack is the same as the resistance, the damage is divided by 2
        foreach (Types resistance in PokemonResistances)
        {
            if (type == resistance.ToString())
            {
                damage /= 2;
                Debug.Log("The attack is of type " + type.ToString() + ", one of the resistances of " + PokemonName);
                Debug.Log("The damage is divided by 2 : " + damage + " instead of " + damage * 2);
            }
        }
        // The Pokemon takes the damage
        PokemonHP -= damage;
        Debug.Log("HP : " + PokemonHP);
    }
    void CheckIfPokemonAlive()
    {
        // Check if the Pokemon is alive
        // If the HP of the Pokemon is less than or equal to 0, the Pokemon is dead
        if (PokemonHP <= 0)
        {
            Debug.Log(PokemonName + " is dead");
        }
    }

    void Awake()
    {
        // Initialize the current HP and the StatsPoints of the Pokemon
        InitCurrentHP();
        InitStatsPoints();
    }
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the variables
        PokemonName = "Leviator";
        PokemonBaseHP = 95;
        PokemonHP = 95;
        PokemonBaseAttack = 125;
        PokemonBaseDefense = 79;
        PokemonType = Types.Water;
        PokemonWeight = 235.4f;
        PokemonWeaknesses = new Types[] { Types.Rock, Types.Electric };
        PokemonResistances = new Types[] { Types.Fighting, Types.Bug, Types.Fire, Types.Water, Types.Steel };
        
        // Display the variables
        DisplayName();
        DisplayBaseHP();
        DisplayBaseAttack();
        DisplayBaseDefense();
        DisplayWeight();
        DisplayWeaknesses();
        DisplayResistances(); 

        // Make the Pokemon take damage
        TakeDamage(10, "Electric"); 
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfPokemonAlive();
    }
}
