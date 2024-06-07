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

        public void RegisterBook()
        {
            var book = new Book();

            Console.WriteLine("Digite o título do livro");
            book.Title = Console.ReadLine();

            Console.WriteLine("\nInsira o autor do livro");
            book.Autor = Console.ReadLine();

            Console.WriteLine("\nInsira o ISNB do livro");
            book.ISBN = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("\nInsira o ano de publicação do livro");
                    book.PublicationYear = Convert.ToInt32(Console.ReadLine());
                    books.Add(book);
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ano inválido");
                }

            }
        }
        public void ShowAllBooks()
        {
            foreach (var b in books)
            {
                Console.WriteLine("Id: " + b.Id);
                Console.WriteLine("Título: " + b.Title);
                Console.WriteLine("Autor: " + b.Autor);
                Console.WriteLine("Ano de Publicação: " + b.PublicationYear);
                Console.WriteLine("ISNB: " + b.ISBN);
                Console.WriteLine();
            }
        }

        public void GetBook(Guid id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                Console.WriteLine("Livro não foi encontrado");
                return;
            }

            Console.WriteLine("Título: " + book.Title);
            Console.WriteLine("Autor: " + book.Autor);
            Console.WriteLine("Ano de Publicação: " + book.PublicationYear);
            Console.WriteLine("ISNB: " + book.ISBN);
        }

    }
}
