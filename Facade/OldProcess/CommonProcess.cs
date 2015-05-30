using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;
using System.Data.Entity.Validation;

namespace Process
{
    public abstract class CommonProcess<T>
    {
        public static void Insert(T obj)
        {
            if (obj is SBCategory) { SBContextProvider.db.Categories.Add(obj as SBCategory); }
            if (obj is SBSprint) { SBContextProvider.db.Sprints.Add(obj as SBSprint); }
            if (obj is SBTask) { SBContextProvider.db.Tasks.Add(obj as SBTask); }
            if (obj is SBMeeting) { SBContextProvider.db.Meetings.Add(obj as SBMeeting); }
            if (obj is SBUser) { SBContextProvider.db.Users.Add(obj as SBUser); }

            SBContextProvider.db.SaveChanges();
        }

        public static void Delete(T obj)
        {
            if (obj is SBCategory) { SBContextProvider.db.Categories.Remove(obj as SBCategory); }
            if (obj is SBSprint) { SBContextProvider.db.Sprints.Remove(obj as SBSprint); }
            if (obj is SBTask) { SBContextProvider.db.Tasks.Remove(obj as SBTask); }
            if (obj is SBMeeting) { SBContextProvider.db.Meetings.Remove(obj as SBMeeting); }
            if (obj is SBUser) { SBContextProvider.db.Users.Remove(obj as SBUser); }

            SBContextProvider.db.SaveChanges();
        }

    }
}
