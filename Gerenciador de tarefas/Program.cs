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
    switch(menu)
    {
        case "0":
        return;

    }
}