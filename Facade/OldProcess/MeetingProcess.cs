using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;

namespace Process
{
    public class MeetingProcess : CommonProcess<SBMeeting>
    {
        public static bool Check(SBMeeting obj)
        {
            if (String.IsNullOrEmpty(obj.Name)) { return false; }
            if (String.IsNullOrEmpty(obj.Descrp)) { return false; }
            if (obj.Time == null) { return false; }
            return true;
        }

        public static void Update(SBMeeting Obj)
        {
            SBMeeting nMeet = SBContextProvider.db.Meetings.Where(x => x.Id == Obj.Id).FirstOrDefault();
            nMeet.Name = Obj.Name;
            nMeet.Descrp = Obj.Descrp;
            nMeet.Time = Obj.Time;
            nMeet.Sprint = Obj.Sprint;

            SBContextProvider.db.SaveChanges();
        }

        public static SBMeeting GetById(int ElemId)
        {
            return SBContextProvider.db.Meetings.Where(x => x.Id == ElemId).FirstOrDefault();
        }

        public static List<SBMeeting> GetAll()
        {
            return SBContextProvider.db.Meetings.ToList();
        }
    }
}
