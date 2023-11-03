import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.05(Experiencias)
public class Main {
	
	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, qtd, c, r, s, qtdTotal;
		char tpCobaia;
		double pcoelhos, pratos, psapos;
		
		System.out.print("Quantos casos de teste serao digitados? ");
		n = sc.nextInt();
		
		c = 0;
		r = 0;
		s = 0;
		
		for (int i = 0; i < n ; i++) {
			System.out.print("Quantidade de cobaias: ");
			qtd = sc.nextInt();
			System.out.print("Tipo de cobaia: ");
			tpCobaia = sc.next().charAt(0);
			
			
			if (tpCobaia == 'C') {
				c = c + qtd; 
			} else if (tpCobaia == 'R') {
				r = r + qtd;
			} else {
				s = s + qtd;
			}
		}
		
		qtdTotal = c + r + s;
		pcoelhos = ((double)c / qtdTotal) * 100.0;
		pratos = ((double)r / qtdTotal) * 100.0;
		psapos = ((double)s / qtdTotal) * 100.0;
		
		System.out.println();
		System.out.println("RELATORIO FINAL:");
		System.out.println("Total: " + qtdTotal);
		System.out.println("Total de coelhos: " + c);
		System.out.println("Total de ratos: " + r);
		System.out.println("Total de sapos: " + s);
		System.out.printf("Percentual de coelhos: %.2f\n" , pcoelhos);
		System.out.printf("Percentual de ratos: %.2f\n" , pratos);
		System.out.printf("Percentual de sapos: %.2f\n" , psapos);
		
		sc.close();
	}	
}
