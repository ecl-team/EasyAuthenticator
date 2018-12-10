package authlib;

import java.security.MessageDigest;

public class EHashing {
	public static String Hash(String input) {
		String str = null;
		try {
			MessageDigest digest = MessageDigest.getInstance("SHA-256");
			str = BytesToHex(digest.digest(input.getBytes("UTF-8")));
		} catch (Exception e) {
			e.printStackTrace();
		}
		return str;
	}
	
	private final static char[] hexArray = "0123456789ABCDEF".toCharArray();
	public static String BytesToHex(byte[] bytes) {
		char[] hexChars = new char[bytes.length * 2];
	    for ( int j = 0; j < bytes.length; j++ ) {
	        int v = bytes[j] & 0xFF;
	        hexChars[j * 2] = hexArray[v >>> 4];
	        hexChars[j * 2 + 1] = hexArray[v & 0x0F];
	    }
	    return new String(hexChars);
	}
}
