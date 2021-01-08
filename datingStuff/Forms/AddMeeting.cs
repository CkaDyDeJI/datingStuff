using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Dapper;

using MySql.Data.MySqlClient;


namespace datingStuff
{
    public partial class AddMeeting : Form
    {
        private string firS_;
        private string secS_;

        public AddMeeting(string firstId, string secondId)
        {
            InitializeComponent();
            firS_ = firstId;
            secS_ = secondId;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите прервать добавление встречи?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(Data.connString)) {
                conn.Query ($"insert into meeting (firstperson_id, secondperson_id, place, datetime) values ({firS_}, {secS_}, '{textBox1.Text}, '{textBox2.Text}')");

                MessageBox.Show ("Добавлено");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Text;
        }
    }
}
