using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Tranfer.Domain.Event;
using MicroRabbit.Tranfer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Tranfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;
        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.AddTransferLog(new Models.TransferLog
            {
                ToAccount= @event.To,
                FromAccount = @event.From,
                TransferAmount = @event.Amount
            });
            return Task.CompletedTask;
        }
    }
}
