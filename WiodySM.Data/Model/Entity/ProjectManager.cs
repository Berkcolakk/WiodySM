using System.ComponentModel.DataAnnotations.Schema;
using WiodySM.Data.Model.Entity.Base;

namespace WiodySM.Data.Model.Entity
{
    public class ProjectManager : EntityBase
    {
        [ForeignKey("Project")]
        public int PROJECTMANAGER_PROJECT_ID { get; set; }
        [ForeignKey("User")]
        public int PROJECTMANAGER_USER_ID { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }
    }
}