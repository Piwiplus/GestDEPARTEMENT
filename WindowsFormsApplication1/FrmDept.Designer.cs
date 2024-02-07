namespace WinDEPT
{
    partial class FrmDept
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpListe = new System.Windows.Forms.TabPage();
            this.txtNbDept = new System.Windows.Forms.Label();
            this.gbInfos = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInfoSup = new System.Windows.Forms.TextBox();
            this.txtInfoRegion = new System.Windows.Forms.TextBox();
            this.txtInfoPop = new System.Windows.Forms.TextBox();
            this.txtInfoDens = new System.Windows.Forms.TextBox();
            this.txtInfoNom = new System.Windows.Forms.TextBox();
            this.txtInfoNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listDept = new System.Windows.Forms.ListBox();
            this.tbpCreation = new System.Windows.Forms.TabPage();
            this.txtRegion = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfoChef = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcPrincipal.SuspendLayout();
            this.tbpListe.SuspendLayout();
            this.gbInfos.SuspendLayout();
            this.tbpCreation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpListe);
            this.tbcPrincipal.Controls.Add(this.tbpCreation);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(577, 384);
            this.tbcPrincipal.TabIndex = 0;
            this.tbcPrincipal.SelectedIndexChanged += new System.EventHandler(this.tbcPrincipal_SelectedIndexChanged);
            // 
            // tbpListe
            // 
            this.tbpListe.Controls.Add(this.txtNbDept);
            this.tbpListe.Controls.Add(this.gbInfos);
            this.tbpListe.Controls.Add(this.label8);
            this.tbpListe.Controls.Add(this.listDept);
            this.tbpListe.Location = new System.Drawing.Point(4, 25);
            this.tbpListe.Margin = new System.Windows.Forms.Padding(4);
            this.tbpListe.Name = "tbpListe";
            this.tbpListe.Padding = new System.Windows.Forms.Padding(4);
            this.tbpListe.Size = new System.Drawing.Size(569, 355);
            this.tbpListe.TabIndex = 0;
            this.tbpListe.Text = "LISTE DEPARTEMENTS";
            this.tbpListe.UseVisualStyleBackColor = true;
            // 
            // txtNbDept
            // 
            this.txtNbDept.AutoSize = true;
            this.txtNbDept.Location = new System.Drawing.Point(28, 309);
            this.txtNbDept.Name = "txtNbDept";
            this.txtNbDept.Size = new System.Drawing.Size(169, 16);
            this.txtNbDept.TabIndex = 3;
            this.txtNbDept.Text = "0 Departement en mémoire";
            // 
            // gbInfos
            // 
            this.gbInfos.Controls.Add(this.label13);
            this.gbInfos.Controls.Add(this.label12);
            this.gbInfos.Controls.Add(this.txtInfoChef);
            this.gbInfos.Controls.Add(this.label11);
            this.gbInfos.Controls.Add(this.label10);
            this.gbInfos.Controls.Add(this.label9);
            this.gbInfos.Controls.Add(this.txtInfoSup);
            this.gbInfos.Controls.Add(this.txtInfoRegion);
            this.gbInfos.Controls.Add(this.txtInfoPop);
            this.gbInfos.Controls.Add(this.txtInfoDens);
            this.gbInfos.Controls.Add(this.txtInfoNom);
            this.gbInfos.Controls.Add(this.txtInfoNumero);
            this.gbInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfos.Location = new System.Drawing.Point(248, 65);
            this.gbInfos.Margin = new System.Windows.Forms.Padding(4);
            this.gbInfos.Name = "gbInfos";
            this.gbInfos.Padding = new System.Windows.Forms.Padding(4);
            this.gbInfos.Size = new System.Drawing.Size(308, 260);
            this.gbInfos.TabIndex = 2;
            this.gbInfos.TabStop = false;
            this.gbInfos.Text = "Informations";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Densité";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Superficie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Population";
            // 
            // txtInfoSup
            // 
            this.txtInfoSup.Location = new System.Drawing.Point(140, 113);
            this.txtInfoSup.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoSup.Name = "txtInfoSup";
            this.txtInfoSup.ReadOnly = true;
            this.txtInfoSup.Size = new System.Drawing.Size(132, 26);
            this.txtInfoSup.TabIndex = 5;
            // 
            // txtInfoRegion
            // 
            this.txtInfoRegion.Location = new System.Drawing.Point(81, 222);
            this.txtInfoRegion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoRegion.Name = "txtInfoRegion";
            this.txtInfoRegion.ReadOnly = true;
            this.txtInfoRegion.Size = new System.Drawing.Size(191, 26);
            this.txtInfoRegion.TabIndex = 4;
            // 
            // txtInfoPop
            // 
            this.txtInfoPop.Location = new System.Drawing.Point(140, 78);
            this.txtInfoPop.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoPop.Name = "txtInfoPop";
            this.txtInfoPop.ReadOnly = true;
            this.txtInfoPop.Size = new System.Drawing.Size(132, 26);
            this.txtInfoPop.TabIndex = 3;
            // 
            // txtInfoDens
            // 
            this.txtInfoDens.Location = new System.Drawing.Point(140, 150);
            this.txtInfoDens.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoDens.Name = "txtInfoDens";
            this.txtInfoDens.ReadOnly = true;
            this.txtInfoDens.Size = new System.Drawing.Size(132, 26);
            this.txtInfoDens.TabIndex = 2;
            // 
            // txtInfoNom
            // 
            this.txtInfoNom.Location = new System.Drawing.Point(61, 41);
            this.txtInfoNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoNom.Name = "txtInfoNom";
            this.txtInfoNom.ReadOnly = true;
            this.txtInfoNom.Size = new System.Drawing.Size(237, 26);
            this.txtInfoNom.TabIndex = 1;
            // 
            // txtInfoNumero
            // 
            this.txtInfoNumero.Location = new System.Drawing.Point(8, 41);
            this.txtInfoNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoNumero.Name = "txtInfoNumero";
            this.txtInfoNumero.ReadOnly = true;
            this.txtInfoNumero.Size = new System.Drawing.Size(44, 26);
            this.txtInfoNumero.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Choisir un département :";
            // 
            // listDept
            // 
            this.listDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDept.FormattingEnabled = true;
            this.listDept.ItemHeight = 18;
            this.listDept.Location = new System.Drawing.Point(28, 59);
            this.listDept.Margin = new System.Windows.Forms.Padding(4);
            this.listDept.Name = "listDept";
            this.listDept.Size = new System.Drawing.Size(192, 220);
            this.listDept.TabIndex = 0;
            this.listDept.SelectedIndexChanged += new System.EventHandler(this.listDept_SelectedIndexChanged);
            // 
            // tbpCreation
            // 
            this.tbpCreation.Controls.Add(this.txtRegion);
            this.tbpCreation.Controls.Add(this.btnValider);
            this.tbpCreation.Controls.Add(this.label7);
            this.tbpCreation.Controls.Add(this.label6);
            this.tbpCreation.Controls.Add(this.label5);
            this.tbpCreation.Controls.Add(this.txtSuperficie);
            this.tbpCreation.Controls.Add(this.txtPopulation);
            this.tbpCreation.Controls.Add(this.txtNom);
            this.tbpCreation.Controls.Add(this.txtNumero);
            this.tbpCreation.Controls.Add(this.label4);
            this.tbpCreation.Controls.Add(this.label3);
            this.tbpCreation.Controls.Add(this.label2);
            this.tbpCreation.Controls.Add(this.label1);
            this.tbpCreation.Location = new System.Drawing.Point(4, 25);
            this.tbpCreation.Margin = new System.Windows.Forms.Padding(4);
            this.tbpCreation.Name = "tbpCreation";
            this.tbpCreation.Padding = new System.Windows.Forms.Padding(4);
            this.tbpCreation.Size = new System.Drawing.Size(569, 355);
            this.tbpCreation.TabIndex = 1;
            this.tbpCreation.Text = "NOUVEAU DEPARTEMENT";
            this.tbpCreation.UseVisualStyleBackColor = true;
            this.tbpCreation.Click += new System.EventHandler(this.tbpCreation_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.txtRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRegion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtRegion.Items.AddRange(new object[] {
            "Auvergne Rhône Alpes",
            "Bretagne",
            "Grand Est",
            "Nouvelle-Aquitaine",
            "Occitanie"});
            this.txtRegion.Location = new System.Drawing.Point(128, 234);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(188, 24);
            this.txtRegion.TabIndex = 13;
            // 
            // btnValider
            // 
            this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(343, 289);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(107, 36);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "en km²";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 137);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "en milliers d\'habitants";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Région";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuperficie.Location = new System.Drawing.Point(128, 183);
            this.txtSuperficie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(96, 24);
            this.txtSuperficie.TabIndex = 7;
            // 
            // txtPopulation
            // 
            this.txtPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPopulation.Location = new System.Drawing.Point(128, 133);
            this.txtPopulation.Margin = new System.Windows.Forms.Padding(4);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(96, 24);
            this.txtPopulation.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(128, 85);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(320, 24);
            this.txtNom.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(128, 38);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 24);
            this.txtNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Superficie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // txtInfoChef
            // 
            this.txtInfoChef.Location = new System.Drawing.Point(148, 188);
            this.txtInfoChef.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfoChef.Name = "txtInfoChef";
            this.txtInfoChef.ReadOnly = true;
            this.txtInfoChef.Size = new System.Drawing.Size(124, 26);
            this.txtInfoChef.TabIndex = 9;
            this.txtInfoChef.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 191);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Chef Lieu";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 225);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Region";
            // 
            // FrmDept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 384);
            this.Controls.Add(this.tbcPrincipal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDept";
            this.Text = "APPLICATION WinDEPT";
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpListe.ResumeLayout(false);
            this.tbpListe.PerformLayout();
            this.gbInfos.ResumeLayout(false);
            this.gbInfos.PerformLayout();
            this.tbpCreation.ResumeLayout(false);
            this.tbpCreation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpListe;
        private System.Windows.Forms.TabPage tbpCreation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtPopulation;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.GroupBox gbInfos;
        private System.Windows.Forms.TextBox txtInfoNom;
        private System.Windows.Forms.TextBox txtInfoNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listDept;
        private System.Windows.Forms.TextBox txtInfoPop;
        private System.Windows.Forms.TextBox txtInfoDens;
        private System.Windows.Forms.TextBox txtInfoRegion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInfoSup;
        private System.Windows.Forms.Label txtNbDept;
        private System.Windows.Forms.TextBox txtInfoChef;
        public System.Windows.Forms.ComboBox txtRegion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

