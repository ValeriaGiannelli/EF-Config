using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class DataContext : DbContext
    {
        //creiamo un modello che verrà usato per la comunicazione con il DB:User tra le parentesi è per specificare il tipo di dato
        public DbSet<User> Users { get; set; }
        
        //costruttore
        public DataContext()
        {

        }
    }

    //creiamouna classe che definiràun'entità
    class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
