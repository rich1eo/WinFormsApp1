using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void ButtonPush(object sender, EventArgs e)
        {
            string outputText = "";

            string pattern = @reg.Text;
            Regex rg = new Regex(pattern);
            MatchCollection matchedAuthors = rg.Matches(textIn.Text);
            
            outputText += "Number of characters found: " + matchedAuthors.Count+ "\n";
            for (int count = 0; count < matchedAuthors.Count; count++)  
                outputText += matchedAuthors[count].Value + ((matchedAuthors.Count-1 == count) ? "": ", ") ;  
            textOut.Text = outputText;
        }
        
    }
}