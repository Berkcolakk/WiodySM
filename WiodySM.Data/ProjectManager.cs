namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectManager")]
    public partial class ProjectManager
    {
        public int ID { get; set; }

        public int PROJECTMANAGER_PROJECT_ID { get; set; }

        public int PROJECTMANAGER_USER_ID { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}
