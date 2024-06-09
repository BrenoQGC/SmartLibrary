using SmartLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLibrary.Controllers
{
    public class BookManager
    {
        private List<Book> books = new List<Book>();

        public void RegisterBook(string title, string author, string isnb, int publicationYear)
        {
            var book = new Book(title, author, isnb, publicationYear);
            
            books.Add(book);
        }
        public void ShowAllBooks()
        {
            var notRemovedBooks = books.Where(b => b.IsRemoved == false).ToList();

            if (notRemovedBooks.Count == 0) 
            {
                Console.WriteLine("Nenhum livro encontrado!");
                return; 
            }

            foreach (var b in notRemovedBooks)
            {
                Console.WriteLine();
                Console.WriteLine("Id: " + b.Id);
                Console.WriteLine("Título: " + b.Title);
                Console.WriteLine("Autor: " + b.Author);
                Console.WriteLine("Ano de Publicação: " + b.PublicationYear);
                Console.WriteLine("ISNB: " + b.ISBN);
            }
        }

        public void GetBook(Guid id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Livro não foi encontrado!");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Título: " + book.Title);
            Console.WriteLine("Autor: " + book.Author);
            Console.WriteLine("Ano de Publicação: " + book.PublicationYear);
            Console.WriteLine("ISNB: " + book.ISBN);
        }

        public void DeleteBook(Guid id)
        {
            var book = books.FirstOrDefault(x =>x.Id == id);
            if (book == null)
            {
                Console.WriteLine("Livro não encontrado!");
                return;
            }
            book.RemoveBook();
            Console.WriteLine("Livro removido da coleção!");
            return;
        }

    }
}
