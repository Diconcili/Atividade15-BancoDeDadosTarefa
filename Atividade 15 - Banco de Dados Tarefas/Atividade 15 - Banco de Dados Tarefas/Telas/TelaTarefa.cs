using System;

namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class TelaTarefa : TelaBase
    {    

        ControladorCadastroTarefa controlador = new ControladorCadastroTarefa();

        public void MenuPrincipal(string titulo)
        {
            Console.Clear();
            base.MenuPrincipal(titulo);
        }

        public override void MenuRegistro()
        {
            Console.Clear();
            controlador.InserirNovaTarefa(ObterTarefa());
        }

        public override void MenuEdição()
        {
            Console.Clear();
            controlador.VisualizarTarefas();
            controlador.EditarTarefa(SelecionarParaEditar(), ObterEdição());
        }

        public override void MenuExclusão()
        {
            Console.Clear();
            controlador.VisualizarTarefas();
            controlador.ExcluirTarefa(SelecionarParaExcluir());
        }

        public override void MenuVisualização()
        {
            Console.Clear();
            controlador.VisualizarTarefas();
            Console.ReadLine();
        }

        #region MÉTODOS PRIVADOS
        private int SelecionarParaExcluir()
        {
            Console.Write("Selecione o ID da tarefa a ser excluída: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());

            return idSelecionado;
        }

        private int SelecionarParaEditar()
        {
            Console.Write("Insira o ID da tarefa para editar: ");
            int idSelecionado = Convert.ToInt32(Console.ReadLine());
            return idSelecionado;
        }

        private Tarefa ObterTarefa()
        {
            Console.Write("Insira o título da nova tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Insira a data de criação da tarefa: ");
            DateTime dataCriação = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Insira a data prevista para entrega: ");
            DateTime dataConclusão = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Insira o percentual de conclusão da tarefa: ");
            int percentual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o grau de prioridade da tarefa: ");
            string prioridade = Console.ReadLine();

            return new Tarefa(titulo, dataCriação, dataConclusão, percentual, prioridade);
        }

        private Tarefa ObterEdição()
        {
            Console.Write("Insira o título da nova tarefa: ");
            string titulo = Console.ReadLine();

            Console.Write("Insira a data de criação da tarefa: ");
            DateTime dataCriação = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Insira a data prevista para entrega: ");
            DateTime dataConclusão = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Insira o percentual de conclusão da tarefa: ");
            int percentual = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o grau de prioridade da tarefa: ");
            string prioridade = Console.ReadLine();

            return new Tarefa(titulo, dataCriação, dataConclusão, percentual, prioridade);
        }

        
        #endregion
    }
}
