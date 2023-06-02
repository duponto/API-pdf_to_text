namespace API_pdf_to_text.Repositories.Interfaces;

public interface IPDFService
{
    string ExtractTextFromPDF(IFormFile file);
}
