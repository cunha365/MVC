using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        cliente cliente1 = new cliente(01, "Arthur", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        cliente cliente2 = new cliente(02, "William", "039.618.250-09", "bill@microsoft.com", "Bug");
        cliente cliente3 = new cliente(03, "Ada", "800.777.920-50", "ada@ada.language.com", "Byron");
        cliente cliente4 = new cliente(04, "Linus", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        cliente cliente5 = new cliente(05, "Grace", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        //lista de clientes e atribui os clientes
        List<cliente> ListaClientes = new List<cliente>();
        ListaClientes.Add(cliente1);
        ListaClientes.Add(cliente2);
        ListaClientes.Add(cliente3);
        ListaClientes.Add(cliente4);
        ListaClientes.Add(cliente5);

        ViewBag.ListaClientes = ListaClientes;

        // instancias do tipo fornecedores
        fornecedor fornecedor1 = new fornecedor(01, "C# PET", "14.182.102/0001-80", "c-sharp@pet.org");
        fornecedor fornecedor2 = new fornecedor(02, "Crtl Dog", "15.836.698/0001-57", "crtl@alt.dog.br");
        fornecedor fornecedor3 = new fornecedor(03, "Bootspet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        fornecedor fornecedor4 = new fornecedor(04, "Tik Tok", "87.945.350/0001-09", "noisnamidia@tiktokdogs.uk");
        fornecedor fornecedor5 = new fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        //lista de fornecedores e atribui os fornecedores
        List<fornecedor> ListaFornecedores = new List<fornecedor>();
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);

        ViewBag.ListaFornecedores = ListaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
