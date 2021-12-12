using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pokeprout.Domain;

namespace Pokeprout.Application;

public interface IPokemonRepository
{
    Task Add(Pokemon pokemon);

    Task<Pokemon> Get(int id);

    Task<Pokemon> Get(string name);

    Task<ICollection<Pokemon>> GetAll();

    Task Delete(int id);

    Task Delete(string name);

    Task<ICollection<Pokemon>> Find(FindPokemon finder);
}

public class FindPokemon
{
    public ICollection<int> Ids { get; set; }
    public ICollection<string> Names { get; set; }
    public ICollection<PokemonType> Types { get; set; }

    public FindPokemon(ICollection<int> ids)
        : this(ids, Array.Empty<string>(), Array.Empty<PokemonType>())
    {
    }

    public FindPokemon(ICollection<string> names)
        : this(Array.Empty<int>(), names, Array.Empty<PokemonType>())
    {
    }

    public FindPokemon(ICollection<PokemonType> types)
        : this(Array.Empty<int>(), Array.Empty<string>(), types)
    {
    }

    // TODO do the last 3

    public FindPokemon(ICollection<int> ids, ICollection<string> names, ICollection<PokemonType> types)
    {
        Ids = ids;
        Names = names;
        Types = types;
    }
}
