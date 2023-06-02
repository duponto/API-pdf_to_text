namespace PDFToText.Classes;

public class Class 
{
    public string Name { get; set; }
    public DateTime Date { get; set; }

    public Class()
    {
        Date = DateTime.Now;
    }
}
