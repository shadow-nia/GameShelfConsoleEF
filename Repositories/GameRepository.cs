using GameShelf.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameShelf.Repositories
{
    public class GameRepository : IRepository<GameEntity>
    {
        private readonly GameshelfContext _context;
        private readonly DbSet<GameEntity> _entities;
        public GameRepository(GameshelfContext context) { 
            
            _context = context;
            _entities = context.Set<GameEntity>();
        }

        public async Task AddAsync(GameEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Delete(GameEntity entity)
        {
             _entities.Remove(entity);
        }
        public async Task<IEnumerable<GameEntity>> GetAllAsync()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public IQueryable<IGrouping<string?, GameEntity>> GetAllByGroup()
        {
            return _entities.GroupBy(game => game.Genre);
        }
        public async Task<GameEntity?> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<List<GameEntity>?> GetByNameAsync(string name)
        {
            return await _entities
                .Where(game => EF.Functions.Like(game.Name, $"%{name}%"))
                .ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(GameEntity entity)
        {
            _entities.Update(entity);
        }
    }
}
