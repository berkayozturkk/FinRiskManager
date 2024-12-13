namespace FinRiskManager.Business.DTOs
{
    public class PartnerDto
    {
        public string Id { get; set; }          // Partner için benzersiz kimlik.
        public string Name { get; set; }        // Partner adı.
        public string ContactPerson { get; set; } // İrtibat kişisi.
        public string Email { get; set; }       // İrtibat e-posta adresi.
        public string Phone { get; set; }       // İrtibat telefon numarası.
        public string TenantId { get; set; }    // Çok kiracılı yapı için Tenant bilgisi.
    }
}
