using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ObjCBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tessenger.Client.Data_Db_Contexts
{
    public class Data_Db_Contexts  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            var dbPath = Path.Combine(Microsoft.Maui.Storage.FileSystem.Current.AppDataDirectory, "Data");

            Directory.CreateDirectory(dbPath);
            var Path_ = Path.Combine(Microsoft.Maui.Storage.FileSystem.Current.AppDataDirectory, "Data", "Db.db");
            File.Open(Path_, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite).Close();
            optionsBuilder.UseSqlite($"Filename={Path_}");
        }

       // public DbSet<UserLocal> User { get; set; } = default!;


    }
}
