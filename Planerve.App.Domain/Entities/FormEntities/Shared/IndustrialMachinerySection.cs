﻿using System.ComponentModel.DataAnnotations;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class IndustrialMachinerySection
    {
        [Required]
        public string Name { get; set; }
    }
}