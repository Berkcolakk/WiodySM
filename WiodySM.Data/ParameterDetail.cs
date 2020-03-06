namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParameterDetail")]
    public partial class ParameterDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParameterDetail()
        {
            Company = new HashSet<Company>();
            Item = new HashSet<Item>();
            Item1 = new HashSet<Item>();
            ItemDemandMaster = new HashSet<ItemDemandMaster>();
            Project = new HashSet<Project>();
            Project1 = new HashSet<Project>();
            Project2 = new HashSet<Project>();
            StockDetail = new HashSet<StockDetail>();
            StockDetail1 = new HashSet<StockDetail>();
            StockMaster = new HashSet<StockMaster>();
            StockMaster1 = new HashSet<StockMaster>();
        }

        public int ID { get; set; }

        public string PARAMETERDETAIL_NAME { get; set; }

        public string PARAMETERDETAIL_VALUE1 { get; set; }

        public string PARAMETERDETAIL_VALUE2 { get; set; }

        public string PARAMETERDETAIL_VALUE3 { get; set; }

        public int PARAMETERDETAIL_MASTER_ID { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company> Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDemandMaster> ItemDemandMaster { get; set; }

        public virtual ParameterMaster ParameterMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Project1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Project2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDetail> StockDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDetail> StockDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMaster> StockMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMaster> StockMaster1 { get; set; }
    }
}
