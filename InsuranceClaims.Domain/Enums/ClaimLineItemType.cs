namespace InsuranceClaims.Domain.Enums;

/// <summary>
/// Enum representing the type of claim line item.
/// </summary>
public enum ClaimLineItemType
{
    PropertyDamage = 1,
    MedicalExpense = 2,
    VehicleDamage = 3,
    LossOfIncome = 4,
    Liability = 5,
    LegalExpense = 6,
    Other = 7
}