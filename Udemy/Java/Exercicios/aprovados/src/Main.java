import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Aprovados)
public class Main {

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n;
		double soma;
		
		System.out.print("Quantos alunos serao digitados? ");
		n = sc.nextInt();
		
		String[] vetNome = new String[n];
		double[] vetN1 = new double[n];
		double[] vetN2 = new double[n];
		
		for (int i = 0; i < n; i++) {
			System.out.println("Digite nome, primeira e segunda nota do " + (i+1) +"o aluno: ");
			sc.nextLine();
			vetNome[i] = sc.nextLine();
			vetN1[i] = sc.nextDouble();
			vetN2[i] = sc.nextDouble();
		}
		
		soma = 0;
		System.out.println("Alunos aprovados: ");
		for (int i = 0; i < n; i++) {
			soma = vetN1[i] + vetN2[i];
			
			soma = soma /2;
			
			if (soma >= 6) {
				System.out.println(vetNome[i]);
			}
		}
		
		
		sc.close();
	}	
}
