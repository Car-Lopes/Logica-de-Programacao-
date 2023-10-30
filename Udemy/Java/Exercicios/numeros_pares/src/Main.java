import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Numeros_Pares)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, contPares=0;
		
		System.out.print("Quantos numeros voçê vai digitar? ");
		n = sc.nextInt();
		
		int[] vetNumeros = new int[n];
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			vetNumeros[i] = sc.nextInt();
		}
		
		System.out.println();
		System.out.println("NUMEROS PARES: ");
		for (int i = 0; i < n; i++) {
			if (vetNumeros[i] % 2 == 0) {
				System.out.print(vetNumeros[i] + "  ");
				contPares++;
			}
		}
		
		System.out.println();
		System.out.println();
		System.out.print("QUANTIDADE DE PARES = " + contPares);
	
	sc.close();	
	}	
}
