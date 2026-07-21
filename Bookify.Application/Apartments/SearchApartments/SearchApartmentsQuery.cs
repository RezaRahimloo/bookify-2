using Bookify.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Application.Apartments.SearchApartments
{
    public record SearchApartmentsQuery(
        DateOnly StartDate,
        DateOnly EndDate) : IQuery<IReadOnlyList<ApartmentResponse>>;
}
