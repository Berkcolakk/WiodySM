namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Item1 = new HashSet<Item>();
            Item11 = new HashSet<Item>();
            Item12 = new HashSet<Item>();
            ItemDemandDetail = new HashSet<ItemDemandDetail>();
            ProjectExplore = new HashSet<ProjectExplore>();
            StockDetail = new HashSet<StockDetail>();
        }

        public int ID { get; set; }

        public string ITEM_NAME { get; set; }

        public string ITEM_CODE { get; set; }

        public string ITEM_DESCRIPTION { get; set; }

        public int ITEM_UNIT_ID { get; set; }

        public int ITEM_GROUP_ID { get; set; }

        public string ITEM_REF_CODE { get; set; }

        public string ITEM_SERIALNUMBER { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public int? ITEM_ITEMASSM_ID { get; set; }

        public int? ITEM_ITEMDEASSM_ID { get; set; }

        public int? ITEM_ITEMDEASSMDE_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item1 { get; set; }

        public virtual Item Item2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item11 { get; set; }

        public virtual Item Item3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Item12 { get; set; }

        public virtual Item Item4 { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        public virtual ParameterDetail ParameterDetail1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDemandDetail> ItemDemandDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectExplore> ProjectExplore { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StockDetail> StockDetail { get; set; }
    }
}
