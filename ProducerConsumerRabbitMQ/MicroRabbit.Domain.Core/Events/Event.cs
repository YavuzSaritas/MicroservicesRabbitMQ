using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Domain.Core.Events
{
    public abstract class Event
    {
        public DateTime Timestamps { get; protected set; }
        protected Event()
        {
            Timestamps = DateTime.Now;
        }

    }
}
