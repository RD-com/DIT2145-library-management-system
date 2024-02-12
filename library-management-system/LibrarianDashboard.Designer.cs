namespace library_management_system
{
    partial class LibrarianDashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCopy = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbBorrow = new System.Windows.Forms.RadioButton();
            this.rbRef = new System.Windows.Forms.RadioButton();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.dateBorrow = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBorrowBookId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBorrowUserId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReturnBookID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtReturnUserID = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.txtReturnBorrowID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 517);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvBooks);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(260, 6);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(764, 479);
            this.dgvBooks.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.txtAuthors);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIsbn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 479);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(9, 236);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(233, 45);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtAuthors
            // 
            this.txtAuthors.Location = new System.Drawing.Point(9, 149);
            this.txtAuthors.Multiline = true;
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(233, 67);
            this.txtAuthors.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Authors";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(233, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(9, 52);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(233, 20);
            this.txtIsbn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCopy);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Copy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCopy
            // 
            this.dgvCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopy.Location = new System.Drawing.Point(260, 6);
            this.dgvCopy.Name = "dgvCopy";
            this.dgvCopy.Size = new System.Drawing.Size(764, 479);
            this.dgvCopy.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBorrow);
            this.groupBox2.Controls.Add(this.rbRef);
            this.groupBox2.Controls.Add(this.btnAddCopy);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPublisher);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBookID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 479);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Copy";
            // 
            // rbBorrow
            // 
            this.rbBorrow.AutoSize = true;
            this.rbBorrow.Location = new System.Drawing.Point(50, 193);
            this.rbBorrow.Name = "rbBorrow";
            this.rbBorrow.Size = new System.Drawing.Size(78, 17);
            this.rbBorrow.TabIndex = 8;
            this.rbBorrow.TabStop = true;
            this.rbBorrow.Text = "Borrowable";
            this.rbBorrow.UseVisualStyleBackColor = true;
            // 
            // rbRef
            // 
            this.rbRef.AutoSize = true;
            this.rbRef.Location = new System.Drawing.Point(50, 157);
            this.rbRef.Name = "rbRef";
            this.rbRef.Size = new System.Drawing.Size(75, 17);
            this.rbRef.TabIndex = 7;
            this.rbRef.TabStop = true;
            this.rbRef.Text = "Reference";
            this.rbRef.UseVisualStyleBackColor = true;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(9, 236);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(233, 45);
            this.btnAddCopy.TabIndex = 6;
            this.btnAddCopy.Text = "Add Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(9, 101);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(233, 20);
            this.txtPublisher.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Publisher";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(9, 52);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(233, 20);
            this.txtBookID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvBorrow);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1030, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Borrow";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelStatus);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateReturn);
            this.groupBox3.Controls.Add(this.dateBorrow);
            this.groupBox3.Controls.Add(this.btnBorrow);
            this.groupBox3.Controls.Add(this.btnCheck);
            this.groupBox3.Controls.Add(this.txtRemarks);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBorrowBookId);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBorrowUserId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 479);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Borrow";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(95, 393);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(19, 20);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "  ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Return Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Borrow Date";
            // 
            // dateReturn
            // 
            this.dateReturn.Location = new System.Drawing.Point(9, 203);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(200, 20);
            this.dateReturn.TabIndex = 9;
            // 
            // dateBorrow
            // 
            this.dateBorrow.Location = new System.Drawing.Point(9, 151);
            this.dateBorrow.Name = "dateBorrow";
            this.dateBorrow.Size = new System.Drawing.Size(200, 20);
            this.dateBorrow.TabIndex = 8;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Enabled = false;
            this.btnBorrow.Location = new System.Drawing.Point(9, 428);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(233, 45);
            this.btnBorrow.TabIndex = 7;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(9, 330);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(233, 45);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(9, 251);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(233, 67);
            this.txtRemarks.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Remakrs";
            // 
            // txtBorrowBookId
            // 
            this.txtBorrowBookId.Location = new System.Drawing.Point(9, 101);
            this.txtBorrowBookId.Name = "txtBorrowBookId";
            this.txtBorrowBookId.Size = new System.Drawing.Size(233, 20);
            this.txtBorrowBookId.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Book ID";
            // 
            // txtBorrowUserId
            // 
            this.txtBorrowUserId.Location = new System.Drawing.Point(9, 52);
            this.txtBorrowUserId.Name = "txtBorrowUserId";
            this.txtBorrowUserId.Size = new System.Drawing.Size(233, 20);
            this.txtBorrowUserId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "User ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtReturnBorrowID);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnReturn);
            this.groupBox4.Controls.Add(this.txtReturnBookID);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtReturnUserID);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(260, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 479);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Return";
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(9, 190);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(233, 45);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // txtReturnBookID
            // 
            this.txtReturnBookID.Location = new System.Drawing.Point(9, 150);
            this.txtReturnBookID.Name = "txtReturnBookID";
            this.txtReturnBookID.Size = new System.Drawing.Size(233, 20);
            this.txtReturnBookID.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Book ID";
            // 
            // txtReturnUserID
            // 
            this.txtReturnUserID.Location = new System.Drawing.Point(9, 101);
            this.txtReturnUserID.Name = "txtReturnUserID";
            this.txtReturnUserID.Size = new System.Drawing.Size(233, 20);
            this.txtReturnUserID.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "User ID";
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Location = new System.Drawing.Point(515, 7);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.Size = new System.Drawing.Size(509, 478);
            this.dgvBorrow.TabIndex = 15;
            // 
            // txtReturnBorrowID
            // 
            this.txtReturnBorrowID.Location = new System.Drawing.Point(9, 52);
            this.txtReturnBorrowID.Name = "txtReturnBorrowID";
            this.txtReturnBorrowID.Size = new System.Drawing.Size(233, 20);
            this.txtReturnBorrowID.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Borrow ID";
            // 
            // LibrarianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 556);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LibrarianDashboard";
            this.Text = "LibrarianDashboard";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopy)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCopy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbBorrow;
        private System.Windows.Forms.RadioButton rbRef;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.DateTimePicker dateBorrow;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBorrowBookId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBorrowUserId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtReturnBookID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtReturnUserID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.TextBox txtReturnBorrowID;
        private System.Windows.Forms.Label label13;
    }
}