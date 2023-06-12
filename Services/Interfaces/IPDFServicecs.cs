namespace API_pdf_to_text.Services.Interfaces;

public interface IPDFService
{
    string ExtractTextFromPDF(IFormFile file);
}
