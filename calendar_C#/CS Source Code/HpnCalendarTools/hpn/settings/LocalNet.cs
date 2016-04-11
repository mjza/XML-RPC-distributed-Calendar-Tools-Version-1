using System;
using System.Net;
using System.Net.Sockets;

namespace hpn.settings
{
    public static class LocalNet
    {
        private static String ipAddress;

        public static String IpAddress
        {
            get
            {
                ipAddress = LocalIPAddress();
                return ipAddress;
            }
            set
            {
                ipAddress = LocalIPAddress();
            }
        }

        private static String LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}
