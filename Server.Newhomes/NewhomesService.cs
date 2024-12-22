using Microsoft.EntityFrameworkCore;
using Server.Newhomes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Newhomes
{
    public class NewhomesService : IDisposable
    {
        private bool disposed;
        private NewhomesContext db = new NewhomesContext();

        public NewhomesService()
        {
            db.Database.EnsureCreated();
        }

        public async Task<List<NumericalModel>> GetAllEntriesAsync()
        {
            return await db.Numbers.AsNoTracking()
                                   .OrderByDescending(x => x.Id)
                                   .ToListAsync();
        }

        public async Task AddEntryAsync(NumericalModel model)
        {
            await db.AddAsync(model);
            await db.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
