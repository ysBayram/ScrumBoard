using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Provider;

namespace Process
{
    public class CategoryProcess : CommonProcess<SBCategory>
    {
        public static bool Check(SBCategory obj)
        {
            if (String.IsNullOrEmpty(obj.Name)) { return false; }
            return true;
        }

        public static void Update(SBCategory Obj)
        {
            SBCategory nCategory = SBContextProvider.db.Categories.Where(x => x.Id == Obj.Id).FirstOrDefault();
            nCategory.Name = Obj.Name;
            nCategory.Sprints = Obj.Sprints;

            SBContextProvider.db.SaveChanges();
        }

        public static SBCategory GetById(int ElemId)
        {
            return SBContextProvider.db.Categories.Where(x => x.Id == ElemId).FirstOrDefault();
        }

        public static List<SBCategory> GetAll()
        {
            return SBContextProvider.db.Categories.ToList();
        }
    }
}
