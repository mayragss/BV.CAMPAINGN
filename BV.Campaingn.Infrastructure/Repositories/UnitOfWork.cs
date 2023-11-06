using BV.Campaingn.Domain.Interfaces;
using BV.Campaingn.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV.Campaingn.Infrastructure.Repositories
{
    internal class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task Commit(CancellationToken cancellationToken)
        {
            // logging
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
