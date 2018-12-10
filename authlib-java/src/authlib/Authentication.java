package authlib;

public class Authentication {
	public static boolean Verify(String UserID, String Code) {
		if (Code == CurrentCode(UserID))
			return true;
		else
			return false;
	}
	
	public static String CurrentCode(String UserID) {
		long seconds = java.time.Instant.now().getEpochSecond();
		String Key = UserID + (seconds - (seconds % 16));
		String hash = EHashing.Hash(Key);
		String Code = "";
        for (int i = 0; i < 8; i++)
        {
            Code += "" + Long.parseLong("" +
                hash.toCharArray()[8 * i] +
                hash.toCharArray()[8 * i + 1] +
                hash.toCharArray()[8 * i + 2] +
                hash.toCharArray()[8 * i + 3] +
                hash.toCharArray()[8 * i + 4] +
                hash.toCharArray()[8 * i + 5] +
                hash.toCharArray()[8 * i + 6] +
                hash.toCharArray()[8 * i + 7], 16) % 10;
        }
        return Code;
	}
}
