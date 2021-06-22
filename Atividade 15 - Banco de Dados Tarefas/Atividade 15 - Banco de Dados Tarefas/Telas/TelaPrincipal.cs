using System;

namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class TelaPrincipal
    {
        TelaTarefa telaTarefa = new TelaTarefa();
        TelaContato telaContato = new TelaContato();

        public void Executa()
        {
            Menu();
        }

        private void Menu()
        {
            Console.ReadLine();
            Console.WriteLine("Menu Principal");
            Console.WriteLine("Opção 1 - Menu de Tarefas");
            Console.WriteLine("Opção 2 - Menu de Contatos");
            Console.Write("Digite a opção: ");
            string opção = Console.ReadLine();

            if(opção != "1" && opção != "2" && opção != "sair" && opção != "Sair" )
            {
                Console.WriteLine("Opção inválida, por favor,tente novamente");
                Console.ReadLine();
                return;
            }

            if(opção == "Sair" || opção == "sair")
            {
                Environment.Exit(0);
            }

            
            switch (opção)
            {
                case "1": telaTarefa.MenuPrincipal("Tarefa");
                    break;
                case "2": break;                    
            }
        }
    }
}
