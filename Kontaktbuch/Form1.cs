using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Kontaktbuch;


namespace Kontaktbuch
{
    public partial class Form1 : Form
    {


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;




        public Form1()
        {
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;    // no border
            this.StartPosition = FormStartPosition.CenterScreen;    // start position
            SetRoundedRegion();
            this.Opacity = 0.9;

            // Load existing list from sql - Database
            LoadKontakteInListBox();                
        }



        // Rounded borders
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
        
        // Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            var kontakt = new Kontakt
            {
                Name = textBox1.Text,
                LastName = textBox2.Text,
                Phone = textBox3.Text,
                Email = textBox4.Text
            };

            listBox1.Items.Add(kontakt);    // kontakt in listBox1
            kontakt.Id = Database.InsertKontakt(kontakt);    // kontakt in database

            MessageBox.Show("Kontakt gespeichert.");

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
        }
        
        // Delete Button
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            
            if(listBox1.SelectedItem is Kontakt kontakt)
            {
                Database.DeleteKontakt(kontakt.Id); // delete from database
                listBox1.Items.Remove(listBox1.SelectedItem);   // delete from listbox
                
                
            }
        }

        // search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            foreach(Kontakt kontakt in listBox1.Items)
            {
                string query = textBox5.Text.ToLower();

                if (!string.IsNullOrWhiteSpace(query))
                {
                    if(kontakt.Name.ToLower().Contains(query) ||
                       kontakt.LastName.ToLower().Contains(query) ||
                       kontakt.Phone.ToLower().Contains(query) ||
                       kontakt.Email.ToLower().Contains(query))
                    {
                        listBox1.SelectedItem = kontakt;
                        return;
                    }
                }
            }          
            
            
        }

        // Load list Kontakte in listBox
        private void LoadKontakteInListBox()
        {
            foreach(Kontakt kontakt in Database.LoadKontakte())
            {
                listBox1.Items.Add(kontakt);
            }
        }



        // Mouse Down 
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }


        private void CloseApp(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
