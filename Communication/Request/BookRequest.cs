using Library.Models;

namespace Library.Communication.Request;

public record BookRequest(
    Guid Id,
    string Title, 
    string Author,
    Genre Genre,
    double Price,
    int Amount  
);
