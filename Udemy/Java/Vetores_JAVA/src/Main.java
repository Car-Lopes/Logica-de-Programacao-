import java.util.Locale;
import java.util.Scanner;

public class Main {
	
	public static void main(String[] args) {
	
		Locale.setDefault(Locale.US);
	    Scanner sc = new Scanner(System.in);
	    
	    int n; 
	    System.out.print("Quantos numeros ira digitar? ");
	    n = sc.nextInt();
	    
	    double[] vet = new double[n];
	    
	    for (int i =0; i < n; i++) {
	    	System.out.print("Digite um numero: ");
	    	vet[i] = sc.nextDouble();
	    }
	
	    System.out.println();
	    System.out.println("NUMEROS DIGITADOS: ");
	    
	    for (int i =0; i < n; i++) {
	    	System.out.println(String.format("%.1f", vet[i]));
	    }	
	
	}
}
