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
    public partial class ImageForm : Form
    {
        public ImageForm(Image ? img)
        {
            InitializeComponent();
            if (img != null ) pictureBox1.Image  = img;
        }
    }
}
