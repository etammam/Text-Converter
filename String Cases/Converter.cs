using System;
using System.Windows.Forms;
using System.Globalization;
using MaterialSkin;

namespace String_Cases
{
    public partial class Converter : MaterialSkin.Controls.MaterialForm
    {
        public Converter()
        {
            InitializeComponent();
            Initial();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
        private void Initial()
        {
            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }
        private string CaseStatues()
        {
            string Result = null;
            if (btnLower.Checked)
            {
                Result = "Lower";
            }
            else if (btnTitle.Checked)
            {
                Result = "Title";
            }           
            else if(btnUpper.Checked)
            {
                Result = "Upper";
            }
            else
            {
                CaseMessage msg = new CaseMessage();
                msg.Show();
            }
            return Result;
        }
        private string Convert(string Text)
        {
            TextInfo converter = new CultureInfo("en-US", false).TextInfo;
            string Case = CaseStatues();           
            string Result = null;
            switch (Case)
            {
                case "Upper":
                    Result = converter.ToUpper(Text);
                    break;
                case "Lower":
                    Result = converter.ToLower(Text);
                    break;
                case "Title":
                    Result = converter.ToTitleCase(Text);
                    break;
                case "":
                    Result = "Please Select Case";
                    break;
            }
            return Result;
        }
        private string Convert(string Text,string Case)
        {
            TextInfo converter = new CultureInfo("en-US", false).TextInfo;
            string Result = null;
            switch (Case)
            {
                case "Upper":
                    Result = converter.ToUpper(Text);
                    break;
                case "Lower":
                    Result = converter.ToLower(Text);
                    break;
                case "Title":
                    Result = converter.ToLower(Text);
                    break;
                case "":
                    Result = "Please Select Case";
                    break;
            }
            return Result;
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert(textBox1.Text);
        }

        private void toUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text =  Convert(textBox1.Text, "Upper");
        }

        private void toTitleCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert(textBox1.Text, "Title");
        }

        private void toLowerCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert(textBox1.Text, "Lower");
        }

        private void convertTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert(textBox1.Text);
        }
    }
}
