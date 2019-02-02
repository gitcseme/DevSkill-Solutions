import java.math.BigInteger;
import java.util.Scanner;

class DCP_394 {

	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		while (scan.hasNext()) {
			BigInteger n = scan.nextBigInteger();
			n = n.multiply(n);
			System.out.println(n.toString());
		}
	}
}
