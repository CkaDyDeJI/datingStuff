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

using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;


namespace datingStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dating_stuffDataSet.person_view' table. You can move, or remove it, as needed.
            this.person_viewTableAdapter.Fill(this.dating_stuffDataSet.person_view);

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var login = new LogForm(this);
            login.ShowDialog();

            if (Data.currentUser == "client") {
                var userForm = new UserForm(this);
                userForm.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var tables = new Sources();
            tables.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (person_viewDataGridView.SelectedCells.Count == 0 && dataGridView1.SelectedCells.Count == 0)
                return;

            if (MessageBox.Show("Вы уверены, что хотите назначить свидание этим двух людям?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var addMeeting = new AddMeeting(person_viewDataGridView.SelectedCells[0].OwningRow.Cells[0].Value.ToString(), dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
            addMeeting.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var temp = Interaction.InputBox ("Введите номер телефона или id человека, которого хотите удалить");

            if (temp == "")
                return;

            using (var conn = new MySqlConnection(Data.connString)) {
                conn.Query ($"delete from person where id = {temp} or phone = {temp}");

                MessageBox.Show ("Удалено");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newPerson = new AddPerson();
            newPerson.ShowDialog();

            person_viewTableAdapter.Fill(dating_stuffDataSet.person_view);
            person_viewBindingSource.DataSource = dating_stuffDataSet.person_view;
            person_viewBindingSource.ResetBindings(false);
        }
    }
}
