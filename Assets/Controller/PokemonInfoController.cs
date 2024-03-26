using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PokemonInfoController : MonoBehaviour
{
    public int id;

    [SerializeField] private Image pokemonImage;
    [SerializeField] private TMP_Text pokemonName;
    [SerializeField] private TMP_Text pokemonSize;
    [SerializeField] private TMP_Text pokemonWeight;
    [SerializeField] private TMP_Text pokemonType;
    [SerializeField] private TMP_Text Caption;

    private DatabaseManager databaseManager;

    private void Awake()
    {
        databaseManager = FindObjectOfType<DatabaseManager>();
        
    }

    private void Start()
    {
        PokemonData pokemon = databaseManager.db.pokemonData[id];
        pokemonImage.sprite = pokemon.image;
        pokemonName.text = pokemon.name;
        pokemonSize.text = "Taille: " + pokemon.size + "m";
        pokemonWeight.text = "Poids: " + pokemon.weight + "kg";
        pokemonType.text = "Type: " + string.Join(", ", pokemon.type);
        Caption.text = pokemon.caption;
    }
}
