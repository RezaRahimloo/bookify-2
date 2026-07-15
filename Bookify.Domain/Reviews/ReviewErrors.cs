using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Domain.Reviews
{
    public static class ReviewErrors
    {
        public static readonly Error NotEligible = new(
            "Review.NotEligible",
            "The review is not eligible because the booking is not yet completed");
    }
}
