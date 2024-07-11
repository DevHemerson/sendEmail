using Microsoft.AspNetCore.Mvc;
using SendEmail.Models;

namespace SendEmail.Controllers;
public class EmailController : Controller
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost]
    public async Task<IActionResult> SendEmail(string toEmail, string subject, string message)
    {
        await _emailService.SendEmailAsync(toEmail, subject, message);
        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        return View();
    }
}

