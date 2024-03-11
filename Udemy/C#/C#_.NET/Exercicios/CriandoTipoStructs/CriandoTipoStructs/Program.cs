namespace CriandoTipoStructs {
    internal class Program {
        static void Main(string[] args) {

            //Point p = new Point();
            Point p;

            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();

            Console.WriteLine(p);

            Console.WriteLine();

            //Usando o valor nullo em Structs

            double? A = null;
            double? B = 10.0;

            Console.WriteLine(A.GetValueOrDefault());
            Console.WriteLine(B.GetValueOrDefault());
            Console.WriteLine();
            
            Console.WriteLine(A.HasValue);
            Console.WriteLine(B.HasValue);
            Console.WriteLine();
            
            if (A.HasValue)
                Console.WriteLine(A.Value);
            else
                Console.WriteLine("A is null");
            if (B.HasValue)
                Console.WriteLine(B.Value);
            else
                Console.WriteLine("B is null");

            Console.WriteLine();

            double? c = null;
            double? d = 10;

            double e = c ?? 5;
            double f = d ?? 5;

            Console.WriteLine(e);
            Console.WriteLine(f);


        }
    }
}