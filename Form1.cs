using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Yusuf Semih AKILLI 09082018 17:16 

namespace Creation
{
    
    public partial class Form1 : Form
    {

        Image img;
        static int Switdth;
        static int Sheight;
        string[] exten = { ".BMP", ".JPG", "PNG" };

        public Form1()
        {
            InitializeComponent();
        }

     
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.jpg,*.bmp,*.png)|*.jpg;*.bmp;*.png";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                textSelect.Text = openFile.FileName;

                img = Image.FromFile(openFile.FileName);

                this.pictureBox1.Image = new Bitmap(openFile.FileName);
                

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < exten.Length; i++)
            {
                imageForm.Items.Add(exten[i]);
            }  
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBD = new FolderBrowserDialog();
            if (folderBD.ShowDialog() == DialogResult.OK)
            {
                textSave.Text = folderBD.SelectedPath;
            }
            pictureBox1.Image = img;

        }

        private void buttonResize_Click(object sender, EventArgs e)
        {

            int width = Convert.ToInt32(textWidth.Text), height = Convert.ToInt32(textHeight.Text);

            img = Resized(img, width, height);
           // ((Button)sender).Enabled = false;
            MessageBox.Show("Image Resized");
            this.pictureBox1.Image = img;
            // buttonSave.Enabled = true;
            

        }

        Image Resized(Image image,int width,int height)
        {
            Bitmap bmp = new Bitmap(width,height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(image, 0, 0, width, height);
            graphics.Dispose();
            Switdth = width;
            Sheight = height;
            
            return bmp;
        }

        private void buttonreSave_Click(object sender, EventArgs e)
        {
            int dot = 0, slash = 0;
            for (int j = textSelect.Text.Length - 1; j >= 0; j--)
            {
                if (textSelect.Text[j] == '.')
                    dot = j;
                else if(textSelect.Text[j] == '\\')
                {

                    slash = j;
                    break;

                }


            }
            img.Save(textSave.Text + "\\" + textSelect.Text.Substring(slash + 1, dot - slash - 1) + exten[imageForm.SelectedIndex]);
           //     ((Button)sender).Enabled = false;
           // buttonResize.Enabled = true;
                        
            MessageBox.Show("Image Saved");
                            
        }
            
        private void buttonBalance_Click(object sender, EventArgs e)
        {
            
            
                checkboxController();

                Bitmap copy = new Bitmap((Bitmap)this.img);
                if (checkDark.Checked)
                {

                    Configuration.ConvertDarkColor(copy);

                }
                else if (checkLight.Checked)
                {

                    Configuration.ConvertLightColor(copy);
      
                }
                else
                {
                  MessageBox.Show("Please Check your Color Type");
                }

                img = copy;
                this.pictureBox1.Image = img;


                ((Button)sender).Enabled = false;
                checkboxController();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkboxController();
            if (checkBox1.Checked)
            {

                MessageBox.Show("program will be slow in high quality ( HD or higher not recommended)");
                
            }
        }
           

        private void checkboxController()
        {
            buttonBalance.Enabled = checkBox1.Checked;
            checkLight.Enabled = checkBox1.Checked;
            checkDark.Enabled = checkBox1.Checked;

            if (checkBox1.Checked)
            {
                if ((checkDark.Checked == checkLight.Checked))
                {
                    checkLight.Enabled = true;
                    checkDark.Enabled = true;
                }
                else if ((checkDark.Checked == false) & (checkLight.Checked == true))
                {
                    checkLight.Enabled = true;
                    checkDark.Enabled = false;
                    buttonBalance.Enabled = true;
                }
                else if ((checkDark.Checked == true) & (checkLight.Checked == false))
                {
                    checkLight.Enabled = false;
                    checkDark.Enabled = true;
                    buttonBalance.Enabled = true;
                }
                else
                {
                    buttonBalance.Enabled = false;
                    checkLight.Enabled = false;
                    checkDark.Enabled = false;
                }
            }

            else
            {
                buttonBalance.Enabled = false;
                checkLight.Enabled = false;
                checkDark.Enabled = false;
            }
        }

        private void checkDark_CheckedChanged(object sender, EventArgs e)
        {
            checkboxController();
        }

        private void checkLight_CheckedChanged(object sender, EventArgs e)
        {
            checkboxController();
        }
    }
}
