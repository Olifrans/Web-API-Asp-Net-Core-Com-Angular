using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Web_API_Asp_Net_Core__Com_Angular.Models
{
    public class ApiDBContext : DbContext
    {
        public ApiDBContext(DbContextOptions<ApiDBContext> options) : base(options)
        {
        }  
        
        public DbSet<Banco> Banco { get; set; }

        public DbSet<BancoConta> BancoConta { get; set; }
    }
}


//Comandos nuget

//Add-Migration "InitialDB"
//Update-Database

//Add-Migration "InitialCreate"