namespace InsuranceClaims.Application.DTOs
{
    public class PolicyHolderDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public string Status { get; set; }
        public string FullName => FirstName + " " + LastName;
    }
}