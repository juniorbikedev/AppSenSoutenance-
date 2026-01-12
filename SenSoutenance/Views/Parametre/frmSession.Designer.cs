namespace SenSoutenance.Views.Parametre
{
    partial class frmSession
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
            this.dgSession = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.txtRSession = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRanneeAcademique = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSession
            // 
            this.dgSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSession.Location = new System.Drawing.Point(298, 88);
            this.dgSession.Name = "dgSession";
            this.dgSession.RowHeadersWidth = 62;
            this.dgSession.RowTemplate.Height = 28;
            this.dgSession.Size = new System.Drawing.Size(768, 516);
            this.dgSession.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(146, 558);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 39);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "&Supprimer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 488);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 39);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(146, 418);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 39);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(130, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(142, 39);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Annee Academique";
            // 
            // txtSession
            // 
            this.txtSession.Location = new System.Drawing.Point(12, 111);
            this.txtSession.Name = "txtSession";
            this.txtSession.Size = new System.Drawing.Size(260, 26);
            this.txtSession.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Session";
            // 
            // cbAnneeAcademique
            // 
            this.cbAnneeAcademique.FormattingEnabled = true;
            this.cbAnneeAcademique.Location = new System.Drawing.Point(13, 201);
            this.cbAnneeAcademique.Name = "cbAnneeAcademique";
            this.cbAnneeAcademique.Size = new System.Drawing.Size(260, 28);
            this.cbAnneeAcademique.TabIndex = 15;
            // 
            // txtRSession
            // 
            this.txtRSession.Location = new System.Drawing.Point(333, 32);
            this.txtRSession.Name = "txtRSession";
            this.txtRSession.Size = new System.Drawing.Size(226, 26);
            this.txtRSession.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Session";
            // 
            // txtRanneeAcademique
            // 
            this.txtRanneeAcademique.Location = new System.Drawing.Point(611, 32);
            this.txtRanneeAcademique.Name = "txtRanneeAcademique";
            this.txtRanneeAcademique.Size = new System.Drawing.Size(226, 26);
            this.txtRanneeAcademique.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(607, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Annee Academique";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(904, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 39);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRanneeAcademique);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAnneeAcademique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgSession);
            this.Name = "frmSession";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.frmSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSession;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnneeAcademique;
        private System.Windows.Forms.TextBox txtRSession;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRanneeAcademique;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
    }
}