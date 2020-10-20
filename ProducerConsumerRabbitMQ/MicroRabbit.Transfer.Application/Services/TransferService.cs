using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Tranfer.Domain.Interfaces;
using MicroRabbit.Tranfer.Domain.Models;
using MicroRabbit.Transfer.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Application.Services
{
    public class TransferService : ITransferServices
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;
        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLog();
        }
    }
}
