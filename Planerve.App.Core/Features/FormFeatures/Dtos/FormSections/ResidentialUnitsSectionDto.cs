﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planerve.App.Core.Features.FormFeatures.Dtos.FormSections
{
    public class ResidentialUnitsSectionDto
    {
        public bool DoesIncludeGainOrLoss { get; set; }
        public ProposedUnitsDto ProposedUnits { get; set; }
        public ExistingUnitsDto ExistingUnits { get; set; }
        public int ProposedTotal { get; set; }
        public int ExistingTotal { get; set; }
        public int TotalNetGainOrLoss { get; set; }
    }

    public class ProposedUnitsDto : UnitTypeDto
    {
        public int OneBedroomProposedTotalMarket { get; set; }
        public int TwoBedroomProposedTotalMarket { get; set; }
        public int ThreeBedroomProposedTotalMarket { get; set; }
        public int FourBedroomProposedTotalMarket { get; set; }
        public int UnknownBedroomProposedTotalMarket { get; set; }
        public int ProposedBedroomTotalMarket { get; set; }
        public ICollection<TypeDto> Types { get; set; }
    }

    public class ExistingUnitsDto : UnitTypeDto
    {
        public int OneBedroomProposedTotalMarket { get; set; }
        public int TwoBedroomProposedTotalMarket { get; set; }
        public int ThreeBedroomProposedTotalMarket { get; set; }
        public int FourBedroomProposedTotalMarket { get; set; }
        public int UnknownBedroomProposedTotalMarket { get; set; }
        public int ProposedBedroomTotalMarket { get; set; }
        public ICollection<TypeDto> Types { get; set; }
    }

    public class UnitTypeDto
    {
        public bool Market { get; set; }
        public bool SocialAffordableIntermediateRent { get; set; }
        public bool AffordableHomeOwnership { get; set; }
        public bool StarterHomes { get; set; }
        public bool SelfBuildCustomBuild { get; set; }
    }

    public class TypeDto
    {
        public string HousingType { get; set; }
        public int Total { get; set; }
        public int OneBedroom { get; set; }
        public int TwoBedroom { get; set; }
        public int ThreeBedroom { get; set; }
        public int FourPlusBedroom { get; set; }
        public int Unknown { get; set; }
    }
}
