using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Editor
{
    public partial class SectionAdjust : Form
    {
        public bool IsRandom { get; set; }
        public int QToAsk { get; set; }
        public string Descr { get; set; }

        internal SectionAdjust(Section sec)
        {
            InitializeComponent();
            checkBox_isRandom.Checked = sec.isRandom;
            textBox_Description.Text = sec.Description;
            label_qCount.Text = sec.Questions.Count.ToString();
            numericUpDown_QToAsk.Maximum = sec.Questions.Count;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            IsRandom = checkBox_isRandom.Checked;
            QToAsk = (int) numericUpDown_QToAsk.Value;
            Descr = textBox_Description.Text;
            this.Close();
        }
    }
}
