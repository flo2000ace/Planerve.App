﻿using AutoMapper;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create;
using Planerve.App.Core.Features.ApplicationFeatures.Commands.Create.DataHelpers;
using Planerve.App.Core.Features.ApplicationFeatures.Dtos;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationById;
using Planerve.App.Core.Features.ApplicationFeatures.Queries.GetApplicationList;
using Planerve.App.Core.Features.FormFeatures.Dtos.FormSections;
using Planerve.App.Domain.Entities.ApplicationEntities;
using Planerve.App.Domain.Entities.FormEntities;
using Planerve.App.Domain.Entities.FormEntities.Shared;

namespace Planerve.App.Core.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Type Helper Maps
        CreateMap<ApplicationType, ApplicationTypeHelper.ApplicationType>().ReverseMap();
        CreateMap<ApplicationDocument, ApplicationDocumentHelper.ApplicationDocument>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, ApplicationDocumentHelper.DocumentRequirement>().ReverseMap();

        // Application Data Maps
        CreateMap<Application, CreateApplicationCommand>().ReverseMap();
        CreateMap<Application, ApplicationDetailVm>().ReverseMap();
        CreateMap<Application, ApplicationListVm>().ReverseMap();
        CreateMap<ApplicationType, ApplicationTypeDto>().ReverseMap();
        CreateMap<ApplicationDocument, ApplicationDocumentDto>().ReverseMap();
        CreateMap<ApplicationDocument.DocumentRequirement, DocumentRequirementDto>().ReverseMap();
        CreateMap<ApplicationProgress, ApplicationProgressDto>().ReverseMap();

        // Form Section Maps
        CreateMap<AccessSection, AccessSectionDto>().ReverseMap();
        CreateMap<AdviceSection, AdviceSectionDto>().ReverseMap();
        CreateMap<AgentSection, AgentSectionDto>().ReverseMap();
        CreateMap<ApplicantSection, ApplicantSectionDto>().ReverseMap();
        CreateMap<AuthorityMemberSection, AuthorityMemberSectionDto>().ReverseMap();
        CreateMap<BiodiversitySection, BiodiversitySectionDto>().ReverseMap();
        CreateMap<ConditionProposalSection, ConditionProposalSectionDto>().ReverseMap();
        CreateMap<DischargeConditionSection, DischargeConditionSectionDto>().ReverseMap();
        CreateMap<EligibilitySection, EligibilitySectionDto>().ReverseMap();
        CreateMap<EmploymentSection, EmploymentSectionDto>().ReverseMap();
        CreateMap<ExistingUseSection, ExistingUseSectionDto>().ReverseMap();
        CreateMap<FloodRiskSection, FloodRiskSectionDto>().ReverseMap();
        CreateMap<FloorSpaceSection, FloorSpaceSectionDto>().ReverseMap();
        CreateMap<FoulSewageSection, FoulSewageSectionDto>().ReverseMap();
        CreateMap<HazardousSubstanceSection, HazardousSubstanceSectionDto>().ReverseMap();
        CreateMap<IndustrialMachinerySection, IndustrialMachinerySectionDto>().ReverseMap();
        CreateMap<MaterialSection, MaterialSectionDto>().ReverseMap();
        CreateMap<NonMaterialProposalSection, NonMaterialProposalSectionDto>().ReverseMap();
        CreateMap<NonMaterialSoughtSection, NonMaterialSoughtSectionDto>().ReverseMap();
        CreateMap<OpeningHoursSection, OpeningHoursSectionDto>().ReverseMap();
        CreateMap<OwnershipCertificationSection, OwnershipCertificationSectionDto>().ReverseMap();
        CreateMap<ParkingSection, ParkingSectionDto>().ReverseMap();
        CreateMap<ProposalSection, ProposalSectionDto>().ReverseMap();
        CreateMap<ResidentialUnitsSection, ResidentialUnitsSectionDto>().ReverseMap();
        CreateMap<SiteSection, SiteSectionDto>().ReverseMap();
    }
}