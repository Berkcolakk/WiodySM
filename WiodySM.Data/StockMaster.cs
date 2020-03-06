namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockMaster")]
    public partial class StockMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockMaster()
        {
            StockDetail = new HashSet<StockDetail>();
        }

        public int ID { get; set; }

        public int STOCKMASTER_TYPE_ID { get; set; }

        public int STOCKMASTER_STORE_ID { get; set; }

        public int STOCKMASTER_COMPANY_ID { get; set; }

        public string STOCKMASTER_WAYBILL_NO { get; set; }

        public string STOCKMASTER_WAYBILL_DATE { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public int? COMPANY_SUB_COMPANY_ID { get; set; }

        public int? STOCKMASTER_REF_ID { get; set; }

        public string STOCKMASTER_REF_LINK { get; set; }

        public virtual Company Company { get; set; }

        public virtual Company Company1 { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        public virtual ParameterDetail ParameterDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDetail> StockDetail { get; set; }
    }
}
