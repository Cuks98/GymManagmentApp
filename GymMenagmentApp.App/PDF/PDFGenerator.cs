using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.JSInterop;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GymMenagmentApp.App.PDF
{
    public class PDFGenerator
    {
        private byte[] _data()
        {
            var memoryStream = new MemoryStream();
            float margeLeft = 1.5f;
            float margeRight = 1.5f;
            float margeTop = 1.0f;
            float margeBottom = 1.0f;

            Document pdf = new Document(
                PageSize.A4,
                margeLeft.ToDpi(),
                margeRight.ToDpi(),
                margeTop.ToDpi(),
                margeBottom.ToDpi()
                );

            PdfWriter writer = PdfWriter.GetInstance(pdf, memoryStream);
            pdf.AddTitle("Izvještaj");
            pdf.AddAuthor("GymManagmentApp");

            pdf.Open();

            var title = new Paragraph("Izvještaj transakcija", new Font(Font.HELVETICA, 20, Font.BOLD));
            title.SpacingAfter = 18f.ToDpi();

            pdf.Add(title);
            pdf.Close();

            return memoryStream.ToArray();
        }

        public void DownloadPdfAsync(IJSRuntime js, string filename = "report.pdf")
        {
            //js.InvokeVoidAsync("DownloadPdf", filename, Convert.ToBase64String(_data()));
        }
        public void ViewPdf(IJSRuntime js, string idIFrame)
        {
            js.InvokeVoidAsync("ViewPdf", idIFrame, Convert.ToBase64String(_data()));
        }
        public void ViewPdfNewTab(IJSRuntime js, string filename = "report.pdf")
        {

        }
    }
}