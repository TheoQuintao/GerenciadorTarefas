using System.Dynamic;

namespace Tarefas
{
    public class  Tarefa
    {
        public static int Contador = 0;
        public string Nome {get;set;}
        public int ID {get;set;}

        public bool Concluida {get;set;}
        public static List<Tarefa> TarefasList = new List<Tarefa>();


        public static void ExibirTarefa(int id, bool concluida, string nome)
        {   
                if(concluida== true)
                {
                    Console.WriteLine($"[X] ID: {id} ─ {nome}");
                }
                else{
                    Console.WriteLine($"[ ] ID: {id} ─ {nome}");
                }
  
        }   
    }
}