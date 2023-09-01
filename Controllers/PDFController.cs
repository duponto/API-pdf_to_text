using API_pdf_to_text.Services;
using API_pdf_to_text.Services.Interfaces;
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
        return doc.FileName.EndsWith(".pdf") ? 
            Ok(_pdfService.ExtractTextFromPDF(doc)) : 
            BadRequest("Arquivo não é um PDF");
    }
}