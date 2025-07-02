using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Kontaktbuch;


namespace Kontaktbuch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            this.FormBorderStyle = FormBorderStyle.None;    // no border
            this.StartPosition = FormStartPosition.CenterScreen;    // start position

            SetRoundedRegion();

            this.Opacity = 0.9;





        }




        private void SetRoundedRegion()
        {
            int radius = 30;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);    // draw border
            GraphicsPath path = new GraphicsPath(); // object for complex figures

            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);   // upper left
            path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);   // lower right
            path.AddArc(bounds.Left, bounds.Bottom - radius, radius, radius, 90, 90); // lower left


            path.CloseFigure();         // closes figure
            this.Region = new Region(path);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kontakt = new Kontakt
            {
                Name = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text
            };

            listBox1.Items.Add(kontakt);

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
     
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            if(listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
