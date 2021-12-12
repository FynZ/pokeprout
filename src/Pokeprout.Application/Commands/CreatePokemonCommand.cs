using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Pokeprout.Application.Commands;

public class CreatePokemonCommand : IRequest
{

}

public class CreatePokemonCommandHandler : IRequestHandler<CreatePokemonCommand>
{
    public Task<Unit> Handle(CreatePokemonCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
