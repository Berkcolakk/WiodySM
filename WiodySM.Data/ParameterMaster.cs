namespace WiodySM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParameterMaster")]
    public partial class ParameterMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParameterMaster()
        {
            ParameterDetail = new HashSet<ParameterDetail>();
        }

        public int ID { get; set; }

        public string PARAMETERMASTER_NAME { get; set; }

        public bool PARAMETERMASTER_ISEDITABLE { get; set; }

        public string CREATED_DATE { get; set; }

        public int CREATED_USER_ID { get; set; }

        public string CREATED_USER_IP { get; set; }

        public bool ISACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParameterDetail> ParameterDetail { get; set; }
    }
}
