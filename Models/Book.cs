namespace Library.Models;

public class Book
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public Genre Genre { get; set; }
    public double Price { get; set; }
    public int Amount { get; set; }

}
public enum Genre
{
    FICCAO,
    ROMANCE,
    MISTERIO
}
