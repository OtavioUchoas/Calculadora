
namespace SemMetodos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
                Console.WriteLine("Bem vindo a calculadora!");
                Console.ReadLine();
                Console.Clear();
            while (true)
            {
                Console.WriteLine("Escolha um numero REAL");
                string ap = Console.ReadLine();
                if (string.IsNullOrEmpty(ap) || char.IsLetter(ap[0])) 
                { 
                    while (true)
                    {
                        
                        Console.WriteLine("Escolha um numero corretamente");
                        ap = Console.ReadLine();
                        if (char.IsNumber(ap[0]))
                        {
                            break;
                        }
                        Console.Clear();
                    }
                }
                double a = Convert.ToInt64(ap.ToString());
                Console.Clear();
                Console.WriteLine("Escolha outro numero REAL");
                string bo = Console.ReadLine();
                if (string.IsNullOrEmpty(bo) || char.IsLetter(bo[0]))
                {
                    while (true)
                    {

                        Console.WriteLine("Escolha um numero corretamente");
                        bo = Console.ReadLine();
                        if (char.IsNumber(bo[0]))
                        {
                            break;
                        }
                        Console.Clear();
                    }
                }
                int b = Convert.ToInt32(bo.ToString());
                Console.Clear();
                Console.WriteLine("Escolha o tipo de operação que voce quer: +, - , *, /");
                string simbolo = Console.ReadLine();
                Console.Clear();
                if (simbolo != "+" && simbolo != "-" && simbolo != "*" && simbolo != "/")
                {
                    while (true)
                    {
                        Console.WriteLine("Insira um simbolo valido");
                        simbolo = Console.ReadLine();
                        if (simbolo != "+" && simbolo != "-" && simbolo != "*" && simbolo != "/")
                        {
                            Console.Clear();
                            continue; ;
                        }
                        else
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                if (simbolo == "+")
                {
                    Soma(a, b);
                }
                else if (simbolo == "-")
                {
                    Subtração(a, b);
                }
                else if (simbolo == "*")
                {
                    Multiplicação(a, b);
                }
                else
                {
                    Divisão(a, b);
                }
                Console.WriteLine("Você gostaria de calcular novamente? S/N");
                string decisao = Console.ReadLine();
                if (decisao == "S" || decisao == "s")
                {
                    Console.Clear() ;
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
        public static double Soma(double c, double n)
        {
            double r = c + n;
            Console.WriteLine($"{r}");
            return r;
            
        }

        public static double Subtração(double c, double n)
        {
            double r = c - n;
            Console.WriteLine($"{r}");
            return r;

        }

        public static double Multiplicação(double c, double n)
        {
            double r = c * n;
            Console.WriteLine($"{r}");
            return r;

        }

        public static double Divisão(double c, double n)
        {
          if (n == 0)
            {
                while (true)
                {
                    Console.WriteLine("Digite um valor diferente de 0 , animal.");
                    n = int.Parse(Console.ReadLine());
                    if (n != 0)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear ();
                        continue;
                    }
                }
            }
            double r = (c / n);
            Console.WriteLine($"{r}");
            return r;

        }
    }
}
