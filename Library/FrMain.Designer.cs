namespace Library
{
    partial class FrMain
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            tb_publishWay = new TextBox();
            tb_publishDate = new TextBox();
            tb_pride = new TextBox();
            tb_words = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bt_delete = new Button();
            bt_search = new Button();
            tb_publishNum = new TextBox();
            bt_change = new Button();
            bt_add = new Button();
            tb_publisher = new TextBox();
            tb_bookName = new TextBox();
            tb_bookID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            userAccessBindingSource1 = new BindingSource(components);
            userAccessBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userAccessBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userAccessBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tb_publishWay);
            splitContainer1.Panel1.Controls.Add(tb_publishDate);
            splitContainer1.Panel1.Controls.Add(tb_pride);
            splitContainer1.Panel1.Controls.Add(tb_words);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(bt_delete);
            splitContainer1.Panel1.Controls.Add(bt_search);
            splitContainer1.Panel1.Controls.Add(tb_publishNum);
            splitContainer1.Panel1.Controls.Add(bt_change);
            splitContainer1.Panel1.Controls.Add(bt_add);
            splitContainer1.Panel1.Controls.Add(tb_publisher);
            splitContainer1.Panel1.Controls.Add(tb_bookName);
            splitContainer1.Panel1.Controls.Add(tb_bookID);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1415, 562);
            splitContainer1.SplitterDistance = 124;
            splitContainer1.TabIndex = 0;
            // 
            // tb_publishWay
            // 
            tb_publishWay.Location = new Point(951, 73);
            tb_publishWay.Name = "tb_publishWay";
            tb_publishWay.Size = new Size(120, 30);
            tb_publishWay.TabIndex = 19;
            // 
            // tb_publishDate
            // 
            tb_publishDate.Location = new Point(675, 73);
            tb_publishDate.Name = "tb_publishDate";
            tb_publishDate.Size = new Size(156, 30);
            tb_publishDate.TabIndex = 18;
            // 
            // tb_pride
            // 
            tb_pride.Location = new Point(915, 18);
            tb_pride.Name = "tb_pride";
            tb_pride.Size = new Size(156, 30);
            tb_pride.TabIndex = 17;
            // 
            // tb_words
            // 
            tb_words.Location = new Point(675, 18);
            tb_words.Name = "tb_words";
            tb_words.Size = new Size(156, 30);
            tb_words.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(845, 76);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 15;
            label5.Text = "包装方式：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(580, 79);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 14;
            label6.Text = "出版时间：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(845, 21);
            label7.Name = "label7";
            label7.Size = new Size(64, 24);
            label7.TabIndex = 13;
            label7.Text = "价格：";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 21);
            label8.Name = "label8";
            label8.Size = new Size(64, 24);
            label8.TabIndex = 12;
            label8.Text = "字数：";
            // 
            // bt_delete
            // 
            bt_delete.Location = new Point(1252, 67);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(112, 34);
            bt_delete.TabIndex = 11;
            bt_delete.Text = "删除";
            bt_delete.UseVisualStyleBackColor = true;
            bt_delete.Click += bt_delete_Click;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(1101, 11);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(112, 34);
            bt_search.TabIndex = 8;
            bt_search.Text = "查询";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += button1_Click;
            // 
            // tb_publishNum
            // 
            tb_publishNum.Location = new Point(375, 73);
            tb_publishNum.Name = "tb_publishNum";
            tb_publishNum.Size = new Size(188, 30);
            tb_publishNum.TabIndex = 7;
            // 
            // bt_change
            // 
            bt_change.Location = new Point(1101, 68);
            bt_change.Name = "bt_change";
            bt_change.Size = new Size(112, 34);
            bt_change.TabIndex = 10;
            bt_change.Text = "修改";
            bt_change.UseVisualStyleBackColor = true;
            bt_change.Click += bt_change_Click;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(1252, 11);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(112, 34);
            bt_add.TabIndex = 9;
            bt_add.Text = "添加";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            // 
            // tb_publisher
            // 
            tb_publisher.Location = new Point(103, 76);
            tb_publisher.Name = "tb_publisher";
            tb_publisher.Size = new Size(188, 30);
            tb_publisher.TabIndex = 6;
            // 
            // tb_bookName
            // 
            tb_bookName.Location = new Point(375, 18);
            tb_bookName.Name = "tb_bookName";
            tb_bookName.Size = new Size(188, 30);
            tb_bookName.TabIndex = 5;
            // 
            // tb_bookID
            // 
            tb_bookID.Location = new Point(103, 18);
            tb_bookID.Name = "tb_bookID";
            tb_bookID.Size = new Size(188, 30);
            tb_bookID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 76);
            label4.Name = "label4";
            label4.Size = new Size(64, 24);
            label4.TabIndex = 3;
            label4.Text = "版次：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 79);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 2;
            label3.Text = "出版社：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 21);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "书名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "书号：";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.Size = new Size(1415, 434);
            dataGridView1.TabIndex = 0;
            // 
            // userAccessBindingSource1
            // 
            userAccessBindingSource1.DataSource = typeof(BLL.userAccess);
            // 
            // userAccessBindingSource
            // 
            userAccessBindingSource.DataSource = typeof(BLL.userAccess);
            // 
            // FrMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 562);
            Controls.Add(splitContainer1);
            Name = "FrMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "图书管理系统";
            Load += FrMain_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userAccessBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userAccessBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bt_delete;
        private Button bt_search;
        private TextBox tb_publishNum;
        private Button bt_change;
        private Button bt_add;
        private TextBox tb_publisher;
        private TextBox tb_bookName;
        private TextBox tb_bookID;
        private DataGridView dataGridView1;
        private TextBox tb_publishWay;
        private TextBox tb_publishDate;
        private TextBox tb_pride;
        private TextBox tb_words;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private BindingSource userAccessBindingSource1;
        private BindingSource userAccessBindingSource;
    }
}