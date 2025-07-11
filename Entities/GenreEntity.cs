namespace GameShelf.Entities
{
    public class GenreEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<GameEntity>? Games { get; set; }

    }
}
