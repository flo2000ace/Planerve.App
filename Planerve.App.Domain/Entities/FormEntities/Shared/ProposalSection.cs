﻿using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class ProposalSection
    {
        [Required]
        public string Name { get; set; } = "Proposal";
    }
}
