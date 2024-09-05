using Newtonsoft.Json;

namespace Target.SaoPaulo
{
    public class DevSaoPaulo
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
            Questao4();
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\nQUESTÃO 5:");
            Console.WriteLine(Constantes.Questao5);
            Console.WriteLine($"\nRESPOSTA: {Questao5()}");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
        }

        public static int Questao1()
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

        public static string Questao2() 
        {
            var num = 13;
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

        public static string Questao3()
        {
            var fileName = "dados.json";
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            var jsonData = File.ReadAllText(jsonFilePath);
            var faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(jsonData);

            var menorValor = double.MaxValue;
            var maiorValor = double.MinValue;
            double somaValores = 0;
            var diasComFaturamento = 0;

            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor > 0)
                {
                    if (faturamento.Valor < menorValor) menorValor = faturamento.Valor;
                    if (faturamento.Valor > maiorValor) maiorValor = faturamento.Valor;
                    somaValores += faturamento.Valor;
                    diasComFaturamento++;
                }
            }

            var mediaMensal = somaValores / diasComFaturamento;

            var diasAcimaDaMedia = 0;

            foreach (var faturamento in faturamentos)
            {
                if (faturamento.Valor > mediaMensal)
                {
                    diasAcimaDaMedia++;
                }
            }

            return @$"Menor valor de faturamento: {menorValor:C}
Maior valor de faturamento: {maiorValor:C}
Número de dias com faturamento superior à média mensal: {diasAcimaDaMedia}";
        }

        public static void Questao4()
        {
            var faturamentos = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double totalFaturamento = 0;
            foreach (var valor in faturamentos.Values)
            {
                totalFaturamento += valor;
            }

            Console.WriteLine("\nRESPOSTA:");
            Console.WriteLine("Percentual de representação por estado:");
            foreach (var estado in faturamentos.Keys)
            {
                double valor = faturamentos[estado];
                double percentual = (valor / totalFaturamento) * 100;
                Console.WriteLine($"{estado}: {percentual:F2}%");
            }
        }

        public static string Questao5()
        {
            var palavra = "programa";

            string invertedString = InverterString(palavra);

            return $"String invertida: {invertedString}";

            static string InverterString(string str)
            {
                char[] caracteres = str.ToCharArray();

                int inicio = 0;
                int fim = caracteres.Length - 1;

                while (inicio < fim)
                {
                    char temp = caracteres[inicio];
                    caracteres[inicio] = caracteres[fim];
                    caracteres[fim] = temp;

                    inicio++;
                    fim--;
                }

                return new string(caracteres);
            }
        }
    }
}