using Tarefas;
using Layout;

namespace GerenciadorTarefas
{
    class Gerenciar{
        public static void AdicionarTarefa(String Descrição)
        { 
            try
            {
                Tarefa.TarefasList.Add(new Tarefa {Nome = Descrição, ID = ++Tarefa.Contador, Concluida = false});
                Console.Clear();
                ListarTarefas();
                Formatação.Cor(ConsoleColor.Green,ConsoleColor.Black);
                Console.WriteLine("\nTarefa adicionada com sucesso!");
                Console.ResetColor();
            }catch{
                Console.Clear();
                ListarTarefas();
            }
        }
        public static void ConcluirTarefa(int id)
        {
            try
            {
                Tarefa.TarefasList.Find(t => t.ID == id).Concluida=true;
                Console.Clear();
                ListarTarefas();
                Formatação.Cor(ConsoleColor.Green,ConsoleColor.Black);
                Console.WriteLine("\nTarefa concluída!");
                Console.ResetColor();
            }catch{
                Console.Clear();
                ListarTarefas();
            }
        }
        public static void ListarTarefas()
        {
            Formatação.Cor(ConsoleColor.Yellow,ConsoleColor.Black);
            Console.WriteLine("Tarefas:");
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
                catch{
                    
                } 
            }
            Console.ResetColor();
        }
        public static void RemoverTarefa(int id)
        {
            try
            {
                Tarefa Remover = Tarefa.TarefasList.Find(t => t.ID == id);
                Tarefa.TarefasList.Remove(Remover);
                Console.Clear();
                ListarTarefas();
                Formatação.Cor(ConsoleColor.Red,ConsoleColor.Black);
                Console.WriteLine("\nTarefa removida com sucesso!");
                Console.ResetColor(); 
            }catch{
                Console.Clear();
                ListarTarefas();
            }
        }
        public static int PegarID()
        {
            Return1:
            Console.Clear();
            ListarTarefas();
            Console.Write("\nDigite o ID da Tarefa: ");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Formatação.Cor(ConsoleColor.Red,ConsoleColor.Black);
                Console.WriteLine("Valor Invalido!!!");
                Console.ResetColor();
                Thread.Sleep(1500);
                goto Return1;
            }
            return id;
        }
        public static string PegarDescrição()
        {
            return1:
            Console.Clear();
            Console.Write("Digite a descrição da tarefa: ");
            string descrição = Console.ReadLine()??"";
            Console.Write($"Deseja confirmar a descrição: {descrição}\nResponda com sim ou não: ");
            string confirmar = Console.ReadLine()?.ToLower()??"";
            switch(confirmar)
            {
                case "sim":
                return descrição;

                case "não":
                case "nao":
                default:
                goto return1;
            }
        }
        public static void Saindo()
        {
            Formatação.Cor(ConsoleColor.Red,ConsoleColor.Black);
            Console.WriteLine("\n Saindo...");
            Thread.Sleep(1000);
            Console.ResetColor();
        }
    }
}