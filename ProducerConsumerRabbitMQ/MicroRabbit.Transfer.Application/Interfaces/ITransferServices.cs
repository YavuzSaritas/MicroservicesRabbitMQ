using MicroRabbit.Tranfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Interfaces
{
    public interface ITransferServices
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
