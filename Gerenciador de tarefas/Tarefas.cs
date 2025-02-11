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


        public static void ExibirTarefa(string NomeTarefa, int ID, bool Concluida)
        {
            if(Concluida == true)
            {
                Console.WriteLine($"[X] ID: {ID} ─ {NomeTarefa}");
            }
            else{
                Console.WriteLine($"[ ] ID: {ID} ─ {NomeTarefa}");
            }
        }
    }
}