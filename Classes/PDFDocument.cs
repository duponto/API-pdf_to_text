namespace PDFToText.Classes;

public class PDFDocument
{
    public long Id { get; set; }
    public string Name { get; set; }
    public byte PDFData{ get; set; }
    public DateTime Date { get; set; }

    public PDFDocument()
    {
        Date = DateTime.Now;
    }
}
