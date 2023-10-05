using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;


namespace eassydental.Controllers;


    public class Cliente
    
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
        }


