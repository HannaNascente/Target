using Target.RibeiraoPreto;
using Target.SaoPaulo;

Console.WriteLine("Escolha uma das opções:");
Console.WriteLine("1. Dev São Paulo");
Console.WriteLine("2. Dev Ribeirão Preto");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    DevSaoPaulo.Menu();
}
else
{
    DevRibeiraoPreto.Menu();
}