using Quanlisinhvien.BLL;

namespace Quanlisinhvien.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = new StudentService().GetAll();
        }
    }
}
