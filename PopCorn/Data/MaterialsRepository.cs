using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Popcorn.Data.Entities;
using Popcorn.Entities;
using Popcorn.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace PopCorn.Data
{
    public class MaterialsRepository : IMaterialsRepository
    {
        private readonly MaterialsContext _context;
        private readonly ILogger<MaterialsRepository> _logger;

        public MaterialsRepository(MaterialsContext context, ILogger<MaterialsRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddEntity(object model)
        {
            throw new NotImplementedException();
        }

        public void AddTRF_LinkTable(TRF_LinkTable newTRF_LinkTable)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TRF>> GetAllTRFs()
        {
            return await _context.TRFs
                .OrderBy(t => t.TRF_Page)
                .ThenBy(t => t.PropertyVal)
                .ThenBy(t => t.Hours)
                .ToListAsync();
        }

        public IEnumerable<TRF_LinkTable> GetAllTRF_LinkTables(bool includeItems)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRF_LinkTable> GetAllTRF_LinkTablesByUser(string username, bool includeItems)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRF> GetTRFsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public TRF_LinkTable GetTRF_LinkTableById(string username, int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveAll()
        {
            throw new NotImplementedException();
        }
    }
}
