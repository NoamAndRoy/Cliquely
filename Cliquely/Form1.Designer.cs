﻿namespace Cliquely
{
    partial class Form1
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
			this.textBoxFasta = new System.Windows.Forms.TextBox();
			this.buttonSearchFasta = new System.Windows.Forms.Button();
			this.CliquesDGV = new System.Windows.Forms.DataGridView();
			this.textBoxTreshold = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBoxIsHomology = new System.Windows.Forms.CheckBox();
			this.genelnkLbl = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.CliquesDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxFasta
			// 
			this.textBoxFasta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxFasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.textBoxFasta.Location = new System.Drawing.Point(26, 61);
			this.textBoxFasta.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxFasta.Multiline = true;
			this.textBoxFasta.Name = "textBoxFasta";
			this.textBoxFasta.Size = new System.Drawing.Size(1130, 169);
			this.textBoxFasta.TabIndex = 0;
			// 
			// buttonSearchFasta
			// 
			this.buttonSearchFasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearchFasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.buttonSearchFasta.Location = new System.Drawing.Point(963, 243);
			this.buttonSearchFasta.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSearchFasta.Name = "buttonSearchFasta";
			this.buttonSearchFasta.Size = new System.Drawing.Size(193, 42);
			this.buttonSearchFasta.TabIndex = 3;
			this.buttonSearchFasta.Text = "Search cliques";
			this.buttonSearchFasta.UseVisualStyleBackColor = true;
			this.buttonSearchFasta.Click += new System.EventHandler(this.buttonSearchFasta_Click);
			// 
			// CliquesDGV
			// 
			this.CliquesDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CliquesDGV.Location = new System.Drawing.Point(26, 431);
			this.CliquesDGV.Margin = new System.Windows.Forms.Padding(4);
			this.CliquesDGV.Name = "CliquesDGV";
			this.CliquesDGV.Size = new System.Drawing.Size(1130, 291);
			this.CliquesDGV.TabIndex = 4;
			this.CliquesDGV.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.CliquesDGV_ColumnAdded);
			// 
			// textBoxTreshold
			// 
			this.textBoxTreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.textBoxTreshold.Location = new System.Drawing.Point(138, 251);
			this.textBoxTreshold.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxTreshold.Name = "textBoxTreshold";
			this.textBoxTreshold.Size = new System.Drawing.Size(320, 26);
			this.textBoxTreshold.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(217, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Fasta format sequence:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.label2.Location = new System.Drawing.Point(23, 252);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Probability:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxIsHomology
			// 
			this.checkBoxIsHomology.AutoSize = true;
			this.checkBoxIsHomology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.checkBoxIsHomology.Location = new System.Drawing.Point(26, 289);
			this.checkBoxIsHomology.Name = "checkBoxIsHomology";
			this.checkBoxIsHomology.Size = new System.Drawing.Size(175, 29);
			this.checkBoxIsHomology.TabIndex = 2;
			this.checkBoxIsHomology.Text = "Homology Gene";
			this.checkBoxIsHomology.UseVisualStyleBackColor = true;
			// 
			// genelnkLbl
			// 
			this.genelnkLbl.ActiveLinkColor = System.Drawing.Color.Blue;
			this.genelnkLbl.AutoSize = true;
			this.genelnkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.genelnkLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.genelnkLbl.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.genelnkLbl.LinkColor = System.Drawing.Color.Blue;
			this.genelnkLbl.Location = new System.Drawing.Point(24, 354);
			this.genelnkLbl.MaximumSize = new System.Drawing.Size(1133, 0);
			this.genelnkLbl.Name = "genelnkLbl";
			this.genelnkLbl.Size = new System.Drawing.Size(0, 20);
			this.genelnkLbl.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1182, 745);
			this.Controls.Add(this.checkBoxIsHomology);
			this.Controls.Add(this.genelnkLbl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxTreshold);
			this.Controls.Add(this.CliquesDGV);
			this.Controls.Add(this.buttonSearchFasta);
			this.Controls.Add(this.textBoxFasta);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MinimumSize = new System.Drawing.Size(1200, 760);
			this.Name = "Form1";
			this.Text = "Cliquely";
			((System.ComponentModel.ISupportInitialize)(this.CliquesDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFasta;
        private System.Windows.Forms.Button buttonSearchFasta;
        private System.Windows.Forms.DataGridView CliquesDGV;
        private System.Windows.Forms.TextBox textBoxTreshold;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBoxIsHomology;
		private System.Windows.Forms.LinkLabel genelnkLbl;
	}
}

