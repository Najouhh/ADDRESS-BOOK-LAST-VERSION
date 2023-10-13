namespace ADDRESS_BOOK_LAST_VERSION
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Namnbox = new TextBox();
            Gatubox = new TextBox();
            nummerbox = new TextBox();
            ortbox = new TextBox();
            telefonbox = new TextBox();
            epostbox = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            searchbtn = new Button();
            searchbox = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(226, 3);
            label1.Name = "label1";
            label1.Size = new Size(250, 50);
            label1.TabIndex = 0;
            label1.Text = "Adressbok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 62);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Namn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 100);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Gatu adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 136);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 3;
            label4.Text = "Postnummer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 173);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Post ort";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 213);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefon";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 252);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 6;
            label7.Text = "Epost";
            // 
            // Namnbox
            // 
            Namnbox.Location = new Point(173, 57);
            Namnbox.Name = "Namnbox";
            Namnbox.Size = new Size(125, 27);
            Namnbox.TabIndex = 7;
            // 
            // Gatubox
            // 
            Gatubox.Location = new Point(173, 97);
            Gatubox.Name = "Gatubox";
            Gatubox.Size = new Size(125, 27);
            Gatubox.TabIndex = 8;
            // 
            // nummerbox
            // 
            nummerbox.Location = new Point(173, 136);
            nummerbox.Name = "nummerbox";
            nummerbox.Size = new Size(125, 27);
            nummerbox.TabIndex = 9;
            // 
            // ortbox
            // 
            ortbox.Location = new Point(173, 173);
            ortbox.Name = "ortbox";
            ortbox.Size = new Size(125, 27);
            ortbox.TabIndex = 10;
            // 
            // telefonbox
            // 
            telefonbox.Location = new Point(173, 213);
            telefonbox.Name = "telefonbox";
            telefonbox.Size = new Size(125, 27);
            telefonbox.TabIndex = 11;
            // 
            // epostbox
            // 
            epostbox.Location = new Point(173, 249);
            epostbox.Name = "epostbox";
            epostbox.Size = new Size(125, 27);
            epostbox.TabIndex = 12;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(339, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 188);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Namn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.HeaderText = "Gatuadress";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Postnummer";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "postort";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefon";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Epost";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(803, 71);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(94, 29);
            searchbtn.TabIndex = 17;
            searchbtn.Text = "Sök";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(658, 71);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(125, 27);
            searchbox.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(432, 377);
            button1.Name = "button1";
            button1.Size = new Size(221, 29);
            button1.TabIndex = 19;
            button1.Text = "logga in som admin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(485, 70);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1053, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(searchbox);
            Controls.Add(searchbtn);
            Controls.Add(dataGridView1);
            Controls.Add(epostbox);
            Controls.Add(telefonbox);
            Controls.Add(ortbox);
            Controls.Add(nummerbox);
            Controls.Add(Gatubox);
            Controls.Add(Namnbox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin";
            Text = "Form1";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Namnbox;
        private TextBox Gatubox;
        private TextBox nummerbox;
        private TextBox ortbox;
        private TextBox telefonbox;
        private TextBox epostbox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button searchbtn;
        private TextBox searchbox;
        private Button button1;
        private ComboBox comboBox1;
    }
}