using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Base
{
    public record GetQuery(string name) : IRequest<string>;

    internal class GetHandler : IRequestHandler<GetQuery, string>
    {
        private readonly SampleNetCoreAPIContext _mainDbContext;
        public GetHandler(SampleNetCoreAPIContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }

        public async Task<string> Handle(GetQuery request, CancellationToken cancellationToken)
        {
            return request.name;
        }
    }
}
