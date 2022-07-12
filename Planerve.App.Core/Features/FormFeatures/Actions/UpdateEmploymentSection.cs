﻿using Planerve.App.Core.Features.FormFeatures.Commands.Update.Validators;
using Planerve.App.Core.Features.FormFeatures.Dtos.FormSections;
using Planerve.App.Core.Interfaces.Persistence.Generic;
using Planerve.App.Core.Interfaces.Services;
using Planerve.App.Domain.Entities.FormEntities.Shared;
using System;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Planerve.App.Core.Features.FormFeatures.Actions
{
    public class UpdateEmploymentSection
    {
        private readonly IFormSectionService<EmploymentSection, EmploymentSectionDto> _sectionService;
        private readonly IAsyncRepository<EmploymentSection> _repository;

        public UpdateEmploymentSection(
            IFormSectionService<EmploymentSection, EmploymentSectionDto> sectionService,
            IAsyncRepository<EmploymentSection> repository)
        {
            _sectionService = sectionService;
            _repository = repository;
        }

        public async Task Update(JsonObject data, Guid id)
        {
            var formSectionToUpdate = await _repository.GetByIdAsync(id);

            EmploymentSectionDto deserializedFormSection = await _sectionService.DeserializeAsync(data, new EmploymentSectionDto());
            await _sectionService.ValidateAsync(deserializedFormSection, new EmploymentSectionValidator());
            EmploymentSection mappedSection = await _sectionService.MapAsync(formSectionToUpdate, deserializedFormSection);

            mappedSection.Id = id;

            await _repository.UpdateAsync(mappedSection);
        }
    }
}