using System.Data.Entity;
using System.Collections.Generic;

namespace CaddProject.Models
{

    public class Walkin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Walkin> walkinList { get; set; }
    }
    class WalkinContext : DbContext
    {
       public WalkinContext() : base("name = localdb")
        {

        }
        public virtual DbSet<Walkin> Walkins { set; get; }
    }
}