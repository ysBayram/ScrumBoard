using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumBoard
{
    public interface ICRUDuc
    {
        SBInput SBCRUDInput { get; set; }

        void SBCRUDInsert();

        void SBCRUDUpdate();

        void SBCRUDDelete();

        List<SBInput> SBCRUDGetAll();

        void SBCRUDLoadDetail();

        void SBCRUDClearComp();

        bool SBCRUDCheck();
    }
}
