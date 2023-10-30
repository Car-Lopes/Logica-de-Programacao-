import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.07(Acima Diagonal)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
	
		int n, soma=0, j=0;
		
		System.out.print("Qual a ordem da matriz? ");
		n = sc.nextInt();
		
		int [][] mat = new int[n][n];
		
		for (int i = 0; i < n; i++ ) {
			for (j = 0; j < n; j++ ) {
				System.out.print("Elemento [" + i + "," + j + "]: ");
				mat[i][j] = sc.nextInt();
			}
		}	
				
		for (int i = 0; i < n; i++ ) {
			
			for ( j = i + 1; j < n; j++) {
				
				soma = soma + mat[i][j];
			}
			
		}
		
		System.out.print("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + soma);
		
		sc.close();
	}	

}
