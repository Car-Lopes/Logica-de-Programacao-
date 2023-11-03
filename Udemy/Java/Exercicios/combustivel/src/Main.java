import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Combustivel)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);

		int tipoCombustivel, contA=0, contG=0, contD=0;
		
		do {
		
			System.out.print("Informe um codigo (1, 2, 3) ou 4 para parar: ");
			tipoCombustivel = sc.nextInt();
		
		
			if (tipoCombustivel == 1) {
				contA++;
			} else if (tipoCombustivel == 2) {
				contG++;
			} else if (tipoCombustivel == 3) {
				contD++;
			} else {
				
			}
		
		} while (tipoCombustivel != 4 ) ;
		
		System.out.println();
		System.out.println("MUITO OBRIGADO ");
		System.out.println("Alcool: " + contA);
		System.out.println("Gasolina: " + contG);
		System.out.println("Diesel: " + contD);
		
		sc.close();
	}	
}
