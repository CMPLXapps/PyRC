using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace xIPC.Net {

public class P2PAntenna : Antenna {

	public class Connection : PeerConnection {

		public IPEndPoint EndPoint;
		public Socket PeerSocket;
		public bool IsIPv4;
		public bool IsIPv6;
		private string ip;
		private int port;

		public Connection(string IP, int Port, 
			string IPv4Address=(string)null, string IPv6Address=(string)null , bool IsIPv4=true, bool IsIPv6=false)
		{

		}
	}
	
	public P2PAntenna() {

	} ~P2PAntenna() {}
}



}