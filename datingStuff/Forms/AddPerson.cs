using System;
using System.Linq;
using System.Windows.Forms;

using Dapper;

using MySql.Data.MySqlClient;


namespace datingStuff
{
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();

            using (var conn = new MySqlConnection(Data.connString)) {
                var temp = conn.Query <string> ("select name from characteristics").ToArray();
                comboBox2.DataSource = temp;

                temp = conn.Query<string>("select name from characteristics").ToArray();
                comboBox5.DataSource = temp;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;

            using (var conn = new MySqlConnection(Data.connString))
            {
                var temp = conn.Query<string>($"select name from characteristics where name != '{comboBox2.Text}'").ToArray();
                comboBox3.DataSource = temp;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;

            using (var conn = new MySqlConnection(Data.connString))
            {
                var temp = conn.Query<string>($"select name from characteristics where name != '{comboBox2.Text}' and name != '{comboBox3.Text}'").ToArray();
                comboBox4.DataSource = temp;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Enabled = true;

            using (var conn = new MySqlConnection(Data.connString))
            {
                var temp = conn.Query<string>($"select name from characteristics where name != '{comboBox5.Text}'").ToArray();
                comboBox6.DataSource = temp;
            }
        }


        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox7.Enabled = true;

            using (var conn = new MySqlConnection(Data.connString))
            {
                var temp = conn.Query<string>($"select name from characteristics where name != '{comboBox5.Text}' and name != '{comboBox6.Text}'").ToArray();
                comboBox7.DataSource = temp;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите добавить человека?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            
            using (var conn = new MySqlConnection (Data.connString)) {
                var isExist = conn.Query <string> ($"select id from archive_person where phone = {textBox4.Text}").Count();

                if (isExist == 0) {
                    conn.Query(
                        $"insert into person(firstname, lastname, sex, phone, reg_date) values ('{textBox1.Text}', '{textBox2.Text}', {(comboBox1.Text == "Мужской" ? 1 : 0)}, {textBox4.Text}, '{DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")}')");

                    var id = conn.QueryFirst<string>($"select id from person where phone = {textBox4.Text}");

                    foreach (var combobox in groupBox2.Controls.OfType<ComboBox>())
                    {
                        var char_id = conn.QueryFirst<string>($"select char_id from characteristics where name = '{combobox.Text}'");

                        conn.Query($"insert into link_char values ({id}, {char_id})");
                    }

                    foreach (var combobox in groupBox3.Controls.OfType<ComboBox>())
                    {
                        var char_id = conn.QueryFirst<string>($"select char_id from characteristics where name = '{combobox.Text}'");

                        conn.Query($"insert into link_requir values ({id}, {char_id})");
                    }

                } else {
                    try {
                        conn.Query(
                            $"insert into person(firstname, lastname, sex, phone, reg_date) select archive_person.firstname, archive_person.lastname, archive_person.sex, archive_person.phone, archive_person.reg_date from archive_person where archive_person.phone = {textBox4.Text}");
                    }
                    catch {
                        MessageBox.Show ("Уже существует");
                    }
                    
                }

                MessageBox.Show("Добавлено");
            }
        }
    }
}
