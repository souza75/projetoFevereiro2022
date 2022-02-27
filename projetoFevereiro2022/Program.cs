using System;
using Serie;


namespace Serie;
{
class Program
{
    private static string genero;

    static void Main(string[] args, string nomeSerie, string genero)
    {
        while (true) {
          
            Console.WriteLine("Pesquisar série pelo nome");
            Console.WriteLine("Pesquisar série pelo gênero");]
            Console.WriteLine("Incluir série");
            Console.WriteLine("Excluir série");

            int opcao = Console.ReadLine("\nOpção: ");

            switch (opcao) {
                case 0: break;
              

                case 2: pesqSerieNome();
                    break;

                case 3: pesqSerieGenero();
                    break;

                case 4: incluirSerie;
                    break;

                case 5: excluirSerie;
                    break;

                default: Console.WriteLine("Opção invalida, escolha novamente");
            }

            public static void incluirSerie(string nomeSerie, string genero)
            {
                Console.WriteLine("Digite o nome da serie");
                string nome = nomeSerie;
                string g = genero;

            }

            public static void excluirSerie(string nomeSerie, string genero)
            {
                Console.WriteLine("Digite o nome da série a ser excluida");
                string nome = nomeSerie.Trim();
                genero = null;
                nome = null;
            }
        }

    }

  

    public static void pesqSerieNome()
    {
        Console.WriteLine("Pesquisar série pelo nome");
        string v = Console.ReadLine("nome da Serie"+nomeSerie);
        String nomeSerie = v;
    }

    public static void pesqSerieGenero()
    {
        Console.WriteLine("Pesquisar serie pelo Nome:");
        string s = Console.ReadLine("genero da Serie" + genero);
        String nomeSerie = s;
    }
}