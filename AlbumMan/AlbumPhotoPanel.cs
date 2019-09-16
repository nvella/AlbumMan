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
                checkBoxMark.BackColor = value ? Color.LightGreen : Color.LightCoral;
            }
        }

        public DateTime Date
        {
            get => dateTimePicker1.Value;
            set => dateTimePicker1.Value = value;
        }

        public List<string> Tags
        {
            get
            {
                if (textBoxTags.Text.Trim().Length < 1) return new List<string>();
                return textBoxTags.Text.Split(',').Select(tag => tag.Trim()).ToList();
            }
            set => textBoxTags.Text = String.Join(", ", value).TrimEnd(',', ' ');
        }

        public void SelectTitle()
        {
            textBoxTitle.SelectAll();
            textBoxTitle.Focus();
        }
        private void CheckBoxMark_CheckedChanged(object sender, EventArgs e)
        {
            Marked = Marked; // dirty hack
        }
    }
}
