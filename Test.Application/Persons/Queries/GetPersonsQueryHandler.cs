using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Common.Interfaces;
using Test.Shared.Dtos;
using Test.Shared.Queries;

namespace Test.Application.Persons.Queries
{
    internal class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, IEnumerable<PersonDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetPersonsQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PersonDto>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var persons = await _context
                .Persons
                .AsNoTracking()
                .Select(x => new PersonDto
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PhoneNumber = x.PhoneNumber
                })
                .ToListAsync();

            return persons;
        }
    }
}
