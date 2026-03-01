using CetStudentBook.Data;
using CetStudentBook.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace CetStudentBook.Controllers;

public class BookListController : Controller
{
    private ApplicationDbContext context;

    public BookListController(ApplicationDbContext dbContext)
    {
        context = dbContext;
    }
    public IActionResult Index()
    {
        
        var  books = context.Books.ToList();
        return View(books);
    }
}