namespace amigoSecretoWF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button3 = new Button();
            listViewNomes = new ListView();
            nome = new ColumnHeader();
            email = new ColumnHeader();
            button4 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.AutoSize = true;
            button1.BackColor = SystemColors.Control;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(55, 193);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(91, 28);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = SystemColors.Control;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(103, 150);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(100, 28);
            button3.TabIndex = 4;
            button3.Text = "Gerar Lista";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listViewNomes
            // 
            listViewNomes.Anchor = AnchorStyles.None;
            listViewNomes.BackColor = Color.Silver;
            listViewNomes.BackgroundImageTiled = true;
            listViewNomes.BorderStyle = BorderStyle.FixedSingle;
            listViewNomes.Columns.AddRange(new ColumnHeader[] { nome, email });
            listViewNomes.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            listViewNomes.ForeColor = Color.Black;
            listViewNomes.Location = new Point(279, 98);
            listViewNomes.Margin = new Padding(3, 2, 3, 2);
            listViewNomes.Name = "listViewNomes";
            listViewNomes.Size = new Size(494, 248);
            listViewNomes.TabIndex = 9;
            listViewNomes.TileSize = new Size(1000, 1000);
            listViewNomes.UseCompatibleStateImageBehavior = false;
            listViewNomes.View = View.Details;
            listViewNomes.SelectedIndexChanged += listViewNomes_SelectedIndexChanged;
            // 
            // nome
            // 
            nome.Text = "Nome";
            nome.Width = 280;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 280;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.AutoSize = true;
            button4.BackColor = SystemColors.Control;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(155, 193);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(91, 28);
            button4.TabIndex = 10;
            button4.Text = "Limpar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.AutoSize = true;
            button2.BackColor = SystemColors.Control;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(91, 236);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(124, 28);
            button2.TabIndex = 12;
            button2.Text = "Lista Sorteada";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(852, 422);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(listViewNomes);
            Controls.Add(button3);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Georgia", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Amigo_Secreto";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private ListView listViewNomes;
        private ColumnHeader nome;
        private ColumnHeader email;
        private Button button4;
        private Button button2;
    }
}