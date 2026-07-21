using Bookify.Application.Abstractions.Behaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Application.Exceptions
{
    public sealed class ValidationException : Exception
    {
        public ValidationException(IEnumerable<ValidationError> errors)
        {
            Errors = errors;
        }
        public IEnumerable<ValidationError> Errors { get; }
    }
}
