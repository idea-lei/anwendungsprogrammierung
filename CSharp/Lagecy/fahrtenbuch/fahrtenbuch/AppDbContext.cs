using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrtenbuch
{
    /// <summary>
    /// erstellen Sie selber unter diesem Projekt eine Datenbank "Database1".
    /// 1. Projektname 'fahrtenbuch' rechts anklicken -> Add -> new Item
    /// 2. unter 'visual c# items' -> data -> service based database (mit Endung .mdf)
    /// 3. doppel klick auf der gerade generierte DB Datei und dann sehen Sie das 'Server Explorer' Panel
    /// 4. auf 'Database1.mdf' in diesem Panel rechts klicken -> modify connection
    /// 5. auf pop-up Panel, unter Advanced, kopieren Sie die untenstehende Connectionstring
    /// </summary>
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbLocation = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\Database1.mdf";
            System.Diagnostics.Debug.WriteLine(dbLocation);
            optionsBuilder.UseSqlServer(@$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbLocation};Integrated Security=True");

        }
        public DbSet<Verbrauch>? Verbrauche { get; set; }
    }
}
