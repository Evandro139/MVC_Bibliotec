using Microsoft.AspNetCore.Mvc;

namespace Bibliotec_MVC_DEV.Controllers
{
    public class LivroController : Controller
    {  
        private readonly ILivroService _LivroService;

        public LivroController (ILivroService LivroService)
        {
            _livroService = livroService;
        }
       
        public async Task <IActionResult> Index()
        {
            string? adminSessao = HttpContext.Session.GetString("Admin");

            if (adminSessao == null)
            {
                return RedirectToAction("Index", "Login");
            }

            ViewBag.Admin = adminSessao == "True" || adminSessao == "true";

            var livros = await _LivroService.BuscarLivrosComCatAsync();

            return View(livros);
        }
    }
}