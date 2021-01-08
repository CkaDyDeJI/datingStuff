using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datingStuff
{
    public partial class Sources : Form
    {
        public Sources()
        {
            InitializeComponent();
        }

        private void archive_personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.archive_personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dating_stuffDataSet);

        }

        private void Sources_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dating_stuffDataSet.person_view' table. You can move, or remove it, as needed.
            this.person_viewTableAdapter.Fill(this.dating_stuffDataSet.person_view);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dating_stuffDataSet.person);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.meeting_view' table. You can move, or remove it, as needed.
            this.meeting_viewTableAdapter.Fill(this.dating_stuffDataSet.meeting_view);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.meeting' table. You can move, or remove it, as needed.
            this.meetingTableAdapter.Fill(this.dating_stuffDataSet.meeting);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.link_requir' table. You can move, or remove it, as needed.
            this.link_requirTableAdapter.Fill(this.dating_stuffDataSet.link_requir);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.link_char' table. You can move, or remove it, as needed.
            this.link_charTableAdapter.Fill(this.dating_stuffDataSet.link_char);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.link_archive' table. You can move, or remove it, as needed.
            this.link_archiveTableAdapter.Fill(this.dating_stuffDataSet.link_archive);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.characteristics' table. You can move, or remove it, as needed.
            this.characteristicsTableAdapter.Fill(this.dating_stuffDataSet.characteristics);
            // TODO: This line of code loads data into the 'dating_stuffDataSet.archive_person' table. You can move, or remove it, as needed.
            this.archive_personTableAdapter.Fill(this.dating_stuffDataSet.archive_person);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            archive_personDataGridView.Dispose();
            archive_personDataGridView = new DataGridView { Parent = panel1, Dock = DockStyle.Fill };
            //archiveDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //mARKSDataGridView.Columns.Clear();
            //mARKSDataGridView.Rows.Clear();

            if (comboBox1.SelectedIndex == 0)
            {
                archive_personDataGridView.DataSource = archive_personBindingSource;
                archive_personBindingNavigator.BindingSource = archive_personBindingSource;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                archive_personDataGridView.DataSource = characteristicsBindingSource;
                archive_personBindingNavigator.BindingSource = characteristicsBindingSource;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                archive_personDataGridView.DataSource = link_archiveBindingSource;
                archive_personBindingNavigator.BindingSource = link_archiveBindingSource;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                archive_personDataGridView.DataSource = link_charBindingSource;
                archive_personBindingNavigator.BindingSource = link_charBindingSource;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                archive_personDataGridView.DataSource = link_requirBindingSource;
                archive_personBindingNavigator.BindingSource = link_requirBindingSource;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                archive_personDataGridView.DataSource = meetingBindingSource;
                archive_personBindingNavigator.BindingSource = meetingBindingSource;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                archive_personDataGridView.DataSource = personBindingSource;
                archive_personBindingNavigator.BindingSource = personBindingSource;
            }

            label2.Text = $"Количество записей в таблице = {archive_personDataGridView.RowCount - 1}";
        }
    }
}
