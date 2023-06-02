using API_pdf_to_text.Repositories;
using API_pdf_to_text.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace PDFToText.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class PDFController : ControllerBase
{
    private IPDFService _pdfService;
    public PDFController()
    {
        _pdfService = new PDFService();
    }

    [HttpPost]
    public IActionResult ConvertPDF(IFormFile file)
    {
        string textInside = _pdfService.ExtractTextFromPDF(file);
        return Ok(textInside);
    }
}