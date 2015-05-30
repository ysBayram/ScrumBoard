using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;

namespace Process
{
    public class UserProcess : CommonProcess<SBUser>
    {
        public static bool Check(SBUser Obj)
        {
            if (String.IsNullOrEmpty(Obj.Name)) { return false; }
            return true;
        }

        public static void Update(SBUser Obj)
        {
            SBUser nUser = SBContextProvider.db.Users.Where(x => x.Id == Obj.Id).FirstOrDefault();
            nUser.Name = Obj.Name;
            nUser.Role = Obj.Role;
            nUser.Tasks = Obj.Tasks;

            SBContextProvider.db.SaveChanges();
        }

        public static SBUser GetById(int ElemId)
        {
            return SBContextProvider.db.Users.Where(x => x.Id == ElemId).FirstOrDefault();
        }

        public static List<SBUser> GetAll()
        {
            return SBContextProvider.db.Users.ToList();
        }
    }
}
