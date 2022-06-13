using Core.Application.Wrappers;
using MediatR;

namespace Core.Application.Features.Concepts.Commands.CreateConceptCommand
{
    public class CreateConceptCommand : IRequest<Response<int>>
    {
        public string Name { get; set; }
        public int Category { get; set; }
    }
}
