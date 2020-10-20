using MicroRabbit.Tranfer.Domain.Interfaces;
using MicroRabbit.Tranfer.Domain.Models;
using MicroRabbit.Transfer.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _transferDbContext;
        public TransferRepository(TransferDbContext transferDbContext)
        {
            _transferDbContext = transferDbContext;
        }

        public void AddTransferLog(TransferLog newLog)
        {
            _transferDbContext.TransferLogs.Add(newLog);
            _transferDbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLog()
        {
            return _transferDbContext.TransferLogs;
        }
    }
}
