﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Planerve.App.Domain.Entities.FormEntities.Shared
{
    public class AgentSection
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
