namespace InsuranceClaims.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;
using InsuranceClaims.Application.Interfaces;
using InsuranceClaims.Application.Services;

public static class ServiceCollectionExtensions {
    public static IServiceCollection AddApplicationServices(this IServiceCollection services) {
        services.AddScoped<IPolicyHolderService, PolicyHolderService>();
        services.AddScoped<IInsurancePolicyService, InsurancePolicyService>();
        services.AddScoped<IClaimsService, ClaimsService>();
        services.AddScoped<IClaimSettlementService, ClaimSettlementService>();
        return services;
    }
}