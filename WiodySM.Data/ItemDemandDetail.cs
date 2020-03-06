namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemDemandDetail")]
    public partial class ItemDemandDetail
    {
        public int ID { get; set; }

        public int ITEMDEMANDDETAIL_MASTER_ID { get; set; }

        public int ITEMDEMANDDETAIL_ITEM_ID { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public double ITEMDEMANDDETAIL_QUANTITY { get; set; }

        public virtual Item Item { get; set; }

        public virtual ItemDemandMaster ItemDemandMaster { get; set; }
    }
}
