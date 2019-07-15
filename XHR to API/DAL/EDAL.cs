using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EDAL : IDAL
    {
        private readonly DbClient _ctx = new DbClient();

        void IDAL.AddUser(User u)
        {
            _ctx.Users.Add(u);
        }

        int IDAL.GetUsersCount()
        {
            return _ctx.Users.Count();
        }
    }
}