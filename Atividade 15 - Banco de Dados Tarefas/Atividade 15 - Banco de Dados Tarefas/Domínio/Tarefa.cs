using System;
using System.Collections.Generic;

namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class Tarefa
    {
        static GeradorID gerador = new GeradorID();

        int id = gerador.GeradorIDTarefa();
        string titulo;
        DateTime dataCriação;
        DateTime dataConclusão;
        int percentualConcluído;
        string prioridade;

        Dictionary<int, string> prioridades = new Dictionary<int, string>()
        {
            {1, "Alta"},
            {2, "Normal" },
            {3, "Baixa" }
        };      


        public Tarefa(string titulo, DateTime dataCriação, DateTime dataConclusão, int percentualConcluído, 
            string prioridade)
        {            
            Titulo = titulo;
            DataCriação = dataCriação;
            DataConclusão = dataConclusão;
            PercentualConcluído = percentualConcluído;
            Prioridade = prioridade;
        }        

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public DateTime DataCriação { get => dataCriação; set => dataCriação = value; }
        public DateTime DataConclusão { get => dataConclusão; set => dataConclusão = value; }
        public int PercentualConcluído { get => percentualConcluído; set => percentualConcluído = value; }
        public string Prioridade { get => prioridade; set => prioridade = value; }

        public override string ToString()
        {
            return $"ID: {Id}, Titulo: {Titulo}, Data de criação: {DataCriação}, Data prevista para finalização: {DataConclusão}, " +
                $"percentual conclúido: {PercentualConcluído}, grau de prioridade: {Prioridade}";
        }

    }
}
