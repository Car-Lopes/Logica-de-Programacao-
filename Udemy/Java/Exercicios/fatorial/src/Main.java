import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Fatorial)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, fatorial;
		
		System.out.print("Digite o valor de N: ");
		n = sc.nextInt();
		
		fatorial = n;
		for (int i = 1; i < n; i++) {
			fatorial = fatorial * i;
		}
		
		System.out.println("FATORIAL = " + fatorial);
		
		
		sc.close();
	}	
}
