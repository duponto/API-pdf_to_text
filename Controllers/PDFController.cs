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
    public IActionResult ConvertPDF(IFormFile doc)
    {
        if (doc.FileName.EndsWith(".pdf"))
        {
            string textInside = _pdfService.ExtractTextFromPDF(doc);
            return Ok(textInside);
        }
        return BadRequest("Arquivo não é um PDF");
    }
}