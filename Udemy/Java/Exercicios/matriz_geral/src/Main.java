import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.07(Matriz Geral)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, escolha, j, i;
		double soma;
		
		System.out.print("Qual a ordem da matriz? ");
		n = sc.nextInt();
		
		double [][] mat = new double[n][n];
		
		for (i = 0; i < n; i++ ) {
			for (j = 0; j < n; j++ ) {
				System.out.print("Elemento [" + i + "," + j + "]: ");
				mat[i][j] = sc.nextDouble();
			}
		}
		
		soma = 0 ;
		for (i = 0; i < n; i++ ) {
			for (j = 0; j < n; j++ ) {
				if (mat[i][j] > 0) {
					soma  = soma + mat[i][j];
				}
			}
		}
		System.out.println();
		System.out.println("SOMA DOS POSITIVOS: " + String.format("%.1f",soma));
		
		System.out.println();
		System.out.print("Escolha uma linha: ");
		escolha = sc.nextInt();
		
		System.out.print("LINHA ESCOLHIDA: ");
		for (i = escolha ; i <= escolha; i++ ) {
			for (j = 0; j < n; j++ ) {
				System.out.print(mat[i][j] + "  ");
			}
		}
		
		System.out.println();
		System.out.println();
		System.out.print("Escolha uma coluna: ");
		escolha = sc.nextInt();
		
		System.out.print("COLUNA ESCOLHIDA: ");
		for (i = 0 ; i < n; i++ ) {
			for (j = escolha; j <= escolha; j++ ) {
				System.out.print(mat[i][j] + "  ");
			}
		}
		
		System.out.println();
		System.out.println();
		System.out.print("DIAGONAL PRINCIPAL: ");
		for (i = 0 ; i < n; i++ ) {
			//for (j = 0; j < n; j++ ) {
				//if (i = j) {
					System.out.print(mat[i][i] + "  ");
				//}
			//}
		}
		
		System.out.println();
		System.out.println();
		for (i = 0 ; i < n; i++ ) {
			for (j = 0; j < n; j++ ) {
				if (mat[i][j] < 0) {
					mat[i][j] = Math.pow(mat[i][j], 2.0);
				}
			}
		}
		
		System.out.println("MATRIZ ALTERADA: ");
		for (i = 0 ; i < n; i++ ) {
			for (j = 0; j < n; j++ ) {
				System.out.print(mat[i][j] + "  ");
			}
			System.out.println();
		}
		
		sc.close();
	}	
}
