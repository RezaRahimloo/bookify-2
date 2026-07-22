using Bookify.Domain.Apartments;
using Bookify.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookify.Infrastructure.Repositories
{
    internal sealed class ApartmentRepository : Repository<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
