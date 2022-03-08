using System;
using System.IO;

namespace RemoveFilesFolders
{
    public class Localizador

    {
        public int Opcao;
        public string NomeDiretorio;

        public static void ProcurarPor(string nomeDiretorio, int opcao)
        {
            DirectoryInfo diretorio = new DirectoryInfo(nomeDiretorio);

            if (diretorio.Exists)
            {
                foreach (DirectoryInfo subDiretorios in diretorio.GetDirectories())
                {
                    TimeSpan tempo = DateTime.Now.Subtract(subDiretorios.CreationTime);

                    switch (opcao)
                    {

                        case 1:
                            Console.WriteLine($"Pasta {subDiretorios.Name} criado a {tempo.Days} dias");
                            break;

                        case 2:
                            if (tempo.Days >= 30)
                            {
                                subDiretorios.Delete(true);
                                Console.WriteLine($"{subDiretorios.Name} com mais de {tempo.Days} dias deletadas com sucesso!! ");
                            }
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Digite uma opção valida");
                            break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Diretorio nao existe");
            }
        }

    }
}
