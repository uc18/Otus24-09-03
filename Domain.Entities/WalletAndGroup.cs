using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyWallet.Domain
{
    [Table("WalletAndGroups")]
    public class WalletAndGroup
    {
        [Column]
        public int WalletId { get; set; }

        [Column]
        public int GroupId { get; set; }

        [Column]
        public int PrivilagesId { get; set; }
    }
}
