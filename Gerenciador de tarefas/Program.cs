using GerenciadorTarefas;
using Layout;

Console.Clear();

string txt = " GERENCIADOR DE TAREFAS ";
bool rodando = true;

while(rodando==true)
{
    Formatação.ImprimirCabecalho(txt);
    Console.Write(" 1 ─ Adicionar Tarefa\n 2 ─ Listar Tarefas\n 3 ─ Concluir Tarefa\n 4 ─ Remover Tarefa\n 0 ─ Sair\n Escolha uma opção: ");
    string menu = Console.ReadLine()??"";

    if(menu == "0")
    {
        Gerenciar.Saindo();
        rodando = false;
    }

    Console.Clear();
    switch(menu)
    {
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