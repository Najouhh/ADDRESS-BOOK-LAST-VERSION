namespace ADDRESS_BOOK_LAST_VERSION
{
    partial class user
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
            addbtn = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            searchbox = new TextBox();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            searchbtn = new Button();
            dataGridView1 = new DataGridView();
            deletebtn = new Button();
            editbtn = new Button();
            button1 = new Button();
            epostbox = new TextBox();
            telefonbox = new TextBox();
            ortbox = new TextBox();
            nummerbox = new TextBox();
            Gatubox = new TextBox();
            Namnbox = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.Location = new Point(-98, 366);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(83, 29);
            addbtn.TabIndex = 32;
            addbtn.Text = "Lägg till";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-90, 304);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 25;
            label7.Text = "Epost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-90, 265);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 24;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-90, 225);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 23;
            label5.Text = "Post ort";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-90, 188);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 22;
            label4.Text = "Postnummer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-90, 152);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 21;
            label3.Text = "Gatu adress";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-90, 114);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 20;
            label2.Text = "Namn";
            // 
            // searchbox
            // 
            searchbox.Location = new Point(435, 125);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(125, 27);
            searchbox.TabIndex = 51;
            // 
            // Column6
            // 
            Column6.HeaderText = "Epost";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "postort";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Postnummer";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Gatuadress";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 70;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(588, 125);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(94, 29);
            searchbtn.TabIndex = 50;
            searchbtn.Text = "Sök";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(325, 172);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 188);
            dataGridView1.TabIndex = 49;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // deletebtn
            // 
            deletebtn.Location = new Point(196, 366);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(94, 29);
            deletebtn.TabIndex = 48;
            deletebtn.Text = "Radera";
            deletebtn.UseVisualStyleBackColor = true;
            deletebtn.Click += deletebtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(96, 366);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(94, 29);
            editbtn.TabIndex = 47;
            editbtn.Text = "Redigera";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(7, 366);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 46;
            button1.Text = "Lägg till";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // epostbox
            // 
            epostbox.Location = new Point(159, 301);
            epostbox.Name = "epostbox";
            epostbox.Size = new Size(125, 27);
            epostbox.TabIndex = 45;
            // 
            // telefonbox
            // 
            telefonbox.Location = new Point(159, 265);
            telefonbox.Name = "telefonbox";
            telefonbox.Size = new Size(125, 27);
            telefonbox.TabIndex = 44;
            // 
            // ortbox
            // 
            ortbox.Location = new Point(159, 225);
            ortbox.Name = "ortbox";
            ortbox.Size = new Size(125, 27);
            ortbox.TabIndex = 43;
            // 
            // nummerbox
            // 
            nummerbox.Location = new Point(159, 188);
            nummerbox.Name = "nummerbox";
            nummerbox.Size = new Size(125, 27);
            nummerbox.TabIndex = 42;
            // 
            // Gatubox
            // 
            Gatubox.Location = new Point(159, 149);
            Gatubox.Name = "Gatubox";
            Gatubox.Size = new Size(125, 27);
            Gatubox.TabIndex = 41;
            // 
            // Namnbox
            // 
            Namnbox.Location = new Point(159, 109);
            Namnbox.Name = "Namnbox";
            Namnbox.Size = new Size(125, 27);
            Namnbox.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 304);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 39;
            label1.Text = "Epost";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 265);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 38;
            label8.Text = "Telefon";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 225);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 37;
            label9.Text = "Post ort";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 188);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 36;
            label10.Text = "Postnummer";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 152);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 35;
            label11.Text = "Gatu adress";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 114);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 34;
            label12.Text = "Namn";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLight;
            label13.Location = new Point(212, 55);
            label13.Name = "label13";
            label13.Size = new Size(250, 50);
            label13.TabIndex = 33;
            label13.Text = "Adressbok";
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(searchbox);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(deletebtn);
            Controls.Add(editbtn);
            Controls.Add(button1);
            Controls.Add(epostbox);
            Controls.Add(telefonbox);
            Controls.Add(ortbox);
            Controls.Add(nummerbox);
            Controls.Add(Gatubox);
            Controls.Add(Namnbox);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(addbtn);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "user";
            Text = "user";
            Load += user_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addbtn;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox searchbox;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Button searchbtn;
        private DataGridView dataGridView1;
        private Button deletebtn;
        private Button editbtn;
        private Button button1;
        private TextBox epostbox;
        private TextBox telefonbox;
        private TextBox ortbox;
        private TextBox nummerbox;
        private TextBox Gatubox;
        private TextBox Namnbox;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}