import java.util.Locale;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Locale.setDefault(Locale.US);
		
		System.out.println("Primeiro Programa!");
		System.out.println();
		
		int idade = 30;
		double salario, altura;
		char genero = 'F';
		String nome;
		
		//idade = 30;
		salario = 6500.5;
		altura = 1.72;
		//genero = 'F';
		nome = "Maria Silva";
		
		System.out.println("IDADE = " + idade);
		System.out.println("SALARIO = " + String.format("%.2f", salario));
		System.out.println("ALTURA = " + String.format("%.2f", altura));
		System.out.println("GENERO = " + genero);
		System.out.println("NOME = " + nome);
		
		System.out.println();
		System.out.println("Exemplo 2");
		
		System.out.println("A funcionaria " + nome + ", sexo " + genero +
				", ganha " + String.format("%.2f", salario) + " e tem " + idade + " anos");
		
		System.out.println();
		System.out.println("Casting em JAVA");
		
		int a = 5, b = 2;
		double resultado;
		
		resultado = (double) a / b;
		
		System.out.println(resultado);
		
		System.out.println();
		
		double c;
		int d;
		c = 5.0;
		d = (int)c;
		
		System.out.println(d);
		
		//Entrada de dados no JAVA
		Scanner sc = new Scanner(System.in);
		
		String nome1, nome2;
		double salario1, salario2;
		int idd;
		char sexo;
		
		int x, y, z;
		
		System.out.print("Digite o nome da 1° Pessoa: ");
		nome1 = sc.nextLine();
		System.out.print("Digite o salario da 1° pessoa: ");
		salario1 = sc.nextDouble();
		
		System.out.print("Digite o nome da 2° Pessoa: ");
		sc.nextLine();
		nome2 = sc.nextLine();
		System.out.print("Digite o salario da 2° pessoa: ");
		salario2 = sc.nextDouble();
		
		System.out.print("Digite uma idade: ");
		idd = sc.nextInt();
		System.out.print("Digite um sexo (F/M): ");
		sexo = sc.next().charAt(0);
		
		System.out.println();
		
		System.out.println(nome1 + "Tem um Salario de " + String.format("%.2f" , salario1));
		System.out.println(nome2 + "Tem um Salario de " + String.format("%.2f" , salario2));
		System.out.println("Idade: " + idd);
		System.out.println("Sexo: " + sexo);
		
		//sc.close(); //Serve para desalocar os recurso do Scanner que foi criado
		
		System.out.println();
		
		//Usando o Debug
		x = sc.nextInt();
		System.out.println(x);
		y = x * 2;
		System.out.println(y);
		z = sc.nextInt();
		System.out.println(z);
		
		sc.close();
	}

}
