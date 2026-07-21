using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Application.Abstractions.Behaviors
{
    public sealed record ValidationError(string PropertyName, string ErrorMessage);
}
