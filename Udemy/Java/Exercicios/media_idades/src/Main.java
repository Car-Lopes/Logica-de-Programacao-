import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Media_Idades)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int idade, soma=0, cont=0;
		double media=0;
		
		System.out.println("Digite as idades: ");
		idade = sc.nextInt();
		
		if (idade < 0) {
			System.out.println("IMPOSSIVEL CALCULAR");	
		} else {
			while (idade > 0) {
					soma = soma + idade;
					cont++;
					idade = sc.nextInt();
			}
			
			media = ((double)soma / cont);
			System.out.println("Media = " + String.format("%.2f",media));
		}	
		
		
		
		sc.close();
	}	
}
