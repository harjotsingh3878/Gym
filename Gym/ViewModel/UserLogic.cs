using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gym.Model;
using SQLite;

namespace Gym.ViewModel
{
    public class UserLogic
    {
        DB db;
        private ObservableCollection<User> ocUsers;
        User u= new User();

        public ObservableCollection<User> UserCollection
        {
            get { return ocUsers; }
        }

        public async Task Init()
        {
            db = new DB(DB.GetDBPath());
            await db.Init();

            AsyncTableQuery<User> atqu = db.Table<User>();
            List<User> lUsers = await atqu.ToListAsync();
            ocUsers = new ObservableCollection<User>(lUsers);
        }

        public async Task CreateUser(User user)
        {
            u = user;
            ocUsers.Add(u);
            await db.InsertAsync(u);
        }
    }
}
