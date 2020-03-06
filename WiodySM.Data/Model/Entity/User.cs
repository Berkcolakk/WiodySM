using System.Collections.Generic;
using WiodySM.Data.Model.Entity.Base;

namespace WiodySM.Data.Model.Entity
{
    public class User : EntityBase
    {
        public string USER_ACCESSNAME { get; set; }

        public string USER_ACCESSPASSWORD { get; set; }

        public string USER_NAME_SURNAME { get; set; }

        public string USER_EMAIL { get; set; }

        public virtual List<ProjectManager> ProjectManagers { get; set; }

        public virtual List<ItemDemandMaster> ItemDemandMasters { get; set; }
    }
}