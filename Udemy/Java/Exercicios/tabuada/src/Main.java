import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Tabuada)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, res;
		
		System.out.print("Deseja a tabuada para qual valor? ");
		n = sc.nextInt();
		
		for (int i = 1; i < 11; i++) {
			res = n * i;
			System.out.println(n + " x " + i + " = " + res );
		}
		
		
		sc.close();
	}	
}
