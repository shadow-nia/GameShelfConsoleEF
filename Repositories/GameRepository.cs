using GameShelf.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace GameShelf.Repositories
{
    public class GameRepository : IRepository<GameEntity>
    {
        private readonly IDbContextFactory<GameshelfContext> _contextFactory;

        public GameRepository(IDbContextFactory<GameshelfContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<GameEntity>> GetAllAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Games.AsNoTracking().ToListAsync();
        }

        public async Task<GameEntity?> GetByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Games.FindAsync(id);
        }

        public async Task<List<GameEntity>?> GetByNameAsync(string name)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Games
                .Where(game => EF.Functions.Like(game.Name, $"%{name}%"))
                .ToListAsync();
        }

        public async Task AddAsync(GameEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            await context.Games.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(GameEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Games.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(GameEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Games.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
