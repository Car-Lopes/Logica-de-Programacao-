import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Negativod)
public class Main {
	

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
	
		int n;
		
		System.out.print("Quantos numeros voçê vai digitar? ");
		n = sc.nextInt();
		
		int[] vet = new int[n];
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			vet[i] = sc.nextInt();
		}
		
		System.out.println("NUMEROS NEGATIVOS: ");
		for (int i = 0; i < n; i++) {
			if (vet[i] < 0) {
				System.out.print(vet[i] + " ");
			}
		}
		
		sc.close();
	}	

}
