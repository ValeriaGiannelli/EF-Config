using System;

using System.Linq;

//per database
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Config
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo un'istanza della classe e specifico ilnome del DB
            //DataContext context = new DataContext("DB_EF_Config");

            //al posto del nome del DB posso mettere 'name = nameInAppConfig' e mi prende la stringa di connessione relativa 
            DataContext context = new DataContext("name = AppConnectionString");

            //usiamo context per fare la query al DB
            //questa query mi restituisce tutti gli User nella Users Table
            var myUsers = context.Users.ToList();
            Console.WriteLine("Done Reading");
            Console.Read();
        }
    }

    //classe responsabile per connettere l'applicazione al DB
    class DataContext : DbContext
    {
        //rappresenta una collezione di oggetti di tipo User (rappresenta una tabella nel db) -> si possono fare le CRUD
        public DbSet<User> Users { get; set; }

        //costruttore - posso modificare il nome. Se non lo specifichi puoi cambiarlo in appConfig: Initial Catalog=MyNewDatabase
        public DataContext(string name):base(name)
        {

        }
    }



    //creiamouna classe che definiràun'entità
    [Table("Users")] //imposto il nome della tabella
    class User
    {
        [Key] //imposta questa colonna come PK
        public int Id { get; set; }

        [MaxLength(50)]
        [Required] //campo obbligatorio - NOT NULL
        public string Name { get; set; }

        //con questo attributo posso cambiare il numero del varchar
        [MaxLength(50)]
        public string Address { get; set; }
    }
}
