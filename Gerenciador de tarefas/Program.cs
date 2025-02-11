using GerenciadorTarefas;
using Layout;
using Tarefas;


Console.Clear();

string txt = " GERENCIADOR DE TAREFAS ";

Formatação.ImprimirCabecalho(txt);
Gerenciar.AdicionarTarefa("Comer Melancia");
Tarefa.ExibirTarefa(1);
Gerenciar.ConcluirTarefa(1);
Tarefa.ExibirTarefa(1);
Gerenciar.ListarTarefas();