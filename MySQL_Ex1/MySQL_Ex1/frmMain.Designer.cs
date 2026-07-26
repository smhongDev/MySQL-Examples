namespace MySQL_Ex1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonInsert = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            listViewPhoneBook = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            buttonDelete = new Button();
            buttonSelect = new Button();
            groupBox1 = new GroupBox();
            buttonUpdate = new Button();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(6, 21);
            buttonInsert.Margin = new Padding(3, 4, 3, 4);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(75, 42);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "추가";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "번호";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(46, 21);
            textBoxName.Margin = new Padding(3, 4, 3, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(191, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(46, 55);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(191, 23);
            textBoxPhone.TabIndex = 1;
            // 
            // listViewPhoneBook
            // 
            listViewPhoneBook.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewPhoneBook.FullRowSelect = true;
            listViewPhoneBook.Location = new Point(6, 71);
            listViewPhoneBook.Margin = new Padding(3, 4, 3, 4);
            listViewPhoneBook.Name = "listViewPhoneBook";
            listViewPhoneBook.Size = new Size(318, 333);
            listViewPhoneBook.TabIndex = 7;
            listViewPhoneBook.UseCompatibleStateImageBehavior = false;
            listViewPhoneBook.View = View.Details;
            listViewPhoneBook.SelectedIndexChanged += listViewPhoneBook_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(168, 21);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 42);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "삭제";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(249, 21);
            buttonSelect.Margin = new Padding(3, 4, 3, 4);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(75, 42);
            buttonSelect.TabIndex = 5;
            buttonSelect.Text = "조회";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Location = new Point(52, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(258, 91);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "연락처";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(87, 21);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 42);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "수정";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewPhoneBook);
            groupBox2.Controls.Add(buttonInsert);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(buttonUpdate);
            groupBox2.Controls.Add(buttonSelect);
            groupBox2.Font = new Font("새굴림", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 114);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(332, 416);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Tag = "";
            groupBox2.Text = "연락처 관리";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 536);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "MySQL Ex1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.ListView listViewPhoneBook;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
