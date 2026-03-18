namespace InsuranceClaims.Domain.Enums;

/// <summary>
/// Enum representing the status of a claim settlement.
/// </summary>
public enum SettlementStatus
{
    Pending = 1,
    Processing = 2,
    Paid = 3,
    Failed = 4,
    Cancelled = 5
}