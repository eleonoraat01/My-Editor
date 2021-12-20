using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Editor : Form
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Editor(string firstName, string lastName)
        {
            InitializeComponent();
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Editor - {0} {1}", FirstName, LastName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text file | *.txt: *.rtf";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                rtbContent.LoadFile(dlg.FileName, RichTextBoxStreamType.RichText);

                //using (FileStream fs = new FileStream(dlg.FileName, FileMode.OpenOrCreate))
                //{
                //    using (StreamReader sr = new StreamReader(fs))
                //    {
                //        while (!sr.EndOfStream)
                //        {
                //            rtbContent.Text += sr.ReadLine() + Environment.NewLine; //ili "\n" vmesto Environment... za nov red
                //        }
                //    }
                //}
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //properties pri zapametqvaneto na fail-> razshirenie, defauslt rashirenie, zaglavie na prozoreca, default ime na doc-a
            saveDialog.DefaultExt = ".rtf";
            saveDialog.Filter = "Text file | *.txt; *.rtf";
            saveDialog.Title = "Save your file...";
            saveDialog.FileName = "test";

            if (saveDialog.ShowDialog() == DialogResult.OK) 
            {
                //using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.OpenOrCreate))
                //{
                //    using (StreamWriter sw = new StreamWriter(fs))
                //    {
                //        for (int i = 0; i < rtbContent.Lines.Length; i++)
                //        {
                //            sw.WriteLine(rtbContent.Lines[i]);
                //        }
                //    }
                //}

                rtbContent.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
            } 
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbContent.SelectionFont = new Font(rtbContent.Font, FontStyle.Bold);
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem_Click(sender, e);
        }

        private void saveDialog_FileOk(object sender, CancelEventArgs e)
        {
            //tuka nqma nishto
        }
    }
}
