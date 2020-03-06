using System.ComponentModel.DataAnnotations.Schema;
using WiodySM.Data.Model.Entity.Base;

namespace WiodySM.Data.Model.Entity
{
    public class ItemDemandDetail : EntityBase
    {
        [ForeignKey("ItemDemandMaster")]
        public int ITEMDEMANDDETAIL_MASTER_ID { get; set; }

        [ForeignKey("Item")]
        public int ITEMDEMANDDETAIL_ITEM_ID { get; set; }

        public double ITEMDEMANDDETAIL_QUANTITY { get; set; }

        public virtual ItemDemandMaster ItemDemandMaster { get; set; }

        public virtual Item Item { get; set; }

        public bool ITEMDEMANDDETAIL_ITEM_CONFIRMATION { get; set; }
    }
}