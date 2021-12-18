
namespace WindowsForm
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.subPanelFaculties = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.subPanelStaff = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.subPanelStudent = new System.Windows.Forms.Panel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.btnSt = new System.Windows.Forms.Button();
            this.subPanel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.facultiesBtn = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.Panel();
            this.loginPanel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.subPanelFaculties.SuspendLayout();
            this.subPanelStaff.SuspendLayout();
            this.subPanelStudent.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.subPanel1.SuspendLayout();
            this.footer.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.loginPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AllowDrop = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(18)))));
            this.panelSideMenu.Controls.Add(this.subPanelFaculties);
            this.panelSideMenu.Controls.Add(this.button8);
            this.panelSideMenu.Controls.Add(this.subPanelStaff);
            this.panelSideMenu.Controls.Add(this.button6);
            this.panelSideMenu.Controls.Add(this.subPanelStudent);
            this.panelSideMenu.Controls.Add(this.panelStudent);
            this.panelSideMenu.Controls.Add(this.subPanel1);
            this.panelSideMenu.Controls.Add(this.facultiesBtn);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(315, 1055);
            this.panelSideMenu.TabIndex = 8;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideMenu_Paint);
            // 
            // subPanelFaculties
            // 
            this.subPanelFaculties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.subPanelFaculties.Controls.Add(this.button13);
            this.subPanelFaculties.Controls.Add(this.button11);
            this.subPanelFaculties.Controls.Add(this.button10);
            this.subPanelFaculties.Controls.Add(this.button9);
            this.subPanelFaculties.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelFaculties.Location = new System.Drawing.Point(0, 850);
            this.subPanelFaculties.Name = "subPanelFaculties";
            this.subPanelFaculties.Size = new System.Drawing.Size(315, 208);
            this.subPanelFaculties.TabIndex = 11;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Top;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(0, 135);
            this.button13.Name = "button13";
            this.button13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button13.Size = new System.Drawing.Size(315, 45);
            this.button13.TabIndex = 8;
            this.button13.Text = "Ders Atama";
            this.button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Top;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(0, 90);
            this.button11.Name = "button11";
            this.button11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button11.Size = new System.Drawing.Size(315, 45);
            this.button11.TabIndex = 7;
            this.button11.Text = "Öğretim Görevlisi Ekle";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(0, 45);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(315, 45);
            this.button10.TabIndex = 6;
            this.button10.Text = "Öğrenci Ekle";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(315, 45);
            this.button9.TabIndex = 5;
            this.button9.Text = "Fakulte Ekle";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button8.Location = new System.Drawing.Point(0, 789);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(315, 61);
            this.button8.TabIndex = 10;
            this.button8.Text = "Fakulte İşlemleri";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // subPanelStaff
            // 
            this.subPanelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.subPanelStaff.Controls.Add(this.button7);
            this.subPanelStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelStaff.Location = new System.Drawing.Point(0, 743);
            this.subPanelStaff.Name = "subPanelStaff";
            this.subPanelStaff.Size = new System.Drawing.Size(315, 46);
            this.subPanelStaff.TabIndex = 9;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(315, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "Kişisel Bilgiler";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button6.Location = new System.Drawing.Point(0, 682);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(315, 61);
            this.button6.TabIndex = 8;
            this.button6.Text = "Öğretim Görevlisi İşlemleri";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // subPanelStudent
            // 
            this.subPanelStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.subPanelStudent.Controls.Add(this.button14);
            this.subPanelStudent.Controls.Add(this.button5);
            this.subPanelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanelStudent.Location = new System.Drawing.Point(0, 491);
            this.subPanelStudent.Name = "subPanelStudent";
            this.subPanelStudent.Size = new System.Drawing.Size(315, 191);
            this.subPanelStudent.TabIndex = 7;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.btnSt);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudent.Location = new System.Drawing.Point(0, 427);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(315, 64);
            this.panelStudent.TabIndex = 6;
            // 
            // btnSt
            // 
            this.btnSt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.btnSt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSt.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSt.FlatAppearance.BorderSize = 0;
            this.btnSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSt.Location = new System.Drawing.Point(0, 0);
            this.btnSt.Name = "btnSt";
            this.btnSt.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnSt.Size = new System.Drawing.Size(315, 61);
            this.btnSt.TabIndex = 1;
            this.btnSt.Text = "Öğrenci İşlemleri";
            this.btnSt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSt.UseVisualStyleBackColor = false;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // subPanel1
            // 
            this.subPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.subPanel1.Controls.Add(this.button12);
            this.subPanel1.Controls.Add(this.button4);
            this.subPanel1.Controls.Add(this.btnStaff);
            this.subPanel1.Controls.Add(this.btnStudent);
            this.subPanel1.Controls.Add(this.btnAdmin);
            this.subPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPanel1.Location = new System.Drawing.Point(0, 205);
            this.subPanel1.Name = "subPanel1";
            this.subPanel1.Size = new System.Drawing.Size(315, 222);
            this.subPanel1.TabIndex = 1;
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Top;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(0, 180);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(315, 45);
            this.button12.TabIndex = 6;
            this.button12.Text = "Ders Ekleme";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 45);
            this.button4.TabIndex = 5;
            this.button4.Text = "Kişisel Bilgiler";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStaff.Location = new System.Drawing.Point(0, 90);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(315, 45);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Öğretim Görevlisi Ekle";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStudent.Location = new System.Drawing.Point(0, 45);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(315, 45);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "Öğrenci Ekle";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(315, 45);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin Ekle";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click_1);
            // 
            // facultiesBtn
            // 
            this.facultiesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(25)))));
            this.facultiesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.facultiesBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.facultiesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.facultiesBtn.FlatAppearance.BorderSize = 0;
            this.facultiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facultiesBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.facultiesBtn.Location = new System.Drawing.Point(0, 144);
            this.facultiesBtn.Name = "facultiesBtn";
            this.facultiesBtn.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.facultiesBtn.Size = new System.Drawing.Size(315, 61);
            this.facultiesBtn.TabIndex = 0;
            this.facultiesBtn.Text = "Admin İşlemleri";
            this.facultiesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.facultiesBtn.UseVisualStyleBackColor = false;
            this.facultiesBtn.Click += new System.EventHandler(this.fakultelerBtn_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(315, 144);
            this.panelLogo.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.footer.Controls.Add(this.label1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(315, 1016);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(963, 39);
            this.footer.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Bilgi Sistemi";
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.layoutPanel.Controls.Add(this.loginPanel1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(315, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(963, 1016);
            this.layoutPanel.TabIndex = 10;
            this.layoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutPanel_Paint);
            // 
            // loginPanel1
            // 
            this.loginPanel1.Controls.Add(this.button1);
            this.loginPanel1.Controls.Add(this.button3);
            this.loginPanel1.Controls.Add(this.button2);
            this.loginPanel1.Location = new System.Drawing.Point(6, 12);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(1098, 670);
            this.loginPanel1.TabIndex = 1;
            this.loginPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 193);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Giriş Ekranı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 193);
            this.button3.TabIndex = 0;
            this.button3.Text = "Personel Giriş Ekranı";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 193);
            this.button2.TabIndex = 0;
            this.button2.Text = "Admin Giriş Ekranı";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(315, 45);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kişisel Bilgiler";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button14
            // 
            this.button14.Dock = System.Windows.Forms.DockStyle.Top;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button14.Location = new System.Drawing.Point(0, 45);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(315, 45);
            this.button14.TabIndex = 7;
            this.button14.Text = "Ders Seçme";
            this.button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1278, 1055);
            this.Controls.Add(this.layoutPanel);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.subPanelFaculties.ResumeLayout(false);
            this.subPanelStaff.ResumeLayout(false);
            this.subPanelStudent.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.subPanel1.ResumeLayout(false);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.loginPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button facultiesBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel layoutPanel;
        private System.Windows.Forms.Panel subPanel1;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Panel loginPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel subPanelStudent;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button btnSt;
        private System.Windows.Forms.Panel subPanelStaff;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel subPanelFaculties;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button14;
    }
}

