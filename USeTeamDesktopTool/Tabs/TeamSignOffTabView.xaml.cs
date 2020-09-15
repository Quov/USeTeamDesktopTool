using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace USeTeamDesktopTool
{
    /// <summary>
    /// Interaction logic for SaveTabView.xaml
    /// </summary>
    public partial class TeamSignOffTabView : UserControl
    {
        

        public TeamSignOffTabView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {

            //TODO: THIS WILL BE DRIVEN BY A FORM FILLED BY THE USER TO ADD ITEMS FOR THE TEAM TO CHECK
            String[] LANGUAGES_gc = { "Scac", "Master Bill", "Comm Inv No", "Test Item", "Another" };

            System.IO.FileStream fs = new FileStream(@"C:\Users\abuchanan.LII01\Desktop\First PDF document.pdf", FileMode.Create);

            // Create an instance of the document class which represents the PDF document itself.
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF 
            // Writer class using the document and the filestrem in the constructor.

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Add meta information to the document

            document.AddAuthor("Anthony Buchanan");

            document.AddKeywords("USeTeam EDI - Operations Team Testing Signoff");

            document.AddSubject("Document subject - Describing the steps creating a PDF document");

            document.AddTitle("The document title - PDF creation using iTextSharp");

            // Open the document to enable you to write to the document

            document.Open();
            PdfContentByte cb = writer.DirectContent;
            //TextField _text = new TextField(writer, new Rectangle(40, 806, 160, 788), "g1");
            //_text.Alignment = Element.ALIGN_LEFT;
            //_text.Options = TextField.MULTILINE;
            //_text.Text = "abc";
            //writer.AddAnnotation(_text.GetTextField());

            Rectangle _rect;
            PdfFormField _Field1;
            PdfFormField _Field2;

            PdfAppearance[] onOff = new PdfAppearance[3];
            onOff[0] = cb.CreateAppearance(20, 20);
            onOff[0].Rectangle(1, 1, 18, 18);
            onOff[0].Stroke();

            //Pass Checkbox
            onOff[1] = cb.CreateAppearance(20, 20);
            onOff[1].SetRGBColorFill(0, 252, 0);
            onOff[1].Rectangle(1, 1, 18, 18);
            onOff[1].FillStroke();
            onOff[1].MoveTo(1, 1);
            onOff[1].LineTo(19, 19);
            onOff[1].MoveTo(1, 19);
            onOff[1].LineTo(19, 1);
            onOff[1].Stroke();

            //Fail Checkbox
            onOff[2] = cb.CreateAppearance(20, 20);
            onOff[2].SetRGBColorFill(252, 0, 0);
            onOff[2].Rectangle(1, 1, 18, 18);
            onOff[2].FillStroke();
            onOff[2].MoveTo(1, 1);
            onOff[2].LineTo(19, 19);
            onOff[2].MoveTo(1, 19);
            onOff[2].LineTo(19, 1);
            onOff[2].Stroke();

            RadioCheckField _checkbox1;
            RadioCheckField _checkbox2;

            document.Add(new Paragraph("Pass   Fail  Field Name                                  Comments"));

            //Header Line
            cb.MoveTo(20f, 807f);
            cb.LineTo(560f, 807f);
            cb.ClosePath();
            cb.Stroke();

            cb.MoveTo(20f, 791f);
            cb.LineTo(560f, 791f);
            cb.ClosePath();
            cb.Stroke();

            for (int i = 0; i < LANGUAGES_gc.Length; i++)
            {
                _rect = new Rectangle(30, 789 - i * 20, 50, 771 - i * 20);
                _checkbox1 = new RadioCheckField(writer, _rect, LANGUAGES_gc[i], "on");
                _Field1 = _checkbox1.CheckField;
                _Field1.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, "Off", onOff[0]);
                _Field1.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, "On", onOff[1]);
                writer.AddAnnotation(_Field1);

                _rect = new Rectangle(60, 789 - i * 20, 80, 771 - i * 20);
                _checkbox2 = new RadioCheckField(writer, _rect, LANGUAGES_gc[i], "on");
                _Field2 = _checkbox2.CheckField;
                _Field2.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, "Off", onOff[0]);
                _Field2.SetAppearance(PdfAnnotation.APPEARANCE_NORMAL, "On", onOff[2]);
                writer.AddAnnotation(_Field2);

                ColumnText.ShowTextAligned(cb, Element.ALIGN_LEFT, new Phrase(LANGUAGES_gc[i], new Font(Font.FontFamily.HELVETICA, 12)), 90, 775 - i * 20, 0);

                TextField _text = new TextField(writer, new Rectangle(260, 789 - i * 20, 560, 771 - i * 20), "NoteBox");
                _text.Alignment = Element.ALIGN_LEFT;
                _text.Text = "Add Notes here.";
                _text.SetExtraMargin(5, 0);
                writer.AddAnnotation(_text.GetTextField());

                cb.MoveTo(20f, 770 - i * 20);
                cb.LineTo(560f, 770 - i * 20);
                cb.ClosePath();
                cb.Stroke();
            }

            //TODO: ADD LOGIC IN CASE THERE ARE NO ITEMS ENTERED.

            //Column Lines

            cb.MoveTo(20f, 807f);
            cb.LineTo(20f, 807 - (((LANGUAGES_gc.Length + 1) * 20) - 3));
            cb.ClosePath();
            cb.Stroke();

            cb.MoveTo(55f, 807f);
            cb.LineTo(55f, 807 - (((LANGUAGES_gc.Length + 1) * 20) - 3));
            cb.ClosePath();
            cb.Stroke();

            cb.MoveTo(85f, 807f);
            cb.LineTo(85f, 807 - (((LANGUAGES_gc.Length + 1) * 20) - 3));
            cb.ClosePath();
            cb.Stroke();

            cb.MoveTo(259f, 807f);
            cb.LineTo(259f, 807 - (((LANGUAGES_gc.Length + 1) * 20) - 3));
            cb.ClosePath();
            cb.Stroke();

            cb.MoveTo(560f, 807f);
            cb.LineTo(560f, 807 - (((LANGUAGES_gc.Length + 1) * 20) - 3));
            cb.ClosePath();
            cb.Stroke();

            cb = writer.DirectContent;

            document.Close();
            writer.Close();
            fs.Close();
        }
    }
}
