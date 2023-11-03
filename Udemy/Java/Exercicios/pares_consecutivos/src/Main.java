import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Pares_Consecutivos)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		
		int num=0, soma=0, i=0; 
		
		System.out.print("Digite um numero inteiro: ");
		num = sc.nextInt();
		
		while (num != 0) {
			
			if (num % 2 == 0) {
				while (i < 5) {
					i = i + 1;
					soma = soma + num;
					num = num + 2;
				}
				System.out.println("SOMA = " + soma);
			} else {
				num = num + 1;
				while (i < 5) {
					i = i + 1;
					soma = soma + num;
					num = num + 2;
				}
				System.out.println("SOMA = " + soma);
			}
			
			num = 0;
			i = 0;
			soma = 0;
			
			System.out.print("Digite um numero inteiro: ");
			num = sc.nextInt();
		}
		
		
		sc.close();
	}	
}
