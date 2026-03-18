namespace InsuranceClaims.Domain.Entities;

using InsuranceClaims.Domain.Enums;

/// <summary>
/// Entity representing an insurance claim.
/// </summary>
public class Claim
{
    public int Id { get; set; }
    public string ClaimNumber { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime IncidentDate { get; set; }
    public DateTime SubmittedDate { get; set; }
    public ClaimStatus Status { get; set; }
    public decimal TotalClaimedAmount { get; set; }
    public decimal ApprovedAmount { get; set; }
    public string Notes { get; set; } = string.Empty;
    public int PolicyHolderId { get; set; }
    public int InsurancePolicyId { get; set; }
}