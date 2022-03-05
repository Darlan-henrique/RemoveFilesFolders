using System;
using System.IO;

namespace RemoveFilesFolders
{

    public class Localizador

    {
        public int opcao;
        public string nomeDiretorio;
        
        public static void ProcurarPor(string nomeDiretorio, int opcao)
        {
            DirectoryInfo diretorio = new DirectoryInfo(nomeDiretorio);

            Console.WriteLine($"Exibindo os resultados do diretorio..... { nomeDiretorio}");
            Console.WriteLine();

            if (diretorio.Exists)
            {
               
                foreach (DirectoryInfo subDiretorio in diretorio.GetDirectories())
                {
                    TimeSpan tempo = DateTime.Now.Subtract(subDiretorio.CreationTime);

                    switch (opcao) {
                    
                        case 1:
                            Console.WriteLine($"Pasta {subDiretorio.Name} criado a {tempo.Days} dias");
                            break;

                        case 2:
                            if (tempo.Days >= 30)
                                subDiretorio.Delete(true);
                                Console.WriteLine($"Pastas com mais de 30 dias deletadas com sucesso!! ");                           
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Escolha uma opção valida");
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
