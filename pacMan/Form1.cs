namespace pacMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            exit.Click += Exit_Click;
            
        }

        private void Exit_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    class ChengeTaxtbox
    {


    }
}
