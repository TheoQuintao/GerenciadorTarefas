using GerenciadorTarefas;
using Layout;
using Tarefas;


Console.Clear();

string txt = " GERENCIADOR DE TAREFAS ";

while(true)
{
    Formatação.ImprimirCabecalho(txt);
    Console.Write(" 1 ─ Adicionar Tarefa\n 2 ─ Listar Tarefas\n 3 ─ Concluir Tarefa\n 4 ─ Remover Tarefa\n 0 ─ Sair\n Escolha uma opção: ");
    string menu = Console.ReadLine()??"";
    Console.Clear();
    switch(menu)
    {
        case "0":
        return;

        case "1":
            Gerenciar.AdicionarTarefa(Gerenciar.PegarDescrição());
        break;

        case "2":
            Gerenciar.ListarTarefas();
        break;

        case "3":
            Gerenciar.ConcluirTarefa(Gerenciar.PegarID());
        break;

        case "4":
            Gerenciar.RemoverTarefa(Gerenciar.PegarID());
        break;
    }
}