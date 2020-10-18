using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Dtos
{
    public class AccountTransfer
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
    }
}
