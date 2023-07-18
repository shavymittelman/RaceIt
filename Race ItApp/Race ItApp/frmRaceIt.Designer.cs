namespace Race_ItApp
{
    partial class frmRaceIt
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
            tblMain = new TableLayoutPanel();
            btnStart = new Button();
            lblStatus = new Label();
            btnDie = new Button();
            tblRace = new TableLayoutPanel();
            tblRedRace = new TableLayoutPanel();
            lblRed1 = new Label();
            lblRed2 = new Label();
            lblRed3 = new Label();
            lblRed4 = new Label();
            lblRed5 = new Label();
            lblRed6 = new Label();
            lblRed7 = new Label();
            lblRed8 = new Label();
            lblRed9 = new Label();
            lblRed10 = new Label();
            lblRed11 = new Label();
            lblRed12 = new Label();
            lblRed13 = new Label();
            lblRed14 = new Label();
            lblRed15 = new Label();
            lblRed16 = new Label();
            lblRed17 = new Label();
            lblRed18 = new Label();
            lblRed19 = new Label();
            lblRed20 = new Label();
            tblBlueRace = new TableLayoutPanel();
            lblBlue1 = new Label();
            lblBlue2 = new Label();
            lblBlue3 = new Label();
            lblBlue4 = new Label();
            lblBlue5 = new Label();
            lblBlue6 = new Label();
            lblBlue7 = new Label();
            lblBlue8 = new Label();
            lblBlue9 = new Label();
            lblBlue10 = new Label();
            lblBlue11 = new Label();
            lblBlue12 = new Label();
            lblBlue13 = new Label();
            lblBlue14 = new Label();
            lblBlue15 = new Label();
            lblBlue16 = new Label();
            lblBlue17 = new Label();
            lblBlue18 = new Label();
            lblBlue19 = new Label();
            lblBlue20 = new Label();
            tblMain.SuspendLayout();
            tblRace.SuspendLayout();
            tblRedRace.SuspendLayout();
            tblBlueRace.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.BackColor = Color.Gainsboro;
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1295681F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9169426F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.2093F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.7840528F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.6393023F));
            tblMain.Controls.Add(btnStart, 1, 0);
            tblMain.Controls.Add(lblStatus, 2, 0);
            tblMain.Controls.Add(btnDie, 3, 0);
            tblMain.Controls.Add(tblRace, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4541578F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 84.545845F));
            tblMain.Size = new Size(602, 530);
            tblMain.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.ButtonHighlight;
            btnStart.Location = new Point(70, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(144, 75);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.FromArgb(192, 255, 192);
            lblStatus.BorderStyle = BorderStyle.Fixed3D;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Location = new Point(220, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(218, 81);
            lblStatus.TabIndex = 1;
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDie
            // 
            btnDie.Dock = DockStyle.Right;
            btnDie.Location = new Point(447, 3);
            btnDie.Name = "btnDie";
            btnDie.Size = new Size(80, 75);
            btnDie.TabIndex = 2;
            btnDie.Text = "Die";
            btnDie.UseVisualStyleBackColor = true;
            // 
            // tblRace
            // 
            tblRace.BackColor = Color.White;
            tblRace.ColumnCount = 3;
            tblMain.SetColumnSpan(tblRace, 5);
            tblRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.47826F));
            tblRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.043478F));
            tblRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.47826F));
            tblRace.Controls.Add(tblRedRace, 0, 0);
            tblRace.Controls.Add(tblBlueRace, 2, 0);
            tblRace.Dock = DockStyle.Fill;
            tblRace.Location = new Point(3, 84);
            tblRace.Name = "tblRace";
            tblRace.RowCount = 2;
            tblRace.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRace.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblRace.Size = new Size(596, 443);
            tblRace.TabIndex = 3;
            // 
            // tblRedRace
            // 
            tblRedRace.ColumnCount = 3;
            tblRedRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblRedRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblRedRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblRedRace.Controls.Add(lblRed1, 0, 12);
            tblRedRace.Controls.Add(lblRed2, 1, 12);
            tblRedRace.Controls.Add(lblRed3, 2, 12);
            tblRedRace.Controls.Add(lblRed4, 2, 11);
            tblRedRace.Controls.Add(lblRed5, 2, 10);
            tblRedRace.Controls.Add(lblRed6, 1, 10);
            tblRedRace.Controls.Add(lblRed7, 1, 9);
            tblRedRace.Controls.Add(lblRed8, 1, 8);
            tblRedRace.Controls.Add(lblRed9, 2, 8);
            tblRedRace.Controls.Add(lblRed10, 2, 7);
            tblRedRace.Controls.Add(lblRed11, 2, 6);
            tblRedRace.Controls.Add(lblRed12, 1, 6);
            tblRedRace.Controls.Add(lblRed13, 1, 5);
            tblRedRace.Controls.Add(lblRed14, 1, 4);
            tblRedRace.Controls.Add(lblRed15, 2, 4);
            tblRedRace.Controls.Add(lblRed16, 2, 3);
            tblRedRace.Controls.Add(lblRed17, 2, 2);
            tblRedRace.Controls.Add(lblRed18, 1, 2);
            tblRedRace.Controls.Add(lblRed19, 1, 1);
            tblRedRace.Controls.Add(lblRed20, 1, 0);
            tblRedRace.Dock = DockStyle.Fill;
            tblRedRace.Location = new Point(3, 3);
            tblRedRace.Name = "tblRedRace";
            tblRedRace.RowCount = 13;
            tblRace.SetRowSpan(tblRedRace, 2);
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblRedRace.Size = new Size(253, 437);
            tblRedRace.TabIndex = 0;
            // 
            // lblRed1
            // 
            lblRed1.AutoSize = true;
            lblRed1.BackColor = Color.Gainsboro;
            lblRed1.BorderStyle = BorderStyle.Fixed3D;
            lblRed1.Dock = DockStyle.Fill;
            lblRed1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed1.Location = new Point(3, 396);
            lblRed1.Name = "lblRed1";
            lblRed1.Size = new Size(78, 41);
            lblRed1.TabIndex = 0;
            lblRed1.Text = "1";
            lblRed1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed2
            // 
            lblRed2.AutoSize = true;
            lblRed2.BackColor = Color.Gainsboro;
            lblRed2.BorderStyle = BorderStyle.Fixed3D;
            lblRed2.Dock = DockStyle.Fill;
            lblRed2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed2.Location = new Point(87, 396);
            lblRed2.Name = "lblRed2";
            lblRed2.Size = new Size(78, 41);
            lblRed2.TabIndex = 1;
            lblRed2.Text = "2";
            lblRed2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed3
            // 
            lblRed3.AutoSize = true;
            lblRed3.BackColor = Color.Gainsboro;
            lblRed3.BorderStyle = BorderStyle.Fixed3D;
            lblRed3.Dock = DockStyle.Fill;
            lblRed3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed3.Location = new Point(171, 396);
            lblRed3.Name = "lblRed3";
            lblRed3.Size = new Size(79, 41);
            lblRed3.TabIndex = 2;
            lblRed3.Text = "3";
            lblRed3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed4
            // 
            lblRed4.AutoSize = true;
            lblRed4.BackColor = Color.Gainsboro;
            lblRed4.BorderStyle = BorderStyle.Fixed3D;
            lblRed4.Dock = DockStyle.Fill;
            lblRed4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed4.Location = new Point(171, 363);
            lblRed4.Name = "lblRed4";
            lblRed4.Size = new Size(79, 33);
            lblRed4.TabIndex = 3;
            lblRed4.Text = "4";
            lblRed4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed5
            // 
            lblRed5.AutoSize = true;
            lblRed5.BackColor = Color.Gainsboro;
            lblRed5.BorderStyle = BorderStyle.Fixed3D;
            lblRed5.Dock = DockStyle.Fill;
            lblRed5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed5.Location = new Point(171, 330);
            lblRed5.Name = "lblRed5";
            lblRed5.Size = new Size(79, 33);
            lblRed5.TabIndex = 4;
            lblRed5.Text = "5";
            lblRed5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed6
            // 
            lblRed6.AutoSize = true;
            lblRed6.BackColor = Color.Gainsboro;
            lblRed6.BorderStyle = BorderStyle.Fixed3D;
            lblRed6.Dock = DockStyle.Fill;
            lblRed6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed6.Location = new Point(87, 330);
            lblRed6.Name = "lblRed6";
            lblRed6.Size = new Size(78, 33);
            lblRed6.TabIndex = 5;
            lblRed6.Text = "6";
            lblRed6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed7
            // 
            lblRed7.AutoSize = true;
            lblRed7.BackColor = Color.Gainsboro;
            lblRed7.BorderStyle = BorderStyle.Fixed3D;
            lblRed7.Dock = DockStyle.Fill;
            lblRed7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed7.Location = new Point(87, 297);
            lblRed7.Name = "lblRed7";
            lblRed7.Size = new Size(78, 33);
            lblRed7.TabIndex = 6;
            lblRed7.Text = "7";
            lblRed7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed8
            // 
            lblRed8.AutoSize = true;
            lblRed8.BackColor = Color.Gainsboro;
            lblRed8.BorderStyle = BorderStyle.Fixed3D;
            lblRed8.Dock = DockStyle.Fill;
            lblRed8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed8.Location = new Point(87, 264);
            lblRed8.Name = "lblRed8";
            lblRed8.Size = new Size(78, 33);
            lblRed8.TabIndex = 7;
            lblRed8.Text = "8";
            lblRed8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed9
            // 
            lblRed9.AutoSize = true;
            lblRed9.BackColor = Color.Gainsboro;
            lblRed9.BorderStyle = BorderStyle.Fixed3D;
            lblRed9.Dock = DockStyle.Fill;
            lblRed9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed9.Location = new Point(171, 264);
            lblRed9.Name = "lblRed9";
            lblRed9.Size = new Size(79, 33);
            lblRed9.TabIndex = 8;
            lblRed9.Text = "9";
            lblRed9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed10
            // 
            lblRed10.AutoSize = true;
            lblRed10.BackColor = Color.Gainsboro;
            lblRed10.BorderStyle = BorderStyle.Fixed3D;
            lblRed10.Dock = DockStyle.Fill;
            lblRed10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed10.Location = new Point(171, 231);
            lblRed10.Name = "lblRed10";
            lblRed10.Size = new Size(79, 33);
            lblRed10.TabIndex = 9;
            lblRed10.Text = "10";
            lblRed10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed11
            // 
            lblRed11.AutoSize = true;
            lblRed11.BackColor = Color.Gainsboro;
            lblRed11.BorderStyle = BorderStyle.Fixed3D;
            lblRed11.Dock = DockStyle.Fill;
            lblRed11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed11.Location = new Point(171, 198);
            lblRed11.Name = "lblRed11";
            lblRed11.Size = new Size(79, 33);
            lblRed11.TabIndex = 10;
            lblRed11.Text = "11";
            lblRed11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed12
            // 
            lblRed12.AutoSize = true;
            lblRed12.BackColor = Color.Gainsboro;
            lblRed12.BorderStyle = BorderStyle.Fixed3D;
            lblRed12.Dock = DockStyle.Fill;
            lblRed12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed12.Location = new Point(87, 198);
            lblRed12.Name = "lblRed12";
            lblRed12.Size = new Size(78, 33);
            lblRed12.TabIndex = 11;
            lblRed12.Text = "12";
            lblRed12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed13
            // 
            lblRed13.AutoSize = true;
            lblRed13.BackColor = Color.Gainsboro;
            lblRed13.BorderStyle = BorderStyle.Fixed3D;
            lblRed13.Dock = DockStyle.Fill;
            lblRed13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed13.Location = new Point(87, 165);
            lblRed13.Name = "lblRed13";
            lblRed13.Size = new Size(78, 33);
            lblRed13.TabIndex = 12;
            lblRed13.Text = "13";
            lblRed13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed14
            // 
            lblRed14.AutoSize = true;
            lblRed14.BackColor = Color.Gainsboro;
            lblRed14.BorderStyle = BorderStyle.Fixed3D;
            lblRed14.Dock = DockStyle.Fill;
            lblRed14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed14.Location = new Point(87, 132);
            lblRed14.Name = "lblRed14";
            lblRed14.Size = new Size(78, 33);
            lblRed14.TabIndex = 13;
            lblRed14.Text = "14";
            lblRed14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed15
            // 
            lblRed15.AutoSize = true;
            lblRed15.BackColor = Color.Gainsboro;
            lblRed15.BorderStyle = BorderStyle.Fixed3D;
            lblRed15.Dock = DockStyle.Fill;
            lblRed15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed15.Location = new Point(171, 132);
            lblRed15.Name = "lblRed15";
            lblRed15.Size = new Size(79, 33);
            lblRed15.TabIndex = 14;
            lblRed15.Text = "15";
            lblRed15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed16
            // 
            lblRed16.AutoSize = true;
            lblRed16.BackColor = Color.Gainsboro;
            lblRed16.BorderStyle = BorderStyle.Fixed3D;
            lblRed16.Dock = DockStyle.Fill;
            lblRed16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed16.Location = new Point(171, 99);
            lblRed16.Name = "lblRed16";
            lblRed16.Size = new Size(79, 33);
            lblRed16.TabIndex = 15;
            lblRed16.Text = "16";
            lblRed16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed17
            // 
            lblRed17.AutoSize = true;
            lblRed17.BackColor = Color.Gainsboro;
            lblRed17.BorderStyle = BorderStyle.Fixed3D;
            lblRed17.Dock = DockStyle.Fill;
            lblRed17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed17.Location = new Point(171, 66);
            lblRed17.Name = "lblRed17";
            lblRed17.Size = new Size(79, 33);
            lblRed17.TabIndex = 16;
            lblRed17.Text = "17";
            lblRed17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed18
            // 
            lblRed18.AutoSize = true;
            lblRed18.BackColor = Color.Gainsboro;
            lblRed18.BorderStyle = BorderStyle.Fixed3D;
            lblRed18.Dock = DockStyle.Fill;
            lblRed18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed18.Location = new Point(87, 66);
            lblRed18.Name = "lblRed18";
            lblRed18.Size = new Size(78, 33);
            lblRed18.TabIndex = 17;
            lblRed18.Text = "18";
            lblRed18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed19
            // 
            lblRed19.AutoSize = true;
            lblRed19.BackColor = Color.Gainsboro;
            lblRed19.BorderStyle = BorderStyle.Fixed3D;
            lblRed19.Dock = DockStyle.Fill;
            lblRed19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed19.Location = new Point(87, 33);
            lblRed19.Name = "lblRed19";
            lblRed19.Size = new Size(78, 33);
            lblRed19.TabIndex = 18;
            lblRed19.Text = "19";
            lblRed19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRed20
            // 
            lblRed20.AutoSize = true;
            lblRed20.BackColor = Color.Gainsboro;
            lblRed20.BorderStyle = BorderStyle.Fixed3D;
            lblRed20.Dock = DockStyle.Fill;
            lblRed20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRed20.Location = new Point(87, 0);
            lblRed20.Name = "lblRed20";
            lblRed20.Size = new Size(78, 33);
            lblRed20.TabIndex = 19;
            lblRed20.Text = "20";
            lblRed20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblBlueRace
            // 
            tblBlueRace.ColumnCount = 3;
            tblBlueRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblBlueRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblBlueRace.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblBlueRace.Controls.Add(lblBlue1, 2, 12);
            tblBlueRace.Controls.Add(lblBlue2, 1, 12);
            tblBlueRace.Controls.Add(lblBlue3, 0, 12);
            tblBlueRace.Controls.Add(lblBlue4, 0, 11);
            tblBlueRace.Controls.Add(lblBlue5, 0, 10);
            tblBlueRace.Controls.Add(lblBlue6, 1, 10);
            tblBlueRace.Controls.Add(lblBlue7, 1, 9);
            tblBlueRace.Controls.Add(lblBlue8, 1, 8);
            tblBlueRace.Controls.Add(lblBlue9, 0, 8);
            tblBlueRace.Controls.Add(lblBlue10, 0, 7);
            tblBlueRace.Controls.Add(lblBlue11, 0, 6);
            tblBlueRace.Controls.Add(lblBlue12, 1, 6);
            tblBlueRace.Controls.Add(lblBlue13, 1, 5);
            tblBlueRace.Controls.Add(lblBlue14, 1, 4);
            tblBlueRace.Controls.Add(lblBlue15, 0, 4);
            tblBlueRace.Controls.Add(lblBlue16, 0, 3);
            tblBlueRace.Controls.Add(lblBlue17, 0, 2);
            tblBlueRace.Controls.Add(lblBlue18, 1, 2);
            tblBlueRace.Controls.Add(lblBlue19, 1, 1);
            tblBlueRace.Controls.Add(lblBlue20, 1, 0);
            tblBlueRace.Dock = DockStyle.Fill;
            tblBlueRace.Location = new Point(339, 3);
            tblBlueRace.Name = "tblBlueRace";
            tblBlueRace.RowCount = 13;
            tblRace.SetRowSpan(tblBlueRace, 2);
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tblBlueRace.Size = new Size(254, 437);
            tblBlueRace.TabIndex = 1;
            // 
            // lblBlue1
            // 
            lblBlue1.AutoSize = true;
            lblBlue1.BackColor = Color.Gainsboro;
            lblBlue1.BorderStyle = BorderStyle.Fixed3D;
            lblBlue1.Dock = DockStyle.Fill;
            lblBlue1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue1.Location = new Point(171, 396);
            lblBlue1.Name = "lblBlue1";
            lblBlue1.Size = new Size(80, 41);
            lblBlue1.TabIndex = 0;
            lblBlue1.Text = "1";
            lblBlue1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue2
            // 
            lblBlue2.AutoSize = true;
            lblBlue2.BackColor = Color.Gainsboro;
            lblBlue2.BorderStyle = BorderStyle.Fixed3D;
            lblBlue2.Dock = DockStyle.Fill;
            lblBlue2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue2.Location = new Point(87, 396);
            lblBlue2.Name = "lblBlue2";
            lblBlue2.Size = new Size(78, 41);
            lblBlue2.TabIndex = 1;
            lblBlue2.Text = "2";
            lblBlue2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue3
            // 
            lblBlue3.AutoSize = true;
            lblBlue3.BackColor = Color.Gainsboro;
            lblBlue3.BorderStyle = BorderStyle.Fixed3D;
            lblBlue3.Dock = DockStyle.Fill;
            lblBlue3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue3.Location = new Point(3, 396);
            lblBlue3.Name = "lblBlue3";
            lblBlue3.Size = new Size(78, 41);
            lblBlue3.TabIndex = 2;
            lblBlue3.Text = "3";
            lblBlue3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue4
            // 
            lblBlue4.AutoSize = true;
            lblBlue4.BackColor = Color.Gainsboro;
            lblBlue4.BorderStyle = BorderStyle.Fixed3D;
            lblBlue4.Dock = DockStyle.Fill;
            lblBlue4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue4.Location = new Point(3, 363);
            lblBlue4.Name = "lblBlue4";
            lblBlue4.Size = new Size(78, 33);
            lblBlue4.TabIndex = 3;
            lblBlue4.Text = "4";
            lblBlue4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue5
            // 
            lblBlue5.AutoSize = true;
            lblBlue5.BackColor = Color.Gainsboro;
            lblBlue5.BorderStyle = BorderStyle.Fixed3D;
            lblBlue5.Dock = DockStyle.Fill;
            lblBlue5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue5.Location = new Point(3, 330);
            lblBlue5.Name = "lblBlue5";
            lblBlue5.Size = new Size(78, 33);
            lblBlue5.TabIndex = 4;
            lblBlue5.Text = "5";
            lblBlue5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue6
            // 
            lblBlue6.AutoSize = true;
            lblBlue6.BackColor = Color.Gainsboro;
            lblBlue6.BorderStyle = BorderStyle.Fixed3D;
            lblBlue6.Dock = DockStyle.Fill;
            lblBlue6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue6.Location = new Point(87, 330);
            lblBlue6.Name = "lblBlue6";
            lblBlue6.Size = new Size(78, 33);
            lblBlue6.TabIndex = 5;
            lblBlue6.Text = "6";
            lblBlue6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue7
            // 
            lblBlue7.AutoSize = true;
            lblBlue7.BackColor = Color.Gainsboro;
            lblBlue7.BorderStyle = BorderStyle.Fixed3D;
            lblBlue7.Dock = DockStyle.Fill;
            lblBlue7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue7.Location = new Point(87, 297);
            lblBlue7.Name = "lblBlue7";
            lblBlue7.Size = new Size(78, 33);
            lblBlue7.TabIndex = 6;
            lblBlue7.Text = "7";
            lblBlue7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue8
            // 
            lblBlue8.AutoSize = true;
            lblBlue8.BackColor = Color.Gainsboro;
            lblBlue8.BorderStyle = BorderStyle.Fixed3D;
            lblBlue8.Dock = DockStyle.Fill;
            lblBlue8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue8.Location = new Point(87, 264);
            lblBlue8.Name = "lblBlue8";
            lblBlue8.Size = new Size(78, 33);
            lblBlue8.TabIndex = 7;
            lblBlue8.Text = "8";
            lblBlue8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue9
            // 
            lblBlue9.AutoSize = true;
            lblBlue9.BackColor = Color.Gainsboro;
            lblBlue9.BorderStyle = BorderStyle.Fixed3D;
            lblBlue9.Dock = DockStyle.Fill;
            lblBlue9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue9.Location = new Point(3, 264);
            lblBlue9.Name = "lblBlue9";
            lblBlue9.Size = new Size(78, 33);
            lblBlue9.TabIndex = 8;
            lblBlue9.Text = "9";
            lblBlue9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue10
            // 
            lblBlue10.AutoSize = true;
            lblBlue10.BackColor = Color.Gainsboro;
            lblBlue10.BorderStyle = BorderStyle.Fixed3D;
            lblBlue10.Dock = DockStyle.Fill;
            lblBlue10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue10.Location = new Point(3, 231);
            lblBlue10.Name = "lblBlue10";
            lblBlue10.Size = new Size(78, 33);
            lblBlue10.TabIndex = 9;
            lblBlue10.Text = "10";
            lblBlue10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue11
            // 
            lblBlue11.AutoSize = true;
            lblBlue11.BackColor = Color.Gainsboro;
            lblBlue11.BorderStyle = BorderStyle.Fixed3D;
            lblBlue11.Dock = DockStyle.Fill;
            lblBlue11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue11.Location = new Point(3, 198);
            lblBlue11.Name = "lblBlue11";
            lblBlue11.Size = new Size(78, 33);
            lblBlue11.TabIndex = 10;
            lblBlue11.Text = "11";
            lblBlue11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue12
            // 
            lblBlue12.AutoSize = true;
            lblBlue12.BackColor = Color.Gainsboro;
            lblBlue12.BorderStyle = BorderStyle.Fixed3D;
            lblBlue12.Dock = DockStyle.Fill;
            lblBlue12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue12.Location = new Point(87, 198);
            lblBlue12.Name = "lblBlue12";
            lblBlue12.Size = new Size(78, 33);
            lblBlue12.TabIndex = 11;
            lblBlue12.Text = "12";
            lblBlue12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue13
            // 
            lblBlue13.AutoSize = true;
            lblBlue13.BackColor = Color.Gainsboro;
            lblBlue13.BorderStyle = BorderStyle.Fixed3D;
            lblBlue13.Dock = DockStyle.Fill;
            lblBlue13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue13.Location = new Point(87, 165);
            lblBlue13.Name = "lblBlue13";
            lblBlue13.Size = new Size(78, 33);
            lblBlue13.TabIndex = 12;
            lblBlue13.Text = "13";
            lblBlue13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue14
            // 
            lblBlue14.AutoSize = true;
            lblBlue14.BackColor = Color.Gainsboro;
            lblBlue14.BorderStyle = BorderStyle.Fixed3D;
            lblBlue14.Dock = DockStyle.Fill;
            lblBlue14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue14.Location = new Point(87, 132);
            lblBlue14.Name = "lblBlue14";
            lblBlue14.Size = new Size(78, 33);
            lblBlue14.TabIndex = 13;
            lblBlue14.Text = "14";
            lblBlue14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue15
            // 
            lblBlue15.AutoSize = true;
            lblBlue15.BackColor = Color.Gainsboro;
            lblBlue15.BorderStyle = BorderStyle.Fixed3D;
            lblBlue15.Dock = DockStyle.Fill;
            lblBlue15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue15.Location = new Point(3, 132);
            lblBlue15.Name = "lblBlue15";
            lblBlue15.Size = new Size(78, 33);
            lblBlue15.TabIndex = 14;
            lblBlue15.Text = "15";
            lblBlue15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue16
            // 
            lblBlue16.AutoSize = true;
            lblBlue16.BackColor = Color.Gainsboro;
            lblBlue16.BorderStyle = BorderStyle.Fixed3D;
            lblBlue16.Dock = DockStyle.Fill;
            lblBlue16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue16.Location = new Point(3, 99);
            lblBlue16.Name = "lblBlue16";
            lblBlue16.Size = new Size(78, 33);
            lblBlue16.TabIndex = 15;
            lblBlue16.Text = "16";
            lblBlue16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue17
            // 
            lblBlue17.AutoSize = true;
            lblBlue17.BackColor = Color.Gainsboro;
            lblBlue17.BorderStyle = BorderStyle.Fixed3D;
            lblBlue17.Dock = DockStyle.Fill;
            lblBlue17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue17.Location = new Point(3, 66);
            lblBlue17.Name = "lblBlue17";
            lblBlue17.Size = new Size(78, 33);
            lblBlue17.TabIndex = 16;
            lblBlue17.Text = "17";
            lblBlue17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue18
            // 
            lblBlue18.AutoSize = true;
            lblBlue18.BackColor = Color.Gainsboro;
            lblBlue18.BorderStyle = BorderStyle.Fixed3D;
            lblBlue18.Dock = DockStyle.Fill;
            lblBlue18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue18.Location = new Point(87, 66);
            lblBlue18.Name = "lblBlue18";
            lblBlue18.Size = new Size(78, 33);
            lblBlue18.TabIndex = 17;
            lblBlue18.Text = "18";
            lblBlue18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue19
            // 
            lblBlue19.AutoSize = true;
            lblBlue19.BackColor = Color.Gainsboro;
            lblBlue19.BorderStyle = BorderStyle.Fixed3D;
            lblBlue19.Dock = DockStyle.Fill;
            lblBlue19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue19.Location = new Point(87, 33);
            lblBlue19.Name = "lblBlue19";
            lblBlue19.Size = new Size(78, 33);
            lblBlue19.TabIndex = 18;
            lblBlue19.Text = "19";
            lblBlue19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue20
            // 
            lblBlue20.AutoSize = true;
            lblBlue20.BackColor = Color.Gainsboro;
            lblBlue20.BorderStyle = BorderStyle.Fixed3D;
            lblBlue20.Dock = DockStyle.Fill;
            lblBlue20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBlue20.Location = new Point(87, 0);
            lblBlue20.Name = "lblBlue20";
            lblBlue20.Size = new Size(78, 33);
            lblBlue20.TabIndex = 19;
            lblBlue20.Text = "20";
            lblBlue20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRaceIt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 530);
            Controls.Add(tblMain);
            Name = "frmRaceIt";
            Text = "Race It";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRace.ResumeLayout(false);
            tblRedRace.ResumeLayout(false);
            tblRedRace.PerformLayout();
            tblBlueRace.ResumeLayout(false);
            tblBlueRace.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnStart;
        private Label lblStatus;
        private Button btnDie;
        private TableLayoutPanel tblRace;
        private TableLayoutPanel tblRedRace;
        private Label lblRed1;
        private Label lblRed2;
        private Label lblRed3;
        private Label lblRed4;
        private Label lblRed5;
        private Label lblRed6;
        private Label lblRed7;
        private Label lblRed8;
        private Label lblRed9;
        private Label lblRed10;
        private Label lblRed11;
        private Label lblRed12;
        private Label lblRed13;
        private Label lblRed14;
        private Label lblRed15;
        private Label lblRed16;
        private Label lblRed17;
        private Label lblRed18;
        private Label lblRed19;
        private Label lblRed20;
        private TableLayoutPanel tblBlueRace;
        private Label lblBlue1;
        private Label lblBlue2;
        private Label lblBlue3;
        private Label lblBlue4;
        private Label lblBlue5;
        private Label lblBlue6;
        private Label lblBlue7;
        private Label lblBlue8;
        private Label lblBlue9;
        private Label lblBlue10;
        private Label lblBlue11;
        private Label lblBlue12;
        private Label lblBlue13;
        private Label lblBlue14;
        private Label lblBlue15;
        private Label lblBlue16;
        private Label lblBlue17;
        private Label lblBlue18;
        private Label lblBlue19;
        private Label lblBlue20;
    }
}