using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class ControladorCadastroTarefa
    {
       public List<Tarefa> tarefasCadastradas = new List<Tarefa>();

        public void VisualizarTarefas()
        {
            if(tarefasCadastradas.Count() == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                Console.ReadLine();
                return;
            }



            foreach(Tarefa tarefa in tarefasCadastradas)
            {
                Console.WriteLine(tarefa);
            }
        }

        public void ExcluirTarefa(int idSelecionado)
        {           
            string endereçoDBTarefa = DefiniçãoDeEndereçoDeConexão();

            SqlConnection conexãoComBanco = AberturaDeConexão(endereçoDBTarefa);

            ExecuçãoDeExclusão(idSelecionado, conexãoComBanco, tarefasCadastradas);

            EncerramentoDeConexão(conexãoComBanco);
        }   

        public void EditarTarefa(int idSelecionado, Tarefa tarefaEditada)
        { 
            string endereçoDBTarefa = DefiniçãoDeEndereçoDeConexão();

            SqlConnection conexãoComBanco = AberturaDeConexão(endereçoDBTarefa);

            ExecuçãoDeEdição(idSelecionado, tarefaEditada, conexãoComBanco, tarefasCadastradas);

            EncerramentoDeConexão(conexãoComBanco);
        }              

        public void InserirNovaTarefa(Tarefa novaTarefa)
        {     
            string endereçoDBTarefa = DefiniçãoDeEndereçoDeConexão();

            SqlConnection conexãoComBanco = AberturaDeConexão(endereçoDBTarefa);

            ExecuçãoDeInserção(novaTarefa, conexãoComBanco, tarefasCadastradas);

            EncerramentoDeConexão(conexãoComBanco);
        }

        #region MÉTODOS PRIVADOS
        private static void EncerramentoDeConexão(SqlConnection conexãoComBanco)
        {
            conexãoComBanco.Close();
        }

        private static void ExecuçãoDeInserção(Tarefa novaTarefa, SqlConnection conexãoComBanco, List<Tarefa> tarefasCadastradas)
        {
            SqlCommand comandoInserção = new SqlCommand();
            comandoInserção.Connection = conexãoComBanco;

            string sqlInserção = ScriptInserção();

            comandoInserção.CommandText = sqlInserção;
            comandoInserção.Parameters.AddWithValue("TITULO", novaTarefa.Titulo);
            comandoInserção.Parameters.AddWithValue("DATACRIAÇÃO", novaTarefa.DataCriação);
            comandoInserção.Parameters.AddWithValue("DATACONCLUSÃO", novaTarefa.DataConclusão);
            comandoInserção.Parameters.AddWithValue("PERCENTUALCONCLUÍDO", novaTarefa.PercentualConcluído);            

            tarefasCadastradas.Add(novaTarefa);            

            comandoInserção.ExecuteNonQuery();
        }

        private static void ExecuçãoDeEdição(int idSelecionado, Tarefa tarefaEditada, SqlConnection conexãoComBanco, List<Tarefa> tarefasCadastradas)
        {
            SqlCommand comandoEdição = new SqlCommand();
            comandoEdição.Connection = conexãoComBanco;

            string sqlEdição = ScriptEdição();

            comandoEdição.CommandText = sqlEdição;
            comandoEdição.Parameters.AddWithValue("TITULO", tarefaEditada.Titulo);
            comandoEdição.Parameters.AddWithValue("DATACRIAÇÃO", tarefaEditada.DataCriação);
            comandoEdição.Parameters.AddWithValue("DATACONCLUSÃO", tarefaEditada.DataConclusão);
            comandoEdição.Parameters.AddWithValue("PERCENTUALCONCLUÍDO", tarefaEditada.PercentualConcluído);
            comandoEdição.Parameters.AddWithValue("ID", idSelecionado);

            EditarNaLista(idSelecionado, tarefaEditada, tarefasCadastradas);

            comandoEdição.ExecuteNonQuery();
        }

        private static void EditarNaLista(int idSelecionado, Tarefa tarefa, List<Tarefa> tarefasCadastradas)
        {
            for (int i = 0; i < tarefasCadastradas.Count; i++)
            {
                if (tarefasCadastradas[i].Id == idSelecionado)
                    tarefasCadastradas[i] = tarefa;
                break;
            }
        }

        private static void ExecuçãoDeExclusão(int idSelecionado, SqlConnection conexãoComBanco, List<Tarefa> tarefasCadastradas)
        {
            SqlCommand comandoExclusão = new SqlCommand();
            comandoExclusão.Connection = conexãoComBanco;

            string sqlEdição = ScriptExclusão();

            comandoExclusão.CommandText = sqlEdição;
            comandoExclusão.Parameters.AddWithValue("ID", idSelecionado);

            tarefasCadastradas.Remove(tarefasCadastradas.Find(x => x.Id == idSelecionado));

            comandoExclusão.ExecuteNonQuery();
        }

        private static string ScriptExclusão()
        {
            return @"DELETE FROM TBTAREFAS 
	                                WHERE 
		                         [ID] = @ID";
        }

        private static string ScriptEdição()
        {
            return @"UPDATE TBTAREFAS 
	                                        SET	
		                               [TITULO] = @TITULO,
                                       [DATACRIAÇÃO] = @DATACRIAÇÃO,
		                               [DATACONCLUSÃO] = @DATACONCLUSÃO,
	                                   [PERCENTUALCONCLUÍDO] = @PERCENTUALCONCLUÍDO
	                                        WHERE 
		                                [ID] = @ID";
        }

        private static string ScriptInserção()
        {
            return @"INSERT INTO TBTAREFAS
                                (
	                                [TITULO], 
	                                [DATACRIAÇÃO], 
	                                [DATACONCLUSÃO], 
	                                [PERCENTUALCONCLUÍDO]
                                )
                                    VALUES 
                                (
	                                @TITULO, 
	                                @DATACRIAÇÃO, 
	                                @DATACONCLUSÃO, 
	                                @PERCENTUALCONCLUÍDO
                                )";
        }

        private static SqlConnection AberturaDeConexão(string endereçoDBTarefa)
        {
            SqlConnection conexãoComBanco = new SqlConnection(endereçoDBTarefa);
            conexãoComBanco.Open();
            return conexãoComBanco;
        }

        private static string DefiniçãoDeEndereçoDeConexão()
        {
            return @"Data Source=(LocalDb)\MSSqlLocalDB;Initial Catalog=DBTarefas;Integrated Security=True;Pooling=False";
        }
        #endregion
    }    
}
