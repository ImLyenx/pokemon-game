using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPokemonDatabase", menuName = "Database/Pokemon", order = 0)]

public class PokemonDatabase : ScriptableObject
{
    public List<PokemonData> pokemonData = new();
}
