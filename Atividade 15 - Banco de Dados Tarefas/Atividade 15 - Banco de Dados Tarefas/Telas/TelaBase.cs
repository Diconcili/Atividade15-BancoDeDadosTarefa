using System;

namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class TelaBase
    {
        string titulo;

        virtual public void MenuPrincipal(string titulo)
        {
            Console.WriteLine($"Tela de {titulo}s");
            Console.WriteLine($"Opção 1 - Registrar nova {titulo}");
            Console.WriteLine($"Opção 2 - Editar {titulo}");
            Console.WriteLine($"Opção 3 - Excluir {titulo}");
            Console.WriteLine($"Opção 4 - Visualizar {titulo}s");
            int opção = Convert.ToInt32(Console.ReadLine());

            if(opção != 1 && opção != 2 && opção != 3 && opção != 4)
            {
                Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadLine();
                return;
            }

            switch (opção)
            {
                case 1: MenuRegistro();
                        break; 
                case 2: MenuEdição();
                    break;
                case 3: MenuExclusão();
                        break;
                case 4: MenuVisualização();
                        break;
            }
        }

        virtual public void MenuRegistro()
        {

        }

        virtual public void MenuEdição()
        {

        }

        virtual public void MenuExclusão()
        {

        }

        virtual public void MenuVisualização()
        {

        }
    }
}
