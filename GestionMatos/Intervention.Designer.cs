
namespace GestionMatos
{
    partial class Intervention
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
            this.listIntr = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateIntr = new System.Windows.Forms.DateTimePicker();
            this.textCommentaire = new System.Windows.Forms.TextBox();
            this.comboMateriel = new System.Windows.Forms.ComboBox();
            this.btnAjt = new System.Windows.Forms.Button();
            this.btnUpdt = new System.Windows.Forms.Button();
            this.btnSprm = new System.Windows.Forms.Button();
            this.idIntr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listIntr
            // 
            this.listIntr.FormattingEnabled = true;
            this.listIntr.Location = new System.Drawing.Point(12, 12);
            this.listIntr.Name = "listIntr";
            this.listIntr.Size = new System.Drawing.Size(152, 225);
            this.listIntr.TabIndex = 0;
            this.listIntr.SelectedIndexChanged += new System.EventHandler(this.listIntr_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date intervention :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commentaire :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Materiel :";
            // 
            // dateIntr
            // 
            this.dateIntr.Location = new System.Drawing.Point(272, 18);
            this.dateIntr.Name = "dateIntr";
            this.dateIntr.Size = new System.Drawing.Size(200, 20);
            this.dateIntr.TabIndex = 4;
            // 
            // textCommentaire
            // 
            this.textCommentaire.Location = new System.Drawing.Point(272, 61);
            this.textCommentaire.Multiline = true;
            this.textCommentaire.Name = "textCommentaire";
            this.textCommentaire.Size = new System.Drawing.Size(200, 91);
            this.textCommentaire.TabIndex = 5;
            // 
            // comboMateriel
            // 
            this.comboMateriel.FormattingEnabled = true;
            this.comboMateriel.Location = new System.Drawing.Point(272, 167);
            this.comboMateriel.Name = "comboMateriel";
            this.comboMateriel.Size = new System.Drawing.Size(200, 21);
            this.comboMateriel.TabIndex = 6;
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(235, 214);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(75, 23);
            this.btnAjt.TabIndex = 7;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = true;
            // 
            // btnUpdt
            // 
            this.btnUpdt.Location = new System.Drawing.Point(316, 214);
            this.btnUpdt.Name = "btnUpdt";
            this.btnUpdt.Size = new System.Drawing.Size(75, 23);
            this.btnUpdt.TabIndex = 8;
            this.btnUpdt.Text = "Modifier";
            this.btnUpdt.UseVisualStyleBackColor = true;
            // 
            // btnSprm
            // 
            this.btnSprm.Location = new System.Drawing.Point(397, 214);
            this.btnSprm.Name = "btnSprm";
            this.btnSprm.Size = new System.Drawing.Size(75, 23);
            this.btnSprm.TabIndex = 9;
            this.btnSprm.Text = "Supprimer";
            this.btnSprm.UseVisualStyleBackColor = true;
            // 
            // idIntr
            // 
            this.idIntr.Location = new System.Drawing.Point(372, 188);
            this.idIntr.Name = "idIntr";
            this.idIntr.Size = new System.Drawing.Size(100, 20);
            this.idIntr.TabIndex = 10;
            this.idIntr.Visible = false;
            // 
            // Intervention
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 254);
            this.Controls.Add(this.idIntr);
            this.Controls.Add(this.btnSprm);
            this.Controls.Add(this.btnUpdt);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.comboMateriel);
            this.Controls.Add(this.textCommentaire);
            this.Controls.Add(this.dateIntr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listIntr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intervention";
            this.ShowInTaskbar = false;
            this.Text = "Intervention";
            this.Load += new System.EventHandler(this.Intervention_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listIntr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateIntr;
        private System.Windows.Forms.TextBox textCommentaire;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.Button btnUpdt;
        private System.Windows.Forms.Button btnSprm;
        private System.Windows.Forms.ComboBox comboMateriel;
        private System.Windows.Forms.TextBox idIntr;
    }
}