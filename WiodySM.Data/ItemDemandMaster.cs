namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemDemandMaster")]
    public partial class ItemDemandMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemDemandMaster()
        {
            ItemDemandDetail = new HashSet<ItemDemandDetail>();
        }

        public int ID { get; set; }

        public int ITEMDEMANDMASTER_PROJECT_ID { get; set; }

        public int ITEMDEMANDMASTER_USER_ID { get; set; }

        public string ITEMDEMANDMASTER_DESC { get; set; }

        public int ITEMDEMANDMASTER_STATE_ID { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDemandDetail> ItemDemandDetail { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}
