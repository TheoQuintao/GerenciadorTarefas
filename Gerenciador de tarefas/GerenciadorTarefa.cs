using Tarefas;

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
                int i = 1;
                Tarefa.ExibirTarefa(i);
                i++;
            }
        }
    }
}