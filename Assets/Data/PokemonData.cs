using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class PokemonData
{
    public enum Type
    {
        Normal,
        Feu,
        Eau,
        Electrik,
        Plante,
        Glace,
        Combat,
        Poison,
        Sol,
        Vol,
        Psy,
        Insecte,
        Roche,
        Spectre,
        Dragon,
        Acier,
        Tenebres,
        Fee
    }
    public Sprite image;
    public string name;
    public float size;
    public float weight;
    public List<Type> type;
    public string caption;
}
