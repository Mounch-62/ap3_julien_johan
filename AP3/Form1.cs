using AP3.ADO;

namespace AP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ADOEleves.open();
                Console.WriteLine("Connection reussite!");

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
