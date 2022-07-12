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
    public class UpdateBiodiversitySection
    {
        private readonly IFormSectionService<BiodiversitySection, BiodiversitySectionDto> _sectionService;
        private readonly IAsyncRepository<BiodiversitySection> _repository;

        public UpdateBiodiversitySection(
            IFormSectionService<BiodiversitySection, BiodiversitySectionDto> sectionService,
            IAsyncRepository<BiodiversitySection> repository)
        {
            _sectionService = sectionService;
            _repository = repository;
        }

        public async Task Update(JsonObject data, Guid id)
        {
            var formSectionToUpdate = await _repository.GetByIdAsync(id);

            BiodiversitySectionDto deserializedFormSection = await _sectionService.DeserializeAsync(data, new BiodiversitySectionDto());
            await _sectionService.ValidateAsync(deserializedFormSection, new BiodiversitySectionValidator());
            BiodiversitySection mappedSection = await _sectionService.MapAsync(formSectionToUpdate, deserializedFormSection);

            mappedSection.Id = id;

            await _repository.UpdateAsync(mappedSection);
        }
    }
}
