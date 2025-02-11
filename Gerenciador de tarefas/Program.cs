using GerenciadorTarefas;
using Layout;
using Tarefas;

string txt = " GERENCIADOR DE TAREFAS ";

Formatação.ImprimirCabecalho(txt);
Gerenciar.AdicionarTarefa("Comer Melancia");
Tarefa.ExibirTarefa(1);
Gerenciar.ConcluirTarefa(1);
Tarefa.ExibirTarefa(1);