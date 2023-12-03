using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Shared.Dtos;

namespace Test.Shared.Queries
{
    public class GetPersonsQuery : IRequest<IEnumerable<PersonDto>>
    {
    }
}
