package authlib;

public class Test {

	public static void main(String[] args) throws Exception {
		while(true) {
			System.out.println(Authentication.CurrentCode("Eclipsum"));System.out.println(System.currentTimeMillis() / 1000L);
			Thread.sleep(1000);
		}
	}
}
