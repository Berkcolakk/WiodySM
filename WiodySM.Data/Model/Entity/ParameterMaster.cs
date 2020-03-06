using System.Collections.Generic;
using WiodySM.Data.Model.Entity.Base;

namespace WiodySM.Data.Model.Entity
{
    public class ParameterMaster : EntityBase
    {
        public string PARAMETERMASTER_NAME { get; set; }

        public bool PARAMETERMASTER_ISEDITABLE { get; set; } = true;

        public virtual List<ParameterDetail> ParameterDetails { get; set; }
    }
}