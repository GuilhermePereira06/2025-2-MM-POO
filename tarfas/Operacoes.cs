using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class Operacoes
{
    private string connectionString =
    @"server=phpmyadmin.uni9.marize.us;User ID=user_poo;password=S3nh4!F0rt3;database=user_poo;";

    public int Criar(Tarefa tarefa)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao) 
                           VALUES (@nome, @descricao, @dataCriacao, @status, @dataExecucao);
                           SELECT LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }

    public void Alterar(Tarefa tarefa)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"UPDATE tarefa 
                           SET nome = @nome, 
                               descricao = @descricao, 
                               dataCriacao = @dataCriacao, 
                               status = @status, 
                               dataExecucao = @dataExecucao
                           WHERE id = @id;";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);
                cmd.Parameters.AddWithValue("@id", tarefa.Id);

                int linhasAfetadas = cmd.ExecuteNonQuery();
                Console.WriteLine($"Tarefa alterada com sucesso. Linhas afetadas: {linhasAfetadas}");
            }
        }
    }

    public void Excluir(int id)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();
            string sql = @"DELETE FROM tarefa WHERE id = @id;";

            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@id", id);

                int linhasAfetadas = cmd.ExecuteNonQuery();
                Console.WriteLine($"Tarefa excluída com sucesso. Linhas afetadas: {linhasAfetadas}");
            }
        }
    }
}
