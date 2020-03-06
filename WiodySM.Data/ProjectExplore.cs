namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProjectExplore")]
    public partial class ProjectExplore
    {
        public int ID { get; set; }

        public string PROJECTEXPLORE_NAME { get; set; }

        public int PROJECTEXPLORE_ITEM_ID { get; set; }

        public int PROJECTEXPLORE_PROJECT_ID { get; set; }

        public double PROJECTEXPLORE_ITEMQUANTITY { get; set; }

        public string PROJECTEXPLORE_DESC { get; set; }

        public string PROJECTEXPLORE_DESC2 { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        public int? User_ID { get; set; }

        public virtual Item Item { get; set; }

        public virtual Project Project { get; set; }

        public virtual User User { get; set; }
    }
}
