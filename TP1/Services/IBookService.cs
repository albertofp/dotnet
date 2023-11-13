using TP1.Models;

namespace TP1.Services;

public interface IBookService
{
   IList<Book> GetAll();
   Book Get(string id);
   void Create(Book book);
}