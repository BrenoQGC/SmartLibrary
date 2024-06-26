﻿// See https://aka.ms/new-console-template for more information

using SmartLibrary.Controllers;
using SmartLibrary.Entities;

var bookManager = new BookManager();
Console.WriteLine("Bem vindo ao sistema Smart Library!");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Cadastrar um livro");
    Console.WriteLine("2. Consultar todos os livros");
    Console.WriteLine("3. Consultar um livro");
    Console.WriteLine("4. Excluir um livro");
    Console.WriteLine("5. Voltar");
    Console.WriteLine();

    var opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            RegisterBookMenu();
            break;

        case "2":
            bookManager.ShowAllBooks();
            break;

        case "3":
            GetBookMenu();
            break;

        case "4":
            DeleteBookMenu();
            break;
        case "5":
            return;

        default:
            Console.WriteLine("Opção Inválida, tente novamente");
            break;
    }

    void RegisterBookMenu()
    {

        Console.WriteLine("Digite o título do livro");
        var title = Console.ReadLine();

        Console.WriteLine("\nInsira o autor do livro");
        var author = Console.ReadLine();

        Console.WriteLine("\nInsira o ISNB do livro");
        var isnb = Console.ReadLine();

        while (true)
        {
            try
            {
                Console.WriteLine("\nInsira o ano de publicação do livro");
                var publicationYear = Convert.ToInt32(Console.ReadLine());
                bookManager.RegisterBook(title, author, isnb, publicationYear);
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Ano inválido");
            }

        }
    }

    void GetBookMenu()
    {
        Console.WriteLine("Digite o Id do livro");
        try
        {
            var id = Guid.Parse(Console.ReadLine());
            bookManager.GetBook(id);

        }
        catch (Exception)
        {
            Console.WriteLine("Id digitado inválido");

        }
        return;
    }
    void DeleteBookMenu()
    {
        Console.WriteLine("Insira o Id do livro que quer exluir");

        try
        {
            var livroId = Guid.Parse(Console.ReadLine());
            bookManager.DeleteBook(livroId);
        }
        catch (Exception)
        {
            Console.WriteLine("Valor digitado é inválido");
        }
        return;
    }
}