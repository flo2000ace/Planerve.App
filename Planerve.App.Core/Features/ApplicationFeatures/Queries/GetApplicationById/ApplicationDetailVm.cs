using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using System;

namespace Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById
{
    public class ApplicationDetailVm
    {
        public Guid Id { get; set; }
        public string ApplicationReference { get; set; }
        public string ApplicationName { get; set; }
        public string OwnerId { get; set; }
        public string VersionNumber { get; set; }
        public ApplicationDataDto Data { get; set; }
    }
}