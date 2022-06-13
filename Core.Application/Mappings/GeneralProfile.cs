using Core.Application.Features.Concepts.Commands.CreateConceptCommand;
using AutoMapper;
using Core.Application.DTOs;
using Core.Domain.Entities;
using System.Collections.Generic;

namespace Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region DTOs
            CreateMap<Concept, ConceptDTO>();
            #endregion

            #region Commands
            CreateMap<CreateConceptCommand, Concept>();
            #endregion
        }
    }
}
