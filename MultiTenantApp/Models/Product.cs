﻿namespace MultiTenantApp.Models
{
    public class Product : IMustHaveTenants
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? TenantId { get; set; }
    }
}
