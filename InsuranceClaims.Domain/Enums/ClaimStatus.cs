namespace InsuranceClaims.Domain.Enums;

/// <summary>
/// Enum representing the status of an insurance claim throughout its lifecycle.
/// </summary>
public enum ClaimStatus
{
    Draft = 1,
    Submitted = 2,
    UnderReview = 3,
    AssessmentInProgress = 4,
    Approved = 5,
    Rejected = 6,
    SettlementInProgress = 7,
    Paid = 8,
    Closed = 9,
    Cancelled = 10
}