using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardgameDatabase.Data
{
    public class BoardgameDBContext:DbContext
    {
        public BoardgameDBContext(DbContextOptions<BoardgameDBContext> options) : base(options)
        {

        }
        public DbSet<Boardgame> Boardgames { get; set; }    
        public DbSet<Adress> Adresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boardgame>().HasData(
                new Boardgame() { Id = 1, Name="Kemet", Owner="George",Keeper="George",MaxPlayers=5,MinPlayers=2,TagText="Strategy,Area Controll,Dudes on the map,Beginner",ForSale=false}    
            );
        }
    }
}
