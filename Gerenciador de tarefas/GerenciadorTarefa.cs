using Tarefas;
using Layout;

namespace GerenciadorTarefas
{
    class Gerenciar{
        public static void AdicionarTarefa(String Descrição)
        {
            Tarefa.TarefasList.Add(new Tarefa {Nome = Descrição, ID = ++Tarefa.Contador, Concluida = false});
        }
        public static void ConcluirTarefa(int id)
        {
            Tarefa TarefaCorrespondente = Tarefa.TarefasList.Find(t => t.ID == id);
            TarefaCorrespondente.Concluida = true;
        }
        public static void ListarTarefas()
        {
            foreach(var a in Tarefa.TarefasList)
            {
                try
                {
                    if(a.Concluida == true)
                    {
                        Console.WriteLine($"[X] ID: {a.ID} ─ {a.Nome}");
                    }
                    else{
                        Console.WriteLine($"[ ] ID: {a.ID} ─ {a.Nome}");
                    }  
                }
                catch{} 
            }
        }
        public static void RemoverTarefa(int id)
        {
            Tarefa TarefaCorrespondente = Tarefa.TarefasList.Find(t => t.ID == id);
            Tarefa.TarefasList.Remove(TarefaCorrespondente);
        }
        public static int PegarID()
        {
            Return1:
            Console.Clear();
            ListarTarefas();
            Console.Write("Digite o ID do Produto: ");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Formatação.Cor(ConsoleColor.White,ConsoleColor.Red);
                Console.WriteLine("Valor Invalido!!!");
                Thread.Sleep(1500);
                goto Return1;
            }
            return id;
        }
    }
}