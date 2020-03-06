using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.Data.Utilities
{
    public class IPRemote
    {
        private static string GetIPAddress()
        {
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Adresi Bulunamadı.!";
        }

        public static string IpAddress
        {
            get
            {
                return GetIPAddress();
            }
        }
    }
}
