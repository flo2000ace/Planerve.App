﻿using AutoMapper;
using MediatR;
using Planerve.App.Core.Contracts.Identity;
using Planerve.App.Core.Contracts.Persistence;
using Planerve.App.Core.Contracts.Specification.ApplicationData;
using Planerve.App.Domain.Entities.ApplicationEntities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.ApplicationData.Queries.GetApplicationList
{
    public class GetApplicationListQueryHandler : IRequestHandler<GetApplicationListQuery, List<ApplicationListVm>>
    {
        private readonly IAsyncRepository<Application> _repository;
        private readonly IMapper _mapper;
        private readonly ILoggedInUserService _loggedInUserService;

        public GetApplicationListQueryHandler(IMapper mapper, IAsyncRepository<Application> repository, ILoggedInUserService loggedInUserService)
        {
            _mapper = mapper;
            _repository = repository;
            _loggedInUserService = loggedInUserService;
        }

        // Get all users applications, method will specifiy the query, null check and finally map and return the list.
        public async Task<List<ApplicationListVm>> Handle(GetApplicationListQuery request,
            CancellationToken cancellationToken)
        {
            // Grab userId from API user service.
            var userId = await _loggedInUserService.UserId();

            // Get any applications that have the same ownerId as current logged in user.
            var specification = new GetApplicationListSpecification(userId);

            var applicationList = _repository.FindWithSpecificationPattern(specification);

            if (!applicationList.Any())
            {
                return null;
            }

            var applicationListDto = _mapper.Map<List<ApplicationListVm>>(applicationList);

            return applicationListDto;
        }
    }
}
