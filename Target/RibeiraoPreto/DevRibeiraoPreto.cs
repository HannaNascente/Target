namespace Target.RibeiraoPreto
{
    public class DevRibeiraoPreto
    {
        public static void Menu()
        {
            Console.WriteLine("\nQUESTÃO 1:");
            Console.WriteLine(Constantes.Questao1);
            Console.WriteLine($"\nRESPOSTA: {Questao1()}");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nQUESTÃO 2:");
            Console.WriteLine(Constantes.Questao2);
            Console.WriteLine($"\nRESPOSTA: {Questao2()}");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nQUESTÃO 3:");
            Console.WriteLine(Constantes.Questao3);
            Console.WriteLine($"\nRESPOSTA: {Questao3()}");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nQUESTÃO 4:");
            Console.WriteLine(Constantes.Questao4);
            Console.WriteLine("\nRESPOSTA:");
            Questao4();
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nQUESTÃO 5:");
            Console.WriteLine(Constantes.Questao5);
            Console.WriteLine("\nRESPOSTA:");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
        }

        public static string Questao1() 
        {
            var num = 14;
            var resposta = "";

            if (IsFibonacci(num))
            {
                resposta = $"O número {num} pertence à sequência de Fibonacci.";
            }
            else
            {
                resposta = $"O número {num} não pertence à sequência de Fibonacci.";
            }

            return resposta;

            static bool IsFibonacci(int number)
            {
                if (number < 0)
                {
                    return false;
                }

                if (number == 0 || number == 1)
                {
                    return true;
                }

                int a = 0, b = 1;

                while (b < number)
                {
                    var temp = a;
                    a = b;
                    b = temp + b;
                }

                return b == number;
            }
        }

        public static string Questao2()
        {
            var palavra = "programa";

            var quantidadeA = ContarOcorrenciasDeA(palavra);

            return $"Quantidade de vezes que a letra 'a' ocorre: {quantidadeA}";

            static int ContarOcorrenciasDeA(string str)
            {
                // Inicializa o contador
                var contador = 0;

                var strMinuscula = str.ToLower();

                foreach (var c in strMinuscula)
                {
                    if (c == 'a')
                    {
                        contador++;
                    }
                }

                return contador;
            }
        }

        public static int Questao3()
        {
            var indice = 13;
            var soma = 0;
            var k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }

            return soma;
        }

        public static void Questao4()
        {
            int a_next = 7 + 2;
            Console.WriteLine("Próximo elemento da sequência a: " + a_next);

            int b_last = 64;
            int b_next = b_last * 2;
            Console.WriteLine("Próximo elemento da sequência b: " + b_next);

            int c_next = 7 * 7;
            Console.WriteLine("Próximo elemento da sequência c: " + c_next);

            int d_next = 10 * 10;
            Console.WriteLine("Próximo elemento da sequência d: " + d_next);

            int e_a = 5;
            int e_b = 8;
            int e_next = e_a + e_b;
            Console.WriteLine("Próximo elemento da sequência e: " + e_next);

            int f_next = 19 + 1;
            Console.WriteLine("Próximo elemento da sequência f: " + f_next);
        }

        public static void Questao5()
        {

        }
    }
}