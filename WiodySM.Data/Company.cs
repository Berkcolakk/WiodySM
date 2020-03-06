namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Company")]
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            Project = new HashSet<Project>();
            StockMaster = new HashSet<StockMaster>();
            StockMaster1 = new HashSet<StockMaster>();
        }

        public int ID { get; set; }

        public string COMPANY_TAXNAME { get; set; }

        public string COMPANY_TAXNUMBER { get; set; }

        public string COMPANY_COMPANY_NAME { get; set; }

        public string COMPANY_PHONE { get; set; }

        public string COMPANY_FAX { get; set; }

        public string COMPANY_ADRESS { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public int? COMPANY_STORE_ID { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Project { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMaster> StockMaster { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockMaster> StockMaster1 { get; set; }
    }
}
