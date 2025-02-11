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
    }
}