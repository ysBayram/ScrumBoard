using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;

namespace Process
{
    public class SprintProcess : CommonProcess<SBSprint>
    {
        public static bool Check(SBSprint Obj)
        {
            if (String.IsNullOrEmpty(Obj.Name)) { return false; }
            if (Obj.Deadline == null) { return false; }
            return true;
        }

        public static void Update(SBSprint Obj)
        {
            SBSprint nSprint = SBContextProvider.db.Sprints.Where(x => x.Id == Obj.Id).FirstOrDefault();
            nSprint.Name = Obj.Name;
            nSprint.Deadline = Obj.Deadline;
            nSprint.Category = Obj.Category;
            nSprint.Meetings = Obj.Meetings;
            nSprint.Tasks = Obj.Tasks;

            SBContextProvider.db.SaveChanges();
        }

        public static SBSprint GetById(int ElemId)
        {
            return SBContextProvider.db.Sprints.Where(x => x.Id == ElemId).FirstOrDefault();
        }

        public static List<SBSprint> GetAll()
        {
            return SBContextProvider.db.Sprints.ToList();
        }
    }
}
