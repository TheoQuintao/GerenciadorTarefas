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
            try
            {
                Tarefa TarefaCorrespondente = Tarefa.TarefasList.Find(t => t.ID == id);
                TarefaCorrespondente.Concluida = true;
                Formatação.Cor(ConsoleColor.Green,ConsoleColor.Black);
                Console.WriteLine("\nTarefa Concluida!!");
                Console.ResetColor();
                Console.Clear();
                ListarTarefas();
            }catch{}
            
        }
        public static void ListarTarefas()
        {
            Formatação.Cor(ConsoleColor.Yellow,ConsoleColor.Black);
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
            Console.ResetColor();
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
            Console.Write("\nDigite o ID da Tarefa: ");
            if(!int.TryParse(Console.ReadLine(), out int id))
            {
                Formatação.Cor(ConsoleColor.White,ConsoleColor.Red);
                Console.WriteLine("Valor Invalido!!!");
                Thread.Sleep(1500);
                goto Return1;
            }
            return id;
        }
        public static string PegarDescrição()
        {
            return1:
            Console.Write("Dê uma descrição para a tarefa: ");
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
    }
}