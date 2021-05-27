using System;
using Desafiodio5.Classes;
namespace Desafiodio5
{
    class Program
    {
        static ManipulaRepositorio repositorio=new ManipulaRepositorio();
        static void Main(string[] args)
        {
            string opcaousuario=Obteropcao();

           while (opcaousuario.ToUpper()!="X"){
               switch(opcaousuario){
                   case "1":
                   ListarSeries();
                   break;
                   case "2":
                   InserirSeries();
                   break;
                   case "3":
                   AtualizaSeries();
                   break;
                   case "4":
                   ExcluirSeries();
                   break;
                   case "5":
                   VizualizarSeries();
                   break;
                   case "c":
                   Console.Clear();
                   break;
                   default:
                   throw new ArgumentOutOfRangeException();
               }
               opcaousuario=Obteropcao();
           }
            
            
        }
    private static string Obteropcao(){
    
            Console.WriteLine();
            Console.WriteLine("Horizon , um Horizonte de Séries para você");
            Console.WriteLine("Informe a opção desejada");
            
            Console.WriteLine("1 -Listar Séries");
            Console.WriteLine("2- Inserir nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Vizualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

          string opcaoUser = Console.ReadLine().ToUpper();
          Console.WriteLine();

          return opcaoUser;
}
    private static void ListarSeries()
    {
        Console.WriteLine("Listar Séries");
        var lista = repositorio.Listar();
        if(lista.Count==0)
        {
            Console.WriteLine("Nenhuma Série cadastrada");
            return;
        }
        foreach (var serie in lista){
            Console.WriteLine("#ID {0}: - {1} : {2}",serie.retornaId(),serie.retornaTitulo(),(serie.retornaExcluido() ? "Excluido" : "" ));
        }
    }
  private static Serie CadastroSeries(int ide){
        Console.WriteLine("Inserir no Série");
        Console.WriteLine();

        foreach(int g in Enum.GetValues(typeof(Tipos)))
        {
            Console.WriteLine("{0} - {1}",g,Enum.GetName(typeof(Tipos), g));
        }
        Console.WriteLine("Digite o Gênero das opções acima :");
        int entradaGenero= int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o Titulo : ");
        string entradaTitulo= Console.ReadLine();

         Console.WriteLine("Digite o Ano :");
        int entradaAno= int.Parse(Console.ReadLine());

         Console.WriteLine("Digite a Descrição :");
        string entradaDescricao= Console.ReadLine();
        Serie novaSerie = new Serie(id: ide,
                                    tipo: (Tipos)entradaGenero,
                                    titulo: entradaTitulo,
                                    descrição: entradaDescricao,
                                    ano: entradaAno);
        return novaSerie;
  }
    private static void InserirSeries()
    {      
        repositorio.Insere(CadastroSeries(repositorio.PreoximoId()));       
    }   
    public static void AtualizaSeries(){
        Console.WriteLine("Digite o Id para Atualizar registro");        
        int entradaId=int.Parse(Console.ReadLine());

        repositorio.Atualiza(entradaId,CadastroSeries(entradaId));
    }    
    public static void ExcluirSeries(){
             Console.WriteLine("Digite o Id para Remover o  registro");        
            int entradaId=int.Parse(Console.ReadLine());

            repositorio.Exclui(entradaId);
    }
public static void VizualizarSeries(){
      Console.WriteLine("Digite o Id para vizualizar o  registro");        
            int entradaId=int.Parse(Console.ReadLine());

          Console.WriteLine(repositorio.RetornaPorId(entradaId));
}
    }        
}
