namespace MultiTenantApp.Models
{
    public interface IMustHaveTenants
    {
        public string? TenantId { get; set; }
    }
}
