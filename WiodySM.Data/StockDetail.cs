namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StockDetail")]
    public partial class StockDetail
    {
        public int ID { get; set; }

        public int STOCKDETAIL_ITEM_ID { get; set; }

        public int STOCKDETAIL_MASTER_ID { get; set; }

        public string STOCKDETAIL_BARCODE_ID { get; set; }

        public double STOCKDETAIL_QUANTITY { get; set; }

        public int STOCKDETAIL_STORE_ID { get; set; }

        public int STOCKDETAIL_RACK_ID { get; set; }

        public string STOCKDETAIL_DESCRIPTION { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public string STOCKDETAIL_SERIALNUMBER { get; set; }

        public int? STOCKDETAIL_REF_ID { get; set; }

        public string STOCKDETAIL_REF_LINK { get; set; }

        public virtual Item Item { get; set; }

        public virtual ParameterDetail ParameterDetail { get; set; }

        public virtual ParameterDetail ParameterDetail1 { get; set; }

        public virtual StockMaster StockMaster { get; set; }
    }
}
