using API_pdf_to_text.Repositories.Interfaces;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System.Text;
using API_pdf_to_text.itext;

namespace API_pdf_to_text.Repositories;

public class PDFService : IPDFService
{
    public string ExtractTextFromPDF(IFormFile file)
    {
        using (PdfReader reader = new PdfReader(file.OpenReadStream()))
        {
            PdfDocument document = new PdfDocument(reader);
            int numberOfPages = document.GetNumberOfPages();
            StringBuilder text = new StringBuilder();

            for (int i = 1; i <= numberOfPages; i++)
            {
                PdfPage page = document.GetPage(i);
                ITextExtractionStrategy strategy = new PDFTextExtractionStrategy();
                string pageText = PdfTextExtractor.GetTextFromPage(page, strategy);
                text.Append(pageText);
            }

            return text.ToString();
        }
    }
}
