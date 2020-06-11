using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-MOJ8FKN;Initial Catalog=QLPhongMay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void hienthi()
        {
            command = connection.CreateCommand();
            command.CommandText = "select MALTH N'Mã lịch thực hành',MANV N' MÃ nhân viên',MAGV N'MÃ GIÁO VIÊN',NGAYTH N'NGÀY THỰC HÀNH',TENNV N'TÊN NHÂN VIÊN',HOTENGV N'HỌ TÊN GV',CA N'CA',GIOBD N'GIỜ BẮT ĐẦU',GIOKT N'GIỜ KẾT THÚC' FROM CT_THUCHANH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            DTV_TH.DataSource = table;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            hienthi();
        }
    }
}
