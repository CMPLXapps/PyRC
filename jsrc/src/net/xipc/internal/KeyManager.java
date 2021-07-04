package net.xipc.internal;

import net.xipc.keymanagement.Keyring;

public class KeyManager {
	protected static class conv {
		public String GetStringHex(String s) {
			String HexStr = "";
			for ( int i = 0 ; i < s.length() ; i++ ) {
				HexStr += Integer.toHexString(s.charAt(i) | 0x10000).substring(1);
			} return HexStr;
		}
		
		public static String GetCharHex(char c) {
			return Integer.toHexString(c | 0x10000).substring(1);
		}
	}
	
	protected String HexinatePublicKey(String key) {
		
		
		return (String) null;
	}
	
	public String GetSoftKey(Keyring keys) {
		
		
		return (String) null;
	};
}
