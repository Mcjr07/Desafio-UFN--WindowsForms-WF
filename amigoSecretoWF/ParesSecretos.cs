﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amigoSecretoWF
{
    public partial class ParesSecretos : Form
    {
        public ParesSecretos()
        {
            InitializeComponent();
            Persistencia.mostrarPares("secreto.csv", listViewSecreto);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ParesSecretos));
            listViewSecreto = new ListView();
            nome1 = new ColumnHeader();
            nome2 = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewSecreto
            // 
            listViewSecreto.BackColor = Color.Silver;
            listViewSecreto.Columns.AddRange(new ColumnHeader[] { nome1, nome2 });
            listViewSecreto.Dock = DockStyle.Fill;
            listViewSecreto.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            listViewSecreto.Location = new Point(0, 0);
            listViewSecreto.Name = "listViewSecreto";
            listViewSecreto.Size = new Size(480, 346);
            listViewSecreto.TabIndex = 1;
            listViewSecreto.UseCompatibleStateImageBehavior = false;
            listViewSecreto.View = View.Details;
            listViewSecreto.SelectedIndexChanged += listViewSecreto_SelectedIndexChanged;
            // 
            // nome1
            // 
            nome1.Text = "Amigo 1";
            nome1.Width = 200;
            // 
            // nome2
            // 
            nome2.Text = "Amigo 2";
            nome2.Width = 200;
            // 
            // ParesSecretos
            // 
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(480, 346);
            Controls.Add(listViewSecreto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ParesSecretos";
            Text = "Pares_Secreto";
            ResumeLayout(false);
        }

        private void ParesSecretos_Load(object sender, EventArgs e)
        {
        }

        private void listViewSecreto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private ListView listViewSecreto;
        private ColumnHeader nome1;
        private ColumnHeader nome2;
    }
}
