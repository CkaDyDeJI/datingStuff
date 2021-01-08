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
                user = Interaction.InputBox("Укажите ваш ID (паспорт)");

                if (user != "")
                {
                    using (var conn = new MySqlConnection(Data.connString))
                    {
                        if (!conn.Query<int>($"select count(fio) from jobless where passport = {user}").Any())
                        {
                            MessageBox.Show("Человек не найден");

                            continue;
                        }

                        label1.Text = conn.QueryFirst<string>($"select fio from jobless where passport = {user}");

                        var command = new MySqlCommand($"select comp_pos_view.* from comp_pos_view join proposition on proposition.position_id = comp_pos_view.id join jobless on jobless.passport = proposition.person_id where jobless.passport = {user}");
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
    }
}
