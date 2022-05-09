namespace Evaluation_Manager
{
	partial class FrmEvaluation
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cboActivities = new System.Windows.Forms.ComboBox();
			this.txtMinForSignature = new System.Windows.Forms.TextBox();
			this.txtMinForGrade = new System.Windows.Forms.TextBox();
			this.txtActivityDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTeacher = new System.Windows.Forms.TextBox();
			this.txtEvaluationDate = new System.Windows.Forms.TextBox();
			this.numPoints = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aktivnost";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(259, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Uvjet za potpis";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(439, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Uvjet za ocjenu";
			// 
			// cboActivities
			// 
			this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboActivities.FormattingEnabled = true;
			this.cboActivities.Location = new System.Drawing.Point(26, 43);
			this.cboActivities.Name = "cboActivities";
			this.cboActivities.Size = new System.Drawing.Size(193, 21);
			this.cboActivities.TabIndex = 4;
			// 
			// txtMinForSignature
			// 
			this.txtMinForSignature.Location = new System.Drawing.Point(262, 44);
			this.txtMinForSignature.Name = "txtMinForSignature";
			this.txtMinForSignature.ReadOnly = true;
			this.txtMinForSignature.Size = new System.Drawing.Size(100, 20);
			this.txtMinForSignature.TabIndex = 5;
			this.txtMinForSignature.TextChanged += new System.EventHandler(this.txtMinForSignature_TextChanged);
			// 
			// txtMinForGrade
			// 
			this.txtMinForGrade.Location = new System.Drawing.Point(442, 44);
			this.txtMinForGrade.Name = "txtMinForGrade";
			this.txtMinForGrade.ReadOnly = true;
			this.txtMinForGrade.Size = new System.Drawing.Size(100, 20);
			this.txtMinForGrade.TabIndex = 6;
			// 
			// txtActivityDescription
			// 
			this.txtActivityDescription.Location = new System.Drawing.Point(26, 80);
			this.txtActivityDescription.Multiline = true;
			this.txtActivityDescription.Name = "txtActivityDescription";
			this.txtActivityDescription.Size = new System.Drawing.Size(516, 145);
			this.txtActivityDescription.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(200, 245);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ocjenjivač:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(324, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Datum evaluacije:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(458, 245);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Bodovi:";
			// 
			// txtTeacher
			// 
			this.txtTeacher.Location = new System.Drawing.Point(203, 271);
			this.txtTeacher.Name = "txtTeacher";
			this.txtTeacher.ReadOnly = true;
			this.txtTeacher.Size = new System.Drawing.Size(100, 20);
			this.txtTeacher.TabIndex = 11;
			// 
			// txtEvaluationDate
			// 
			this.txtEvaluationDate.Location = new System.Drawing.Point(327, 271);
			this.txtEvaluationDate.Name = "txtEvaluationDate";
			this.txtEvaluationDate.ReadOnly = true;
			this.txtEvaluationDate.Size = new System.Drawing.Size(100, 20);
			this.txtEvaluationDate.TabIndex = 12;
			// 
			// numPoints
			// 
			this.numPoints.Location = new System.Drawing.Point(461, 271);
			this.numPoints.Name = "numPoints";
			this.numPoints.Size = new System.Drawing.Size(82, 20);
			this.numPoints.TabIndex = 13;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(327, 313);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(100, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Spremi";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(461, 313);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(82, 23);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Odustani";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// FrmEvaluation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 349);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.numPoints);
			this.Controls.Add(this.txtEvaluationDate);
			this.Controls.Add(this.txtTeacher);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtActivityDescription);
			this.Controls.Add(this.txtMinForGrade);
			this.Controls.Add(this.txtMinForSignature);
			this.Controls.Add(this.cboActivities);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmEvaluation";
			this.Text = "FrmEvaluation";
			((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboActivities;
		private System.Windows.Forms.TextBox txtMinForSignature;
		private System.Windows.Forms.TextBox txtMinForGrade;
		private System.Windows.Forms.TextBox txtActivityDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTeacher;
		private System.Windows.Forms.TextBox txtEvaluationDate;
		private System.Windows.Forms.NumericUpDown numPoints;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
	}
}