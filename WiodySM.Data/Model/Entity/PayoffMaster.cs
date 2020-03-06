using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using WiodySM.Data.Model.Entity.Base;

namespace WiodySM.Data.Model.Entity
{
    public class PayoffMaster : EntityBase
    {
        [ForeignKey("Project")]
        public int PAYOFFMASTER_PROJECT_ID { get; set; }
        public double PAYOFFMASTER_PARAMETERCODE { get; set; }
        public virtual Project Project { get; set; }
        public virtual List<PayoffDefault> PayoffDefaults { get; set; }
        public virtual List<PayoffControl> PayoffControls { get; set; }
    }
}