namespace Atividade_15___Banco_de_Dados_Tarefas
{
    public class GeradorID
    {
        public static int idTarefa = 0;

        public int GeradorIDTarefa()
        {
            return idTarefa++;
        }

    }
}
