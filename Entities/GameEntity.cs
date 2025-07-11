namespace GameShelf.Entities
{
    public class GameEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Description { get; set; }

        //public int GenreId { get; set; }
        //public GenreEntity? Genre { get; set; }
        //public string? Abrakadabra { get; set; }

        public string? Genre { get; set; }

        public double Rating { get; set; }

        public decimal Price { get; set; }

    }
}
