namespace TravelAgencyApp.View
{
    partial class GestionVoyage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zoneId = new System.Windows.Forms.TextBox();
            this.zoneTitre = new System.Windows.Forms.TextBox();
            this.zoneDescription = new System.Windows.Forms.TextBox();
            this.dateDepartPicker = new System.Windows.Forms.DateTimePicker();
            this.dateRetourPicker = new System.Windows.Forms.DateTimePicker();
            this.zonePrix = new System.Windows.Forms.TextBox();
            this.zoneNbPlace = new System.Windows.Forms.TextBox();
            this.GuidecomboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.zoneDestination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 66);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(3, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 608);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de Départ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date de retour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Prix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nombre de place";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Guide";
            // 
            // zoneId
            // 
            this.zoneId.Location = new System.Drawing.Point(385, 192);
            this.zoneId.Name = "zoneId";
            this.zoneId.Size = new System.Drawing.Size(200, 22);
            this.zoneId.TabIndex = 10;
            // 
            // zoneTitre
            // 
            this.zoneTitre.Location = new System.Drawing.Point(385, 227);
            this.zoneTitre.Name = "zoneTitre";
            this.zoneTitre.Size = new System.Drawing.Size(200, 22);
            this.zoneTitre.TabIndex = 11;
            // 
            // zoneDescription
            // 
            this.zoneDescription.Location = new System.Drawing.Point(385, 263);
            this.zoneDescription.Multiline = true;
            this.zoneDescription.Name = "zoneDescription";
            this.zoneDescription.Size = new System.Drawing.Size(200, 87);
            this.zoneDescription.TabIndex = 12;
            // 
            // dateDepartPicker
            // 
            this.dateDepartPicker.Location = new System.Drawing.Point(385, 403);
            this.dateDepartPicker.Name = "dateDepartPicker";
            this.dateDepartPicker.Size = new System.Drawing.Size(200, 22);
            this.dateDepartPicker.TabIndex = 13;
            // 
            // dateRetourPicker
            // 
            this.dateRetourPicker.Location = new System.Drawing.Point(385, 436);
            this.dateRetourPicker.Name = "dateRetourPicker";
            this.dateRetourPicker.Size = new System.Drawing.Size(200, 22);
            this.dateRetourPicker.TabIndex = 14;
            // 
            // zonePrix
            // 
            this.zonePrix.Location = new System.Drawing.Point(385, 464);
            this.zonePrix.Name = "zonePrix";
            this.zonePrix.Size = new System.Drawing.Size(201, 22);
            this.zonePrix.TabIndex = 15;
            // 
            // zoneNbPlace
            // 
            this.zoneNbPlace.Location = new System.Drawing.Point(385, 500);
            this.zoneNbPlace.Name = "zoneNbPlace";
            this.zoneNbPlace.Size = new System.Drawing.Size(200, 22);
            this.zoneNbPlace.TabIndex = 16;
            // 
            // GuidecomboBox
            // 
            this.GuidecomboBox.FormattingEnabled = true;
            this.GuidecomboBox.Location = new System.Drawing.Point(385, 532);
            this.GuidecomboBox.Name = "GuidecomboBox";
            this.GuidecomboBox.Size = new System.Drawing.Size(200, 24);
            this.GuidecomboBox.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(625, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 337);
            this.dataGridView1.TabIndex = 18;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAjouter.Location = new System.Drawing.Point(251, 594);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(127, 38);
            this.btnAjouter.TabIndex = 19;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // zoneDestination
            // 
            this.zoneDestination.Location = new System.Drawing.Point(385, 367);
            this.zoneDestination.Name = "zoneDestination";
            this.zoneDestination.Size = new System.Drawing.Size(200, 22);
            this.zoneDestination.TabIndex = 21;
            // 
            // GestionVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 673);
            this.Controls.Add(this.zoneDestination);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GuidecomboBox);
            this.Controls.Add(this.zoneNbPlace);
            this.Controls.Add(this.zonePrix);
            this.Controls.Add(this.dateRetourPicker);
            this.Controls.Add(this.dateDepartPicker);
            this.Controls.Add(this.zoneDescription);
            this.Controls.Add(this.zoneTitre);
            this.Controls.Add(this.zoneId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GestionVoyage";
            this.Text = "GestionVoyage";
            this.Load += new System.EventHandler(this.GestionVoyage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox zoneId;
        private System.Windows.Forms.TextBox zoneTitre;
        private System.Windows.Forms.TextBox zoneDescription;
        private System.Windows.Forms.DateTimePicker dateDepartPicker;
        private System.Windows.Forms.DateTimePicker dateRetourPicker;
        private System.Windows.Forms.TextBox zonePrix;
        private System.Windows.Forms.TextBox zoneNbPlace;
        private System.Windows.Forms.ComboBox GuidecomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox zoneDestination;
    }
}