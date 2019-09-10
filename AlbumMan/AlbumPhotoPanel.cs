using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumMan
{
    public partial class AlbumPhotoPanel : UserControl
    {
        public AlbumPhotoPanel()
        {
            InitializeComponent();
            
        }

        public Image Image
        {
            set => pictureBoxPhoto.Image = value;
        }

        public string Title
        {
            get => textBoxTitle.Text;
            set => textBoxTitle.Text = value;
        }

        public string Description
        {
            get => textBoxDescription.Text;
            set => textBoxDescription.Text = value;
        }

        public bool Marked
        {
            get => checkBoxMark.Checked;
            set
            {
                checkBoxMark.Checked = value;
                checkBoxMark.Text = value ? "Marked" : "Unmarked";
            }
        }

        private void CheckBoxMark_CheckedChanged(object sender, EventArgs e)
        {
            Marked = Marked; // dirty hack
        }
    }
}
