import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(dentro_fora)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, num, dentro=0, fora=0;
		
		System.out.print("Quantos numeros vc vai digitar? ");
		n = sc.nextInt();
		
		for (int i = 0; i < n; i++) {
			System.out.print("Digite um numero: ");
			num = sc.nextInt();
			
			if (num >= 10 && num <= 20) {
				dentro++;
			} else {
				fora++;
			}
		}
		
		
		System.out.println(dentro + " DENTRO");
		System.out.println(fora + " FORA");
		
		sc.close();
	}	
}
