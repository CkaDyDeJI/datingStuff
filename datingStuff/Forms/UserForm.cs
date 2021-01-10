using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using Dapper;

using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;


namespace datingStuff
{
    public partial class UserForm : Form
    {
        private Form1 opener;
        private string user;


        public UserForm(Form1 parent)
        {
            InitializeComponent();
            opener = parent;
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрытие этого окна без входа приведет к закрытию всего приложения.\nВы хотите продолжить?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                opener.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FillData();
        }


        private void FillData()
        {
            while (true)
            {
                user = Interaction.InputBox("Укажите ваш номер телефона");

                if (user != "")
                {
                    using (var conn = new MySqlConnection(Data.connString))
                    {
                        if (conn.Query<string>($"select count(*) from person where phone = {user}").Count() == 1)
                        {
                            MessageBox.Show("Человек не найден");

                            continue;
                        }

                        var userid = conn.QueryFirst <string> ($"select id from person where phone = {user}");
                        label1.Text = conn.QueryFirst<string>($"select concat_ws(' ', firstname, lastname) from person where id = {userid}");

                        var command = new MySqlCommand($"select meeting_view.* from meeting_view where id = any(select meeting_id from meeting where firstperson_id = {userid} or secondperson_id = {userid})");
                        command.Connection = conn;

                        var adapter = new MySqlDataAdapter(command);
                        var dataset = new DataSet();
                        adapter.Fill(dataset);

                        var bindingSource = new BindingSource();
                        bindingSource.DataSource = dataset.Tables[0];
                        dataGridView1.DataSource = bindingSource;

                        break;
                    }
                }
                else
                {
                    if (MessageBox.Show("Такого пользователя не существует. Вы хотите выйти?", "Внимание",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Dispose();
                        opener.Dispose();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(Data.connString)) {
                if (MessageBox.Show("Вы точно хотите удалить встречу?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    conn.Query ($"delete from meeting where meeting_id = {dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value}");

                dataGridView1.Rows.Remove(dataGridView1.SelectedCells[0].OwningRow);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            var meetingid = dataGridView1.SelectedCells[0].OwningRow.Cells[0].Value.ToString();
            using (var conn = new MySqlConnection (Data.connString)) {
                var fpid = conn.QueryFirst <string> ($"select firstperson_id from meeting where meeting_id = {meetingid}");
                var spid = conn.QueryFirst<string>($"select secondperson_id from meeting where meeting_id = {meetingid}");

                conn.Query ($"insert into link_archive values ({fpid}, {spid}, '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')");
                conn.Query($"delete from meeting where meeting.meeting_id = {meetingid}");
                conn.Query ($"delete from person where id = {fpid} or id = {spid}");

                MessageBox.Show ("Пара создана");
                //dataGridView1.Rows.Clear();
            }
        }
    }
}
