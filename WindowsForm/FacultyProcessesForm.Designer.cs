
namespace WindowsForm
{
    partial class FacultyProcessesForm
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
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFaculties = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtFacultyId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFaculty = new System.Windows.Forms.Button();
            this.btnDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(259, 102);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(309, 27);
            this.txtFaculty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fakulte Ekle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(143, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fakülte ekledikten sonra bölüm ekleme işlemlerini yapablirisiniz\r\n";
            // 
            // comboFaculties
            // 
            this.comboFaculties.FormattingEnabled = true;
            this.comboFaculties.Location = new System.Drawing.Point(259, 287);
            this.comboFaculties.Name = "comboFaculties";
            this.comboFaculties.Size = new System.Drawing.Size(309, 28);
            this.comboFaculties.TabIndex = 4;
            this.comboFaculties.SelectedIndexChanged += new System.EventHandler(this.comboFaculties_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fakülteler";
            // 
            // txtDep
            // 
            this.txtDep.Location = new System.Drawing.Point(259, 346);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(309, 27);
            this.txtDep.TabIndex = 6;
            // 
            // txtFacultyId
            // 
            this.txtFacultyId.Location = new System.Drawing.Point(259, 237);
            this.txtFacultyId.Name = "txtFacultyId";
            this.txtFacultyId.Size = new System.Drawing.Size(309, 27);
            this.txtFacultyId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bölüm Ekle";
            // 
            // btnFaculty
            // 
            this.btnFaculty.Location = new System.Drawing.Point(474, 144);
            this.btnFaculty.Name = "btnFaculty";
            this.btnFaculty.Size = new System.Drawing.Size(94, 29);
            this.btnFaculty.TabIndex = 8;
            this.btnFaculty.Text = "Save";
            this.btnFaculty.UseVisualStyleBackColor = true;
            this.btnFaculty.Click += new System.EventHandler(this.btnFaculty_Click);
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(478, 411);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(94, 29);
            this.btnDep.TabIndex = 8;
            this.btnDep.Text = "Save";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // FacultyProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.btnFaculty);
            this.Controls.Add(this.txtFacultyId);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFaculties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaculty);
            this.Name = "FacultyProcesses";
            this.Text = "FacultyProcesses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFaculties;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDep;
        private System.Windows.Forms.TextBox txtFacultyId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFaculty;
        private System.Windows.Forms.Button btnDep;
    }
}