using System.Security.Cryptography.X509Certificates;

namespace Afleveringsopgave_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1Navn_Click(object sender, EventArgs e)
        {
            if (textBox1Navn != null) // Hvis Textboxen indeholder mere end ingenting
            {
                ArrayControll user = new ArrayControll(); // Gennerere nyt object
                user.username = textBox1Navn.Text; // Sæt Textboxens værdi til at være navnet
                user.adduser(); // Exekverer metoden add user
            }
        }
    }
}