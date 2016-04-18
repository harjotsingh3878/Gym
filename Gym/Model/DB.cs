using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using SQLite;

namespace Gym.Model
{
    class DB : SQLiteAsyncConnection
    {
        static public string GetDBPath()
        {
            return Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "DataCollection.db");
        }

        public DB(string databasePath)
            : base(databasePath, true)
        {
        }

        public async Task Init()
        {
            await CreateTableAsync<User>();
        }
    }
}
