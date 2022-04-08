using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    internal interface IHamsterData
    {
        Task<List<HamsterModel>> GetHamsters();
        Task InsertPerson(HamsterModel hamster);
    }
}