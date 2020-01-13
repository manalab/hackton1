using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplicationSpeech
{
    public partial class addImige : Form
    {
        public addImige()
        {
            InitializeComponent();
        }

        private void buttonBrowsse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "please select a photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBoxPhoto.ImageLocation = ofd.FileName;
            }
        }
        private byte[] ConvertFiltoByte(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        



        //save button
        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            try
            {

                DatabaseUsersEntities4 mde = new DatabaseUsersEntities4();
                imge im = new imge();
                im.imageName = textBox1.Text;
                im.image = ConvertFiltoByte(this.pictureBoxPhoto.ImageLocation);
                mde.imges.Add(im);
                mde.SaveChanges();
                MessageBox.Show("Add new photoes is successfull");

            }
            catch
            {
                MessageBox.Show("Can't add new pictures");
            }
          
        }

    }
}
