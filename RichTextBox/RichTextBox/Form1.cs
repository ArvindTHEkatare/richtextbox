using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {   //initlisera och anropa controls
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {   //delen som krävs, för varje fontfamily då(är också en for loop)
            for (int i = 0; i < FontFamily.Families.Length; i++)
            {   //adderar alla fonts  till cmbfont (dropdown menyn) 
                cmbFont.Items.Add(FontFamily.Families[i].Name);
            }
            //default värde/start värdena
            cmbFont.SelectedItem = "Arial";
            numFontSize.Value = 12;
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {   //när en viss val väljs, använda den
            AnvändTextÄndringar();
        }

        private void numFontSize_ValueChanged(object sender, EventArgs e)
        {//när en viss val väljs, använda den
            AnvändTextÄndringar();
        }
        //för själva bold biten vid click
        private void btnBold_Click(object sender, EventArgs e)
        {   //om selectionfont/valet är inte null:
            if (rtbText.SelectionFont != null)
            {   //lagrar current style (stylen just nu) från rich text box
                FontStyle närvarandestyl = rtbText.SelectionFont.Style;
                //nya style är den gamla men bold bara
                FontStyle nyStyle = närvarandestyl ^ FontStyle.Bold;
                //lägger till den bold för texten i richtextbox
                rtbText.SelectionFont = new Font(rtbText.SelectionFont.FontFamily, rtbText.SelectionFont.Size, nyStyle);
            }
            else
            {//om den är null, (om man har inte valt en viss font,) default är:
                rtbText.SelectionFont = new Font("Arial", 12, FontStyle.Bold);
            }
        }

        //samma sak gör vi har (samma princip som förra) (som bold kodsnutt)
        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                FontStyle närvarandestyl = rtbText.SelectionFont.Style;
                FontStyle nyStyle = närvarandestyl ^ FontStyle.Italic;
                rtbText.SelectionFont = new Font(rtbText.SelectionFont.FontFamily, rtbText.SelectionFont.Size, nyStyle);
            }
            else
            {
                rtbText.SelectionFont = new Font("Arial", 12, FontStyle.Italic);
            }
        }
        //samma sak gör vi har (samma princip som förra) (som bold kodsnutt)
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont != null)
            {
                FontStyle närvarandestyl = rtbText.SelectionFont.Style;
                FontStyle nyStyle = närvarandestyl ^ FontStyle.Underline;
                rtbText.SelectionFont = new Font(rtbText.SelectionFont.FontFamily, rtbText.SelectionFont.Size, nyStyle);
            }
            else
            {
                rtbText.SelectionFont = new Font("Arial", 12, FontStyle.Underline);
            }
        }
        //btn align left (horsiontellt)
        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Left;
        }
        //samma sak här men center
        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Center;
        }
        //till right 
        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            rtbText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void AnvändTextÄndringar()
        {   //omvandlar selectect font till string
            string valtFont = cmbFont.SelectedItem.ToString();
            float valtStorlek = (float)numFontSize.Value;
            //fö att säkerställa att storleken är 12 (default)
            if (valtStorlek <= 0)
            {
                valtStorlek = 12;
            }
            //om selectionfont är inte null
            if (rtbText.SelectionFont != null)
            {//sama princip för bold men
                FontStyle närvarandestyl = rtbText.SelectionFont.Style;
                //font är nu då valtfont, med valt storlek och närvarande style
                rtbText.SelectionFont = new Font(valtFont, valtStorlek, närvarandestyl);
            }
            else
            { // om ingen font är vald, skapa en ny font med de valda inställningarna
                rtbText.SelectionFont = new Font(valtFont, valtStorlek);
            }
        }

        private void btnColorPalette_Click(object sender, EventArgs e)
        {
            // en color dialog instans skapas
            ColorDialog colorDialog = new ColorDialog();

            // visa dialogen
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //om användaren väljer en viss färg, använd den
                rtbText.SelectionColor = colorDialog.Color;
            }
        }
        //för bullet listor
        private void btnBulletedList_Click(object sender, EventArgs e)
        {
            rtbText.SelectionBullet = !rtbText.SelectionBullet; // toggle för punkter
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {//en zoomfaktor, super användbart
            rtbText.ZoomFactor = trackBarZoom.Value / 100.0f;
        }
        //5 l.e uppåt för superscript
        private void btnSuperscript_Click(object sender, EventArgs e)
        {
            rtbText.SelectionCharOffset = 5;
        }
        //5 l.e neråt för subscript
        private void btnSubscript_Click(object sender, EventArgs e)
        {
            rtbText.SelectionCharOffset = -5;
        }
        //behövde söka på hur man gör men (kunde inte innna), btn search:
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // spara sökordet från fältet
            string sökord = txtSearch.Text.Trim();

            // kolla om den är inte tom
            if (!string.IsNullOrEmpty(sökord))
            {
                // sökning tar plats och ser till om den kan hita
                FindAndHighlightWord(sökord);
            }
            else
            {
                //om fältet är tom visa:
                MessageBox.Show("Vänligen mata in något du vill söka, tack", "Sök error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //sök och visa ord
        private void FindAndHighlightWord(string sökord)
        {
            // börja söka från början
            int startIndex = 0;

            rtbText.SelectionBackColor = Color.White; // Optional

            // sök för alla instanser av ordet
            while (startIndex < rtbText.TextLength)
            {
                //fortäsätter hitta om och om
                int ordIndex = rtbText.Text.IndexOf(sökord, startIndex, StringComparison.OrdinalIgnoreCase);

                // om ordet/texten hittas, visa den:
                if (ordIndex >= 0)
                {
                    // ¨väljer ordet och ändrar dess bakgrundfärg
                    rtbText.Select(ordIndex, sökord.Length);
                    rtbText.SelectionBackColor = Color.Yellow; // gul är en bra highlight färgd

                    // uppdaterar start index och fortsätter hitta samma ord
                    startIndex = ordIndex + sökord.Length;
                }
                else
                {
                    // om det gick ine hitta mer av samma ord/text, stoppas loopen
                    break;
                }
            }

            // om texten fanns inte det i richboxen
            if (startIndex == 0)
            {
                MessageBox.Show("Kunde inte hitta det du sökte på", "Sök resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // skapar en spardialog
            SaveFileDialog sparfildialog = new SaveFileDialog();

            // filter för txt och rtf filer
            sparfildialog.Filter = "RTF Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt";

            //default är rtx
            sparfildialog.DefaultExt = "rtf";

            // visa dialogen
            if (sparfildialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtension = Path.GetExtension(sparfildialog.FileName).ToLower();

                //spara baserad på filändelse
                if (fileExtension == ".rtf")
                {
                    rtbText.SaveFile(sparfildialog.FileName, RichTextBoxStreamType.RichText); // spara som en rtf
                }
                else if (fileExtension == ".txt")
                {
                    rtbText.SaveFile(sparfildialog.FileName, RichTextBoxStreamType.PlainText); // spara som en txt
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //sparar ToolTip() som toolTip.
            ToolTip toolTip = new ToolTip();

            //Skriver en tooltip för varje sak
            toolTip.SetToolTip(btnBold, "Fet: Gör den markerade texten fet");
            toolTip.SetToolTip(btnItalic, "Kursiv: Gör den markerade texten kursiv");
            toolTip.SetToolTip(btnUnderline, "Understruken: Understryker den markerade texten");

            toolTip.SetToolTip(btnAlignLeft, "Vänsterjustera: Justerar texten till vänster");
            toolTip.SetToolTip(btnAlignCenter, "Centrera: Centrerar texten");
            toolTip.SetToolTip(btnAlignRight, "Högerjustera: Justerar texten till höger");

            toolTip.SetToolTip(btnColorPalette, "Färgpalett: Välj en färg för texten");
            toolTip.SetToolTip(btnBulletedList, "Punktlista: Skapar en punktlista från den markerade texten");

            toolTip.SetToolTip(btnSubscript, "Underskrift: Gör den markerade texten till underskrift (t.ex. x₂)");
            toolTip.SetToolTip(btnSuperscript, "Upphöjd: Gör den markerade texten till upphöjd (t.ex. x²)");

            toolTip.SetToolTip(txtSearch, "Skriv in ett sökord här");
            toolTip.SetToolTip(btnSearch, "Klicka för att söka efter det angivna ordet");

            toolTip.SetToolTip(trackBarZoom, "Justera zoomfaktorn för texten");
            toolTip.SetToolTip(rtbText, "Textfält för inmatning eller visning");
            toolTip.SetToolTip(btnSave, "Klicka för att spara innehållet i RTF- eller TXT-format");

            toolTip.SetToolTip(txtSearch, "Skriv in ordet du vill söka efter här");
            toolTip.SetToolTip(cmbFont, "Välj en fontstil från rullgardinsmenyn");
            toolTip.SetToolTip(numFontSize, "Välj den teckensnittsstorlek du vill ha för texten");

            
            toolTip.InitialDelay = 500; //  tid innan varje tooltip visas på skärmen
            toolTip.AutoPopDelay = 5000; // Tid för varje tooltip (tooltip duration tip)
            toolTip.ReshowDelay = 200;  // tid emellan olika tooltips
        }


    }
}
