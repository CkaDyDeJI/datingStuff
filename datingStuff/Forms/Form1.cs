using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using Dapper;

using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;

using Xceed.Document.NET;
using Xceed.Words.NET;


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
            string[] reqs = person_viewDataGridView.SelectedCells[0].OwningRow.Cells[7].Value.ToString()
                .Split (',');
            var sex = (person_viewDataGridView.SelectedCells[0].OwningRow.Cells[3].Value.ToString() == "муж" ? 1 : 0);

            using (var conn = new MySqlConnection(Data.connString)) {
                var persons = conn.Query <forSelection> (
                        $"SELECT person.id AS id, GROUP_CONCAT(DISTINCT a.name SEPARATOR ',') AS chars FROM person\nJOIN link_char ON link_char.person_id = person.id\nJOIN characteristics as A ON a.char_id = link_char.char_id\nwhere person.sex <> {sex} and person.id <> {person_viewDataGridView.SelectedCells[0].OwningRow.Cells[0].Value}\nGROUP BY person.id")
                    .ToList();

                for (int i = 0; i < persons.Count; i++) {
                    var chars = persons[i].chars.Split(',');
                    for (int j = 0; j < reqs.Length; j++) {
                        for (int k = 0; k < chars.Length; k++) {
                            if (reqs[j] == chars[k])
                                persons[i].count++;
                        }
                    }

                    if (persons[i].count == 0) {
                        persons.RemoveAt(i);
                        //if (i != persons.Count - 1)
                        i--;
                    }
                }

                if (persons.Count == 0) {
                    MessageBox.Show ("Подходящих кандидатов нет");
                    return;
                } 

                var commandStr = "select * from person_view";
                for (int i = 0; i < persons.Count; i++)
                {
                    if (i == 0)
                        commandStr += $" where id = {persons[i].id}";
                    else
                        commandStr += $" or id = {persons[i].id}";
                }

                var command = new MySqlCommand(commandStr);
                command.Connection = conn;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill (dataset);
                BindingSource source = new BindingSource();
                source.DataSource = dataset.Tables[0];
                dataGridView1.DataSource = source;
            }
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

            person_viewTableAdapter.Fill(dating_stuffDataSet.person_view);
            person_viewBindingSource.DataSource = dating_stuffDataSet.person_view;
            person_viewBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newPerson = new AddPerson();
            newPerson.ShowDialog();

            person_viewTableAdapter.Fill(dating_stuffDataSet.person_view);
            person_viewBindingSource.DataSource = dating_stuffDataSet.person_view;
            person_viewBindingSource.ResetBindings(false);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "invitation";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var meetingid = Interaction.InputBox ("Введите id встречи");
            if (meetingid == "")
                return;

            var conn = new MySqlConnection(Data.connString);
            conn.Open();

            DocX document = DocX.Create(saveFileDialog1.FileName);

            document.InsertParagraph ("Приглашение").Font("Times New Roman").FontSize(18)
                .Alignment = Alignment.center;
            document.InsertParagraph();


            var meeting = conn.QueryFirst <forMeeting> (
                $"select first_person, second_person, place, datetime from meeting_view where id = {meetingid}");

            document.InsertParagraph (
                $"Я, {meeting.first_person}, приглашаю Вас, {meeting.second_person}, на встречу по адресу {meeting.place} в установленное время {meeting.datetime}");
            document.InsertParagraph();
            document.InsertParagraph ($"Телефон: {conn.QueryFirst<string>($"select phone from person where id = (select firstperson_id from meeting where meeting_id = {meetingid})")}");

            document.Save();
            conn.Close();

            Process.Start(saveFileDialog1.FileName);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "report";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var conn = new MySqlConnection(Data.connString);
            conn.Open();

            var currentDate = DateTime.Now.ToString ("yyyy-MM-dd hh:mm:ss");
            var monthAgoDate = DateTime.Now.AddMonths (-1).ToString ("yyyy-MM-dd hh:mm:ss");

            DocX document = DocX.Create(saveFileDialog1.FileName);

            document.InsertParagraph("Отчет").Font("Times New Roman").FontSize(18)
                .Alignment = Alignment.center;
            document.InsertParagraph();

            var countSuccesses =
                conn.QueryFirst <string> (
                    $"select count(*) from link_archive where created between '{monthAgoDate}' and '{currentDate}'");
            document.InsertParagraph ($"За последний месяц было создано {countSuccesses} пар");
            document.InsertParagraph();

            var couplesList = conn.Query <forMeeting> (
                $"select concat_ws(' ', A.firstname, A.lastname) as first_person, concat_ws(' ', B.firstname, B.lastname) as second_person from link_archive\njoin archive_person as A on A.id = link_archive.firstP_id\njoin archive_person as B on B.id = link_archive.secondP_id\nwhere created between '{monthAgoDate}' and '{currentDate}'").ToList();

            Table couplesTable = document.AddTable (couplesList.Count + 1, 2);
            couplesTable.Alignment = Alignment.both;
            couplesTable.AutoFit = AutoFit.ColumnWidth;
            couplesTable.SetWidthsPercentage(new[] { 50.0f, 50.0f });
            couplesTable.Design = TableDesign.TableGrid;

            couplesTable.Rows[0].Cells[0].Paragraphs[0].Append ("Первый партнер");
            couplesTable.Rows[0].Cells[1].Paragraphs[0].Append("Второй партнер");

            for (int i = 0; i < couplesList.Count; i++) {
                couplesTable.Rows[i + 1].Cells[0].Paragraphs[0].Append(couplesList[i].first_person);
                couplesTable.Rows[i + 1].Cells[1].Paragraphs[0].Append(couplesList[i].second_person);
            }

            document.InsertTable (couplesTable);
            document.InsertParagraph();

            var declinedCount = conn.QueryFirst <string> ($"select count(*) from archive_person\nwhere archive_person.id not in (select id from person) and archive_person.id not in (select firstP_id from link_archive where created between '{monthAgoDate}' and '{currentDate}') and archive_person.id not in (select secondP_id from link_archive where created between '{monthAgoDate}' and '{currentDate}')");
            document.InsertParagraph ($"От услуг отказалось {declinedCount} клиентов");

            document.Save();
            conn.Close();

            Process.Start(saveFileDialog1.FileName);
        }
    }


    class forSelection
    {
        public string id { get; set; }
        public string chars { get; set; }
        public int count { get; set; }
    }


    class forMeeting
    {
        public string first_person { get; set; }
        public string second_person { get; set; }
        public string place { get; set; }
        public string datetime { get; set; }
    }
}
