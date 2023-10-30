import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Alturas)
public class Main {
	
	public static void main (String[] args) {
	
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
	
		int n;
		double alturatotal=0, porcIdade=0, mediaAltura=0;
		
		System.out.print("Quantas pessoas serao digitadas? ");
		n = sc.nextInt();
		
		String[] vetNome = new String[n];
		int[] vetIdade = new int[n];
		double[] vetAltura = new double[n];
		
		for (int i = 0; i < n; i++) {
			System.out.println("Dados da " + (i+1) + "a pessoa: ");
			sc.nextLine(); 
			System.out.print("Nome: ");
			vetNome[i] = sc.nextLine();
			System.out.print("Idade: ");
			vetIdade[i] = sc.nextInt();
			System.out.print("Altura: ");
			vetAltura[i] = sc.nextDouble();
		}
		
		System.out.println();
		
		for (int i = 0; i < n; i++) {
			alturatotal = alturatotal + vetAltura[i];
		}
		
		mediaAltura = alturatotal / n;
		System.out.printf("Altura média:  %.2f", mediaAltura);
		System.out.println();
		
		for (int i = 0; i < n; i++) {
			if (vetIdade[i] < 16) {
				porcIdade++;
			}
		}
		
		porcIdade = ((porcIdade / n)*100);
		
		System.out.println("Pessoas com menos de 16 anos:" + String.format("  %.1f",porcIdade) + "%");
		
		for (int i = 0; i < n; i++) {
			if (vetIdade[i] < 16) {
				System.out.println(vetNome[i]);
			}
		}
		
		sc.close();
	}	
}
