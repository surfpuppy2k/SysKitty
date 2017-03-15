using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK_Net
{
    public class SKN
    {
        public string SysName { get; set; }
        public string IPAddress { get; set; }
        public string SubnetMask { get; set; }
        public string Gateway { get; set; }
        public bool IsDHCPEnabled { get; set; }
        public string MACAddress { get; set; }


        public SKN(string m_SysName, string m_IPAddress, string m_SubnetMask, string m_Gateway, bool m_IsDHCPEnabled, string m_MACAddress)
        {
            SysName = m_SysName;
            IPAddress = m_IPAddress;
            SubnetMask = m_SubnetMask;
            Gateway = m_Gateway;
            IsDHCPEnabled = m_IsDHCPEnabled;
            MACAddress = m_MACAddress;
        }

        public SKN() { }
    }
}
