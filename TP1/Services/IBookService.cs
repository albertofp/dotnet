using System.Collections.Generic;
using TP1.Models;

namespace TP1.Services;

public interface IBookService
{
   IList<Book> GetAll();
   Book Get(string id);
   void Create(Book book);
   void Edit(Book book);
   void Delete(string id);
}