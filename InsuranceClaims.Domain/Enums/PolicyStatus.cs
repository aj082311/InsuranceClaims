namespace InsuranceClaims.Domain.Enums;

/// <summary>
/// Enum representing the status of an insurance policy.
/// </summary>
public enum PolicyStatus
{
    Active = 1,
    Inactive = 2,
    Expired = 3,
    Cancelled = 4,
    Pending = 5
}