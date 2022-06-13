using AutoMapper;
using Core.Application.Interfaces;
using Core.Application.Wrappers;
using Core.Domain.Entities;
using MediatR;

namespace Core.Application.Features.Concepts.Commands.CreateConceptCommand
{
    public class CreateConceptCommandHandler : IRequestHandler<CreateConceptCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Concept> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateConceptCommandHandler(IRepositoryAsync<Concept> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateConceptCommand request, CancellationToken cancellationToken)
        {
            var newRecord = _mapper.Map<Concept>(request);

            var data = await _repositoryAsync.AddAsync(newRecord);
            return new Response<int>(data.Id);
        }
    }
}
