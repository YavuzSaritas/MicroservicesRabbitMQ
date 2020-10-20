using System.ComponentModel.DataAnnotations;

namespace MicroRabbit.Tranfer.Domain.Models
{
    public class TransferLog
    {
        [Key]
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
