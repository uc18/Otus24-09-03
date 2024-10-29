using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyWallet.Domain
{
    [Table("Users")]
    public class WalletAndGroup
    {
        [Column]
        public string WalletId { get; set; }

        [Column]
        public string GroupId { get; set; }

        [Column]
        public string PrivilagesId { get; set; }
    }
}
