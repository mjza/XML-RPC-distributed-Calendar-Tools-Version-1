using System;
using Nwc.XmlRpc;
using hpn.settings;

namespace hpn.cs.xml.webserver
{
    public class HpnXmlRpcServer : XmlRpcServer
    {
        private int port;
        public HpnXmlRpcServer() : base(DefaultPort.portNumber)
        {
        }
        public HpnXmlRpcServer(int port) : base(port)
        {
            this.setPort(port);
        }
        public void startServing()
	    {
		    this.Start();
		    ServerStatus.initServerStatus(this);
		    ServerStatus.setServerStatus(true);
	    }
	    public void signOn()
	    {
		    //this.Start();
		    ServerStatus.setServerStatus(true);
	    }
	    public void signOff()
	    {
            //this.Stop();//it has a problem in C# xmlrpc library so we changed the program in a new way to support signoff
            ServerStatus.setServerStatus(false);
	    }
        public int getPort()
        {
            return this.port;
        }
        public void setPort(int port)
        {
            if (port > 1024 && port <= 65535)
            {
                this.port = port;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("The port number of the host [" + port + "] is invalid. It must be between 1025 and  65535.");
            }
        }
    }
}
