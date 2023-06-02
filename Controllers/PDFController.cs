using Microsoft.AspNetCore.Mvc;

namespace PDFToText.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PDFController : ControllerBase
{
    public PDFController(ILogger<PDFController> logger)
    {
    }

    [HttpPost]
    public IActionResult ConvertPDF(IFormFile file)
    {
        return Ok(file.FileName);
    }
}