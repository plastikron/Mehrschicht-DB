using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatentransferDLL;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonladen_Click(object sender, EventArgs e)
        {
            DTO dto = new DTO();
            dataGridView1.DataSource = dto.GetAllCustomers();
        }
    }
}
