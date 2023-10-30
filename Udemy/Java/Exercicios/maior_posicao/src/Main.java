import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Maior_Posição)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, contPosicao;
		double maior;
		
		System.out.print("Quantos numeros voçê vai digitar? ");
		n = sc.nextInt();
		
		double[] vetNumeros = new double[n];
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			vetNumeros[i] = sc.nextDouble();
		}
	
		maior = 0;
		contPosicao=0;
		for (int i = 0; i < n; i++) {
			if (maior < vetNumeros[i]) {
				maior = vetNumeros[i];
				contPosicao++;
			}
		}
		
		System.out.println();
		System.out.println("MAIOR VALOR = " + String.format("%.1f", maior));
		System.out.println("POSICAO DO MAIOR VALOR = " + contPosicao);
		
		sc.close();
	}	
}
