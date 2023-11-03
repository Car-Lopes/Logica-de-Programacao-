import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Sequencia_Impares)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n; 
		
		System.out.print("Digite o valor de X: ");
		n = sc.nextInt();
		
		for (int i = 1; i <= n; i++) {
			if ( i  % 2 == 1) {
		
				System.out.println(i);
			} 
		}
		sc.close();	
	}	
}
