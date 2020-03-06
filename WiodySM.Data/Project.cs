namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            ItemDemandMaster = new HashSet<ItemDemandMaster>();
            ProjectExplore = new HashSet<ProjectExplore>();
            ProjectManager = new HashSet<ProjectManager>();
        }

        public int ID { get; set; }

        public string PROJECT_NAME { get; set; }

        public string PROJECT_PYP_NO { get; set; }

        public string PROJECT_DESC { get; set; }

        public int PROJECT_DAY { get; set; }

        public int PROJECT_COMPANY_ID { get; set; }

        public int PROJECT_TYPE_ID { get; set; }

        public int PROJECT_STATE_ID { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public int PROJECT_EXPLORESTATE_ID { get; set; }

        public string PROJECT_EXPLOREDESC { get; set; }

        public int PROJECT_CONTRACT_ID { get; set; }

        public virtual Company Company { get; set; }

        public virtual Contract Contract { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDemandMaster> ItemDemandMaster { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        public virtual ParameterDetail ParameterDetail1 { get; set; }

        public virtual ParameterDetail ParameterDetail2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectExplore> ProjectExplore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectManager> ProjectManager { get; set; }
    }
}
