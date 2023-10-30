import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Mais_Velho)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
	
		int n, maisVelho;
		
		
		System.out.print("Quantas pessoas voçê vai digitar? ");
		n = sc.nextInt();
		
		int[] vetIdade = new int[n];
		String[] vetNome = new String[n];
		
		for (int i = 0; i < n; i++) {
			System.out.println("Dados da " + (i+1) + "a pessoa: ");
			sc.nextLine();
			System.out.print("Nome: ");
			vetNome[i] = sc.nextLine();
			System.out.print("Idade: ");
			vetIdade[i] = sc.nextInt();
		}
		
		String nome="ABC";
		maisVelho = vetIdade[0];
		
		for (int i = 0; i < n; i++ ) {
			if (vetIdade[i] > maisVelho) {
				maisVelho = vetIdade[i];
				 nome = vetNome[i];
			}	
		}
		
		System.out.println("PESSOA MAIS VELHA: " + nome);
		
		
		sc.close();
	}	

}
