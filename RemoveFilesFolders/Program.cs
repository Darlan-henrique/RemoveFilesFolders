using System;

namespace RemoveFilesFolders
{
    class Program
    {

        static void Main(string[] args)
        {
            Localizador localizadorDir = new Localizador();

            Console.WriteLine("###########  Procurando diretórios ################\n");

            Console.WriteLine(@"Informe o nome do diretório de início (Ex: c:\dados) ");
            localizadorDir.NomeDiretorio = Console.ReadLine();
            Console.WriteLine();

            while (localizadorDir.Opcao != 3)
            {
                Console.WriteLine();
                Console.WriteLine("Selecione a opcao desejada:");
                Console.WriteLine(
                    "1: Exibir pastas\n" +
                    "2: Deletar pastas com + de 30 dias\n" +
                    "3: Sair");
                localizadorDir.Opcao = int.Parse(Console.ReadLine());

                if (localizadorDir.Opcao == 1 || localizadorDir.Opcao == 2)
                {
                    Console.WriteLine($"Exibindo os resultados do diretorio..... { localizadorDir.NomeDiretorio}");
                }

                Localizador.ProcurarPor(localizadorDir.NomeDiretorio, localizadorDir.Opcao);
            }

        }

    }

}
