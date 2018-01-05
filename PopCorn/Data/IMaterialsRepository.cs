using Popcorn.Data.Entities;
using Popcorn.Entities;
using PopCorn.Data.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PopCorn.Data
{
    public interface IMaterialsRepository
    {
        Task<IEnumerable<TRF>> GetAllTRF();
        Task<IEnumerable<TRF_LinkTable>> GetAllTRF_LinkTable();
        Task<IEnumerable<TrfViewModel>> GetAllTrfViewModel();


        //TODO: Check if we need to impliment these MaterialsRepository methods

        //IEnumerable<TRF> GetTRFsByCategory(string category);
        //IEnumerable<TRF_LinkTable> GetAllTRF_LinkTables(bool includeItems);
        //IEnumerable<TRF_LinkTable> GetAllTRF_LinkTablesByUser(string username, bool includeItems);
        //TRF_LinkTable GetTRF_LinkTableById(string username, int id);
        //void AddTRF_LinkTable(TRF_LinkTable newTRF_LinkTable);
        //bool SaveAll();
        //void AddEntity(object model);
    }
}