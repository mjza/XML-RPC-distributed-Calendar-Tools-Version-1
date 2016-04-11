package hpn.settings;

import java.net.InetAddress;
import java.net.UnknownHostException;

public final class LocalNet
{
    private static String ipAddress;

    public static String IpAddress()
    {
            ipAddress = LocalIPAddress();
            return ipAddress;
    }

    private static String LocalIPAddress()
    {
    	String localIP = "";
    	try {
			InetAddress thisHostIPv4 = InetAddress.getLocalHost();
			localIP = thisHostIPv4.getHostAddress();
		} catch (UnknownHostException e) {
			
		}
        return localIP;
    }
}