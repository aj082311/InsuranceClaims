namespace InsuranceClaims.Application.Services;

using InsuranceClaims.Application.DTOs;
using InsuranceClaims.Application.Interfaces;
using InsuranceClaims.Application.StaticData;

public class PolicyHolderService : IPolicyHolderService {
    public List<PolicyHolderDto> GetAll() {
        return ClaimsDataStore.PolicyHolders;
    }

    public PolicyHolderDto? GetById(int id) {
        return ClaimsDataStore.PolicyHolders.FirstOrDefault(x => x.Id == id);
    }

    public List<InsurancePolicyDto> GetPolicies(int id) {
        return ClaimsDataStore.InsurancePolicies.Where(x => x.PolicyHolderId == id).ToList();
    }

    public List<ClaimDto> GetClaims(int id) {
        return ClaimsDataStore.Claims.Where(x => x.PolicyHolderId == id).ToList();
    }

    public PolicyHolderDto CreateOrUpdate(PolicyHolderDto dto) {
        var existing = ClaimsDataStore.PolicyHolders.FirstOrDefault(x => x.Id == dto.Id);
        if (existing != null) {
            existing.FirstName = dto.FirstName;
            existing.LastName = dto.LastName;
            existing.Email = dto.Email;
            existing.PhoneNumber = dto.PhoneNumber;
            return existing;
        }
        dto.Id = ClaimsDataStore.PolicyHolders.Max(x => x.Id) + 1;
        ClaimsDataStore.PolicyHolders.Add(dto);
        return dto;
    }
}