import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Dados_Pessoas)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, contF, contM;
		double menorAltura, maiorAltura, media, soma;
		
		System.out.print("Quantas pessoas serao digitadas? ");
		n = sc.nextInt();
		
		double[] vetAltura = new double[n];
		char[] vetGenero = new char[n];
		
		for (int i = 0; i < n; i++) {
			System.out.print("Altura da " + (i+1) + "a pessoa: ");
			vetAltura[i] = sc.nextDouble();
			System.out.print("Genero da " + (i+1) + "a pessoa: ");
			sc.nextLine();
			vetGenero[i] = sc.next().charAt(0);;
		}
		
		menorAltura = vetAltura[0];
		maiorAltura = vetAltura[0];
		for (int i = 1; i < n; i++) {
			if (menorAltura > vetAltura[i]) {
				menorAltura = vetAltura[i];
			}
			if (maiorAltura < vetAltura[i]) {
				maiorAltura = vetAltura[i];
			}
		}
		
		System.out.println("Menor Altura = " + menorAltura);
		System.out.println("Maior Altura = " + maiorAltura);
		
		soma = 0;
		contF = 0;
		contM = 0;
		
		for (int i = 0; i < n; i++) {
			if (vetGenero[i] == 'F') {
				soma = soma + vetAltura[i]; 
				contF++;
			} else {
				contM++;
			}
		}
		
		media = soma / contF;
		System.out.println("Media das alturas das mulheres  = " + String.format("%.2f", media)	 );
		System.out.println("Numero de homens = " + contM);
		
		sc.close();
	}	
}
