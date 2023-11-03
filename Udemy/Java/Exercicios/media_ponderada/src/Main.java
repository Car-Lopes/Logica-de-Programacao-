import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Media_Ponderada)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n;
		double num1=0, num2=0, num3=0, media=0, soma=0;
		
		System.out.print("Quantos casos voçê vai digitar? ");
		n = sc.nextInt();
		
		for (int i = 0; i < n; i++) {
			System.out.println("Digite tres numeros: ");
			num1 = sc.nextDouble();
			num2 = sc.nextDouble();
			num3 = sc.nextDouble();
			

			soma = (2*num1 + 3*num2 + 5*num3);
			media = soma / (2+3+5);
			
			System.out.println("MEDIA PONDERADA= " + String.format("%.1f",media));
		}
		
		sc.close();	
	}	
}
