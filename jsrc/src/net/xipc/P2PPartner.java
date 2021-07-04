package net.xipc;

import java.net.ServerSocket;
import java.net.Socket;

public class P2PPartner implements NetworkPeer {
	protected ServerSocket sport;
	protected Socket cport;
	
	public String PartnerPublicKey;
	public String PartnerPeerKey;
}
