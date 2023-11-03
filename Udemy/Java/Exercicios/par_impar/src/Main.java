import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Par_Impar)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int n, num;
		
		System.out.print("Quantos numeros voce ira digitar? ");
		n = sc.nextInt();
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			num = sc.nextInt();
			
			if (num == 0) {
				System.out.println("NULLO");
			} else if (num < 0 && num % 2 == 0) {
				System.out.println("PAR NEGATIVO");
			} else if (num > 0 && num % 2 == 0) {
				System.out.println("PAR POSITIVO");
			} else if (num > 0 && num % 2 == 1) {
				System.out.println("IMPAR POSITIVO");
			} else {
				System.out.println("IMPAR NEGATIVO");
			}	
		}
		
		sc.close();
	}	
}
