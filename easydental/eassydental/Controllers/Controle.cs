using Microsoft.AspNetCore.Mvc;
using System;
using System.Data.SqlClient;
using static System.Net.WebRequestMethods;

namespace easydental.Controllers
{
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet("/cliente")]
        public IActionResult GetClientes()
        {
            string connstring = "http://localhost:3000/api/cliente";

            try
            {
                using (SqlConnection connection = new SqlConnection(connstring))
                {
                    string query = "SELECT * FROM Cliente"; // Substitua 'NomeDaSuaTabela' pelo nome real da sua tabela
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        // Processar os resultados da consulta (reader) aqui
                        while (reader.Read())
                        {
                            var nome = reader.GetString(0);
                        }

                        reader.Close();
                    }
                }

                // Operação no banco de dados bem-sucedida, retorne uma resposta OK
                return Ok("Dados recuperados com sucesso.");
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção aqui
                return StatusCode(500, $"Erro interno do servidor: {ex.Message}");
            }
        }
    }
}
