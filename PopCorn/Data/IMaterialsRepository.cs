using Popcorn.Data.Entities;
using Popcorn.Entities;
using System.Collections.Generic;

namespace PopCorn.Data
{
    public interface IMaterialsRepository
    {
        IEnumerable<TRF> GetAllTRFs();
        IEnumerable<TRF> GetTRFsByCategory(string category);

        IEnumerable<TRF_LinkTable> GetAllTRF_LinkTables(bool includeItems);
        IEnumerable<TRF_LinkTable> GetAllTRF_LinkTablesByUser(string username, bool includeItems);
        TRF_LinkTable GetTRF_LinkTableById(string username, int id);
        void AddTRF_LinkTable(TRF_LinkTable newTRF_LinkTable);

        bool SaveAll();
        void AddEntity(object model);
    }
}