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


        public static void ExibirTarefa(int id)
        {   
            try{
                Tarefa TarefaCorrespondente = Tarefa.TarefasList?.Find(t => t.ID == id);
                if(TarefaCorrespondente.Concluida == true)
                {
                    Console.WriteLine($"[X] ID: {TarefaCorrespondente.ID} ─ {TarefaCorrespondente.Nome}");
                }
                else{
                    Console.WriteLine($"[ ] ID: {TarefaCorrespondente.ID} ─ {TarefaCorrespondente.Nome}");
                }
            }
            catch{}   
        }   
    }
}