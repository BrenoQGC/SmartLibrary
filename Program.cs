// See https://aka.ms/new-console-template for more information

using SmartLibrary.Controllers;
using SmartLibrary.Entities;

var bookManager = new BookManager();
Console.WriteLine("Bem vindo ao sistema Smart Library!");

while(true)
{
    Console.WriteLine();
    Console.WriteLine("1.Cadastrar um livro");
    Console.WriteLine("2. Consultar todos os livros");
    Console.WriteLine("3. Consultar um livro");
    Console.WriteLine("4. Sair");
    Console.WriteLine();

    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            bookManager.RegisterBook();
            break;
        case "2":
            bookManager.ShowAllBooks(); 
            break;
        case "3":
            Console.WriteLine("Digite o Id do livro");

            try
            {
                var id = Guid.Parse(Console.ReadLine());
                bookManager.GetBook(id);
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Id digitado inválido");
                break;
             }

        case "4":
            return;
        default:
            Console.WriteLine("Opção Inválida, tente novamente");
            break;
    }

}


