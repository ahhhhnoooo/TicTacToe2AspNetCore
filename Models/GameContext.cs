using Microsoft.EntityFrameworkCore;

namespace TicTacToe2ASPNETCore.Models
{
    public class GameContext : DbContext
    {
        public GameContext (DbContextOptions<GameContext> options)
            : base(options)
        {
        }

        public DbSet<TicTacToe2ASPNETCore.Models.Game> Game { get; set; }
    }
}