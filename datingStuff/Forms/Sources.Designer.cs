
namespace datingStuff
{
    partial class Sources
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sources));
            this.dating_stuffDataSet = new datingStuff.dating_stuffDataSet();
            this.archive_personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archive_personTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.archive_personTableAdapter();
            this.tableAdapterManager = new datingStuff.dating_stuffDataSetTableAdapters.TableAdapterManager();
            this.characteristicsTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.characteristicsTableAdapter();
            this.link_archiveTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.link_archiveTableAdapter();
            this.link_charTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.link_charTableAdapter();
            this.link_requirTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.link_requirTableAdapter();
            this.meetingTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.meetingTableAdapter();
            this.personTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.personTableAdapter();
            this.archive_personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.archive_personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.archive_personDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characteristicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_archiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_charBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.link_requirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meetingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meeting_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.person_viewTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.person_viewTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meeting_viewTableAdapter = new datingStuff.dating_stuffDataSetTableAdapters.meeting_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dating_stuffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personBindingNavigator)).BeginInit();
            this.archive_personBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characteristicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_archiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_charBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_requirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_viewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dating_stuffDataSet
            // 
            this.dating_stuffDataSet.DataSetName = "dating_stuffDataSet";
            this.dating_stuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archive_personBindingSource
            // 
            this.archive_personBindingSource.DataMember = "archive_person";
            this.archive_personBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // archive_personTableAdapter
            // 
            this.archive_personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.archive_personTableAdapter = this.archive_personTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.characteristicsTableAdapter = this.characteristicsTableAdapter;
            this.tableAdapterManager.link_archiveTableAdapter = this.link_archiveTableAdapter;
            this.tableAdapterManager.link_charTableAdapter = this.link_charTableAdapter;
            this.tableAdapterManager.link_requirTableAdapter = this.link_requirTableAdapter;
            this.tableAdapterManager.meetingTableAdapter = this.meetingTableAdapter;
            this.tableAdapterManager.personTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = datingStuff.dating_stuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // characteristicsTableAdapter
            // 
            this.characteristicsTableAdapter.ClearBeforeFill = true;
            // 
            // link_archiveTableAdapter
            // 
            this.link_archiveTableAdapter.ClearBeforeFill = true;
            // 
            // link_charTableAdapter
            // 
            this.link_charTableAdapter.ClearBeforeFill = true;
            // 
            // link_requirTableAdapter
            // 
            this.link_requirTableAdapter.ClearBeforeFill = true;
            // 
            // meetingTableAdapter
            // 
            this.meetingTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // archive_personBindingNavigator
            // 
            this.archive_personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.archive_personBindingNavigator.BindingSource = this.archive_personBindingSource;
            this.archive_personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.archive_personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.archive_personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.archive_personBindingNavigatorSaveItem});
            this.archive_personBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.archive_personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.archive_personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.archive_personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.archive_personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.archive_personBindingNavigator.Name = "archive_personBindingNavigator";
            this.archive_personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.archive_personBindingNavigator.Size = new System.Drawing.Size(885, 25);
            this.archive_personBindingNavigator.TabIndex = 0;
            this.archive_personBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // archive_personBindingNavigatorSaveItem
            // 
            this.archive_personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.archive_personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("archive_personBindingNavigatorSaveItem.Image")));
            this.archive_personBindingNavigatorSaveItem.Name = "archive_personBindingNavigatorSaveItem";
            this.archive_personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.archive_personBindingNavigatorSaveItem.Text = "Save Data";
            this.archive_personBindingNavigatorSaveItem.Click += new System.EventHandler(this.archive_personBindingNavigatorSaveItem_Click);
            // 
            // archive_personDataGridView
            // 
            this.archive_personDataGridView.AutoGenerateColumns = false;
            this.archive_personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archive_personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.archive_personDataGridView.DataSource = this.archive_personBindingSource;
            this.archive_personDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.archive_personDataGridView.Location = new System.Drawing.Point(0, 0);
            this.archive_personDataGridView.Name = "archive_personDataGridView";
            this.archive_personDataGridView.Size = new System.Drawing.Size(684, 308);
            this.archive_personDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastname";
            this.dataGridViewTextBoxColumn3.HeaderText = "lastname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sex";
            this.dataGridViewTextBoxColumn4.HeaderText = "sex";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn5.HeaderText = "phone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "reg_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "reg_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // characteristicsBindingSource
            // 
            this.characteristicsBindingSource.DataMember = "characteristics";
            this.characteristicsBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // link_archiveBindingSource
            // 
            this.link_archiveBindingSource.DataMember = "link_archive";
            this.link_archiveBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // link_charBindingSource
            // 
            this.link_charBindingSource.DataMember = "link_char";
            this.link_charBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // link_requirBindingSource
            // 
            this.link_requirBindingSource.DataMember = "link_requir";
            this.link_requirBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // meetingBindingSource
            // 
            this.meetingBindingSource.DataMember = "meeting";
            this.meetingBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // meeting_viewBindingSource
            // 
            this.meeting_viewBindingSource.DataMember = "meeting_view";
            this.meeting_viewBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "person";
            this.personBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // person_viewBindingSource
            // 
            this.person_viewBindingSource.DataMember = "person_view";
            this.person_viewBindingSource.DataSource = this.dating_stuffDataSet;
            // 
            // person_viewTableAdapter
            // 
            this.person_viewTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "archive_person",
            "characteristics",
            "link_archive",
            "link_char",
            "link_requir",
            "meeting",
            "person"});
            this.comboBox1.Location = new System.Drawing.Point(695, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.archive_personDataGridView);
            this.panel1.Location = new System.Drawing.Point(5, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 308);
            this.panel1.TabIndex = 5;
            // 
            // meeting_viewTableAdapter
            // 
            this.meeting_viewTableAdapter.ClearBeforeFill = true;
            // 
            // Sources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.archive_personBindingNavigator);
            this.Name = "Sources";
            this.Text = "Sources";
            this.Load += new System.EventHandler(this.Sources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dating_stuffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personBindingNavigator)).EndInit();
            this.archive_personBindingNavigator.ResumeLayout(false);
            this.archive_personBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archive_personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characteristicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_archiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_charBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.link_requirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meetingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meeting_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person_viewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dating_stuffDataSet dating_stuffDataSet;
        private System.Windows.Forms.BindingSource archive_personBindingSource;
        private dating_stuffDataSetTableAdapters.archive_personTableAdapter archive_personTableAdapter;
        private dating_stuffDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator archive_personBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton archive_personBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView archive_personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private dating_stuffDataSetTableAdapters.characteristicsTableAdapter characteristicsTableAdapter;
        private System.Windows.Forms.BindingSource characteristicsBindingSource;
        private dating_stuffDataSetTableAdapters.link_archiveTableAdapter link_archiveTableAdapter;
        private System.Windows.Forms.BindingSource link_archiveBindingSource;
        private dating_stuffDataSetTableAdapters.link_charTableAdapter link_charTableAdapter;
        private System.Windows.Forms.BindingSource link_charBindingSource;
        private dating_stuffDataSetTableAdapters.link_requirTableAdapter link_requirTableAdapter;
        private System.Windows.Forms.BindingSource link_requirBindingSource;
        private dating_stuffDataSetTableAdapters.meetingTableAdapter meetingTableAdapter;
        private System.Windows.Forms.BindingSource meetingBindingSource;
        private System.Windows.Forms.BindingSource meeting_viewBindingSource;
        private dating_stuffDataSetTableAdapters.personTableAdapter personTableAdapter;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource person_viewBindingSource;
        private dating_stuffDataSetTableAdapters.person_viewTableAdapter person_viewTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private dating_stuffDataSetTableAdapters.meeting_viewTableAdapter meeting_viewTableAdapter;
    }
}