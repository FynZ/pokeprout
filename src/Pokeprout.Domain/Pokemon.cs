using System;
using System.Collections.Generic;

namespace Pokeprout.Domain;

public class Pokemon
{
    public int Id { get; set; }

    public string Name { get; set; }

    public PokemonType Types { get; set; }

    public Pokemon(int id, string name, PokemonType types)
    {
        Id = id;
        Name = name;
        Types = types;
    }

    public Pokemon(int id, string name, Type type)
    {
        Id = id;
        Name = name;
        Types = new PokemonType(type);
    }

    public Pokemon(int id, string name, Type firstType, Type secondType)
    {
        Id = id;
        Name = name;
        Types = new PokemonType(firstType, secondType);
    }
}

public struct PokemonType
{
    public ICollection<Type> Types { get; set; }

    public PokemonType(Type type)
    {
        Types = new [] { type };
    }

    public PokemonType(Type firstType, Type secondTIme)
    {
        if (firstType == secondTIme)
        {
            throw new ArgumentException($"Pokemon cannot be of the same two types {nameof(firstType)}");
        }

        Types = new[] { firstType, secondTIme };
    }
}

public enum Type
{
    Normal,
    Fire,
    Fighting,
    Water,
    Flying,
    Grass,
    Poison,
    Electric,
    Ground,
    Psychic,
    Rock,
    Ice,
    Bug,
    Dragon,
    Ghost,
    Dark,
    Steel,
    Fairy
}
