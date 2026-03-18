namespace InsuranceClaims.Domain.Entities;

using InsuranceClaims.Domain.Enums;

/// <summary>
/// Entity representing a policy holder.
/// </summary>
public class PolicyHolder
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string DateOfBirth { get; set; } = string.Empty;
    public string Address1 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string StateCode { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public PolicyStatus Status { get; set; }

    public string FullName => $"{FirstName} {LastName}".Trim();
}