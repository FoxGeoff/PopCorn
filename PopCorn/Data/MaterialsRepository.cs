using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Popcorn.Data.Entities;
using Popcorn.Entities;
using Popcorn.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PopCorn.Data.ViewModel;

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

        /* Database Table Methods */
        public void AddEntity(object model)
        {
            throw new NotImplementedException();
        }

        public void AddTRF_LinkTable(TRF_LinkTable newTrf_LinkTable)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TRF>> GetAllTRF()
        {
            return await _context.TRFs
                .OrderBy(t => t.TRF_Page)
                .ThenBy(t => t.PropertyVal)
                .ThenBy(t => t.Hours)
                .ThenBy(t => t.Temperature)
                .ToListAsync();
        }

        public async Task<IEnumerable<TRF_LinkTable>> GetAllTRF_LinkTable()
        {
            return await _context.TRF_LinkTable
               .OrderBy(t => t.TRF_Page)
               .ThenBy(t => t.TRF_ID)
               .ThenBy(t => t.Hours)
               .ThenBy(t => t.Property)
               .ToListAsync();
        }

        /* ViewModels Mehods */
        public async Task<IEnumerable<TrfViewModel>> GetAllTrfViewModel()
        {
            var trfBaseVals = await GetAllTRF();
            var trfLinkVals = await GetAllTRF_LinkTable();

            var trfRefercenceVals = from tb in trfBaseVals
                                   join tl in trfLinkVals on tb.TRF_ID equals tl.TRF_ID
                                   select new TrfViewModel
                                   {
                                       TRF_Page = tl.TRF_Page,
                                       TRF_ID = tl.TRF_ID,
                                       Hours = tl.Hours,
                                       Temperature = tb.Temperature,
                                       PropertyVal = tb.PropertyVal,
                                       Property = tl.Property,
                                       Reference = tl.Reference
                                   };

            return trfRefercenceVals;
        }

        public IEnumerable<TrfChart> GetAllTrfChart()
        {
            return null;
        }
    }

    public class TrfChart
    {
        public string Title { get; set; }
        public IEnumerable<TrfViewModel> TrfPoints { get; set; }
    }
}
