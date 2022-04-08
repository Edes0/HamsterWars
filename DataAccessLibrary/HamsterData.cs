using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    internal class HamsterData : IHamsterData
    {
        private readonly ISqlDataAccess _db;
        public HamsterData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<HamsterModel>> GetHamsters()
        {
            string sql = "select * from dbo.Hamsters";

            return _db.LoadData<HamsterModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(HamsterModel hamster)
        {
            string sql = @"insert into dbo.Hamsters (Name, Age, ImageName, Wins, Defeats, Games, Likes)
                            values (@Name, @Age, @ImageName, @Wins, @Defeats, @Games, @Likes)";

            return _db.SaveData(sql, hamster);
        }
    }
}
