using System.ComponentModel.DataAnnotations;

namespace UltiMiniApi.Model
{
    public class Safe
    {
        [Key]
        public int SafeId { get; set; }
        public int TenantId { get; set; }
        public string Name { get; set; }
        public int Currency { get; set; }
        public string CreatedDate { get; set; }
        public decimal Balance { get; set; }
        public int  isDefault { get; set; }
    }
}
