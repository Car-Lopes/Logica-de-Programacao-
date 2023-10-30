import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.07(Soma Linhas)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
	
		int m, n;
		double soma;
		
		System.out.print("Qual a quantidade de linhas da matriz? ");
		m = sc.nextInt();
		System.out.print("Qual a quantidade de colunas da matriz? ");
		n = sc.nextInt();
		
		double [][] mat = new double[m][n];
		
		for (int i = 0; i < m; i++ ) {
			System.out.println("Digite os elementos da " + (i+1) + "a. linha: ");
			for (int j = 0; j < n; j++ ) {
				mat[i][j] = sc.nextDouble();
			}
		}
		
		double [] vet = new double[m];
		
		soma = 0;
		System.out.println("VETOR GERADO:");
		for (int i = 0; i < m; i++ ) {
			for (int j = 0; j < n; j++ ) {
				soma = soma + mat[i][j];
				vet[i] = soma;
			}
			System.out.println(vet[i]);
			soma = 0; 
		}	
		
		sc.close();
	}	
}
