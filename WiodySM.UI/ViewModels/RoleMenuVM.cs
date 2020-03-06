using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.ViewModels
{
    public class RoleMenuVM
    {
        public int ID { get; set; }
        public int MENUROLE_MENU_ID { get; set; }
        public int MENUROLE_ROLE_ID { get; set; }
        public string CREATED_DATE { get; set; }
        public int CREATED_USER_ID { get; set; }
        public string CREATED_USER_IP { get; set; }
        public string MACHINENAME_MACHINEIDENTITY { get; set; }
        public bool ISACTIVE { get; set; }
        public string MENUROLE_MENU_NAME { get; set; }
        public string MENUROLE_ROLE_NAME { get; set; }
    }
}
