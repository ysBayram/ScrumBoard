using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;

namespace Process
{
    public class TaskProcess : CommonProcess<SBTask>
    {
        public static bool Check(SBTask Obj)
        {
            if (String.IsNullOrEmpty(Obj.Name)) { return false; }
            if (String.IsNullOrEmpty(Obj.Descrp)) { return false; }
            if (Obj.CreateTime == null) { return false; }
            return true;
        }

        public static void Update(SBTask Obj)
        {
            SBTask nTask = SBContextProvider.db.Tasks.Where(x => x.Id == Obj.Id).FirstOrDefault();
            nTask.Name = Obj.Name;
            nTask.Descrp = Obj.Descrp;
            nTask.CreateTime = Obj.CreateTime;
            nTask.Sprint = Obj.Sprint;
            nTask.User = Obj.User;

            SBContextProvider.db.SaveChanges();
        }

        public static SBTask GetById(int ElemId)
        {
            return SBContextProvider.db.Tasks.Where(x => x.Id == ElemId).FirstOrDefault();
        }

        public static List<SBTask> GetAll()
        {
            return SBContextProvider.db.Tasks.ToList();
        }
    }
}
