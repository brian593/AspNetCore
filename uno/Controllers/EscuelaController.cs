using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using uno.Models;

namespace uno.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        var escuela= new Escuela();
            escuela.AñoFundacion=2005;
            escuela.EscuelaId=Guid.NewGuid().ToString();
            escuela.Nombre="Platzi School";

        return View(escuela);
    }
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}