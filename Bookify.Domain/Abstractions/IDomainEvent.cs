using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace Bookify.Domain.Abstractions
{
    public interface IDomainEvent : INotification
    {
    }
}
