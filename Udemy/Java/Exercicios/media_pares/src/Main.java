import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Media Pares)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

	
		int n, contPares=0;
		double mediaPares, somaPares;
		
		System.out.print("Quantos elementos vai ter o vetor? ");
		n = sc.nextInt();
		
		int[] vet = new int[n];
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			vet[i] = sc.nextInt();
		}
		
		somaPares=0;
		for (int i = 0; i < n; i++) {
			if (vet[i] % 2 == 0) {
				somaPares = somaPares + vet[i];
				contPares++;
			} 
		}
		
		if (contPares != 0) {
			mediaPares = somaPares / contPares;
			System.out.println("MEDIA DOS PARES = " +  String.format("% .1f", mediaPares));
		} else {
			System.out.println("NENHUM NUMERO PAR");
		}		
		
		sc.close();
	}	
}
