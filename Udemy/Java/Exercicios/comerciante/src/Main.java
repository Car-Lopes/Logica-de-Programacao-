import java.util.Locale;
import java.util.Scanner;

//Exercicio CAP.06(Comerciante)
public class Main {
	

	public static void main (String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n, dezPorCento, dezEVintePorCento, acimaVintePorCento;
		double porc, somaCompra, somaVenda, lucroTotal;
		
		System.out.print("Serao digitados dados de quantos produtos? ");
		n = sc.nextInt();
		
		String[] vetProduto = new String[n];
		double[] vetCompra = new double[n];
		double[] vetVenda = new double[n];
		
		for (int i = 0; i < n ; i++) {
			System.out.println("Produto " + (i+1) + ":");
			sc.nextLine();
			System.out.print("Nome: ");
			vetProduto[i] = sc.nextLine();
			System.out.print("Preco de compra: ");
			vetCompra[i] = sc.nextDouble();
			System.out.print("Preco de venda: ");
			vetVenda[i] = sc.nextDouble();
		}
		
		porc = 0;
		dezPorCento = 0; 
		dezEVintePorCento = 0;
		acimaVintePorCento = 0;
		
		for (int i = 0; i < n ; i++) {
			porc = (vetVenda[i] / vetCompra[i]-1)*100;
			if (porc < 10 ){
				dezPorCento++;
			} else if (porc <= 20){
				dezEVintePorCento ++; 
			} else {
				acimaVintePorCento++;
			}
		}
		
		somaCompra = 0;
		for (int i = 0; i < n; i++) {
			somaCompra = somaCompra + vetCompra[i];
		}
		
		somaVenda = 0;
		for (int i = 0; i < n; i++) {
			somaVenda = somaVenda + vetVenda[i];
		}
		
		//lucroTotal = 0;
		lucroTotal = somaVenda - somaCompra;
		
		System.out.println();
		System.out.println("RELATORIO: ");
		System.out.println("Lucro abaixo de 10%: " + dezPorCento);
		System.out.println("Lucro entre 10% e 20%: " + dezEVintePorCento);
		System.out.println("Lucro acima de 20%: " + acimaVintePorCento);
		System.out.println("Valor total de compra: " + String.format("%.2f", somaCompra));
		System.out.println("Valor total de venda: " + String.format("%.2f", somaVenda));
		System.out.println("Lucro total: " + String.format("%.2f", lucroTotal ));
		
		
		sc.close();
	}	
}
