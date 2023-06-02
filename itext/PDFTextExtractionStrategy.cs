using iText.Kernel.Pdf.Canvas.Parser.Data;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace API_pdf_to_text.itext;

public class PDFTextExtractionStrategy : LocationTextExtractionStrategy
{
    public override void EventOccurred(IEventData data, EventType type)
    {
        var text = "";
        if (type == EventType.RENDER_TEXT)
        {
            var textRenderInfo = (TextRenderInfo)data;
            text = textRenderInfo.GetText();
        }
        base.EventOccurred(data, type);
    }
}
