
namespace ProyectoOOIA.Ventanas.Asesor.Citas
{
    partial class frmRegistrarHorario
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tlpHorario = new System.Windows.Forms.TableLayoutPanel();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lbl800 = new System.Windows.Forms.Label();
            this.lbl830 = new System.Windows.Forms.Label();
            this.lbl900 = new System.Windows.Forms.Label();
            this.lbl930 = new System.Windows.Forms.Label();
            this.lbl1000 = new System.Windows.Forms.Label();
            this.lbl1600 = new System.Windows.Forms.Label();
            this.lbl1530 = new System.Windows.Forms.Label();
            this.lbl1500 = new System.Windows.Forms.Label();
            this.lbl1430 = new System.Windows.Forms.Label();
            this.lbl1400 = new System.Windows.Forms.Label();
            this.lbl1330 = new System.Windows.Forms.Label();
            this.lbl1300 = new System.Windows.Forms.Label();
            this.lbl1230 = new System.Windows.Forms.Label();
            this.lbl1200 = new System.Windows.Forms.Label();
            this.lbl1130 = new System.Windows.Forms.Label();
            this.lbl1100 = new System.Windows.Forms.Label();
            this.lbl1030 = new System.Windows.Forms.Label();
            this.lbl1630 = new System.Windows.Forms.Label();
            this.pnlLeyenda = new System.Windows.Forms.Panel();
            this.pbLibre = new System.Windows.Forms.Button();
            this.lblLibre = new System.Windows.Forms.Label();
            this.pbNoDisponible = new System.Windows.Forms.Button();
            this.lblNoDisponible = new System.Windows.Forms.Label();
            this.pbOcupado = new System.Windows.Forms.Button();
            this.lblOcupado = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tlpHorario.SuspendLayout();
            this.pnlLeyenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(71)))), ((int)(((byte)(123)))));
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(814, 60);
            this.pnlHeader.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::ProyectoOOIA.Properties.Resources.arrowWhite;
            this.btnBack.Location = new System.Drawing.Point(21, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 29);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHeader.Location = new System.Drawing.Point(61, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(276, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Horario de disponibilidad";
            // 
            // tlpHorario
            // 
            this.tlpHorario.ColumnCount = 6;
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tlpHorario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHorario.Controls.Add(this.lblFriday, 5, 0);
            this.tlpHorario.Controls.Add(this.lblThursday, 4, 0);
            this.tlpHorario.Controls.Add(this.lblMonday, 1, 0);
            this.tlpHorario.Controls.Add(this.lblTuesday, 2, 0);
            this.tlpHorario.Controls.Add(this.lblWednesday, 3, 0);
            this.tlpHorario.Controls.Add(this.lblHora, 0, 0);
            this.tlpHorario.Controls.Add(this.lbl800, 0, 1);
            this.tlpHorario.Controls.Add(this.lbl830, 0, 2);
            this.tlpHorario.Controls.Add(this.lbl900, 0, 3);
            this.tlpHorario.Controls.Add(this.lbl930, 0, 4);
            this.tlpHorario.Controls.Add(this.lbl1000, 0, 5);
            this.tlpHorario.Controls.Add(this.lbl1600, 0, 17);
            this.tlpHorario.Controls.Add(this.lbl1530, 0, 16);
            this.tlpHorario.Controls.Add(this.lbl1500, 0, 15);
            this.tlpHorario.Controls.Add(this.lbl1430, 0, 14);
            this.tlpHorario.Controls.Add(this.lbl1400, 0, 13);
            this.tlpHorario.Controls.Add(this.lbl1330, 0, 12);
            this.tlpHorario.Controls.Add(this.lbl1300, 0, 11);
            this.tlpHorario.Controls.Add(this.lbl1230, 0, 10);
            this.tlpHorario.Controls.Add(this.lbl1200, 0, 9);
            this.tlpHorario.Controls.Add(this.lbl1130, 0, 8);
            this.tlpHorario.Controls.Add(this.lbl1100, 0, 7);
            this.tlpHorario.Controls.Add(this.lbl1030, 0, 6);
            this.tlpHorario.Controls.Add(this.lbl1630, 0, 18);
            this.tlpHorario.Location = new System.Drawing.Point(211, 98);
            this.tlpHorario.Margin = new System.Windows.Forms.Padding(0);
            this.tlpHorario.Name = "tlpHorario";
            this.tlpHorario.RowCount = 19;
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpHorario.Size = new System.Drawing.Size(564, 401);
            this.tlpHorario.TabIndex = 20;
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblFriday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFriday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFriday.Location = new System.Drawing.Point(472, 0);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(90, 21);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Viernes";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblThursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThursday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblThursday.Location = new System.Drawing.Point(378, 0);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(90, 21);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Jueves";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMonday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMonday.Location = new System.Drawing.Point(96, 0);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(90, 21);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Lunes";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblTuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTuesday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTuesday.Location = new System.Drawing.Point(190, 0);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(90, 21);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Martes";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblWednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWednesday.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWednesday.Location = new System.Drawing.Point(284, 0);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(90, 21);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Miércoles";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHora.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHora.Location = new System.Drawing.Point(2, 0);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(90, 21);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl800
            // 
            this.lbl800.AutoSize = true;
            this.lbl800.BackColor = System.Drawing.Color.LightGreen;
            this.lbl800.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl800.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl800.Location = new System.Drawing.Point(2, 21);
            this.lbl800.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl800.Name = "lbl800";
            this.lbl800.Size = new System.Drawing.Size(90, 21);
            this.lbl800.TabIndex = 12;
            this.lbl800.Text = "8:00 am";
            this.lbl800.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl830
            // 
            this.lbl830.AutoSize = true;
            this.lbl830.BackColor = System.Drawing.Color.LightGreen;
            this.lbl830.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl830.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl830.Location = new System.Drawing.Point(2, 42);
            this.lbl830.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl830.Name = "lbl830";
            this.lbl830.Size = new System.Drawing.Size(90, 21);
            this.lbl830.TabIndex = 13;
            this.lbl830.Text = "8:30 am";
            this.lbl830.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl900
            // 
            this.lbl900.AutoSize = true;
            this.lbl900.BackColor = System.Drawing.Color.LightGreen;
            this.lbl900.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl900.Location = new System.Drawing.Point(2, 63);
            this.lbl900.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl900.Name = "lbl900";
            this.lbl900.Size = new System.Drawing.Size(90, 21);
            this.lbl900.TabIndex = 14;
            this.lbl900.Text = "9:00 am";
            this.lbl900.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl930
            // 
            this.lbl930.AutoSize = true;
            this.lbl930.BackColor = System.Drawing.Color.LightGreen;
            this.lbl930.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl930.Location = new System.Drawing.Point(2, 84);
            this.lbl930.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl930.Name = "lbl930";
            this.lbl930.Size = new System.Drawing.Size(90, 21);
            this.lbl930.TabIndex = 15;
            this.lbl930.Text = "9:30 am";
            this.lbl930.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1000
            // 
            this.lbl1000.AutoSize = true;
            this.lbl1000.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1000.Location = new System.Drawing.Point(2, 105);
            this.lbl1000.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1000.Name = "lbl1000";
            this.lbl1000.Size = new System.Drawing.Size(90, 21);
            this.lbl1000.TabIndex = 16;
            this.lbl1000.Text = "10:00 am";
            this.lbl1000.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1600
            // 
            this.lbl1600.AutoSize = true;
            this.lbl1600.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1600.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1600.Location = new System.Drawing.Point(2, 357);
            this.lbl1600.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1600.Name = "lbl1600";
            this.lbl1600.Size = new System.Drawing.Size(90, 21);
            this.lbl1600.TabIndex = 27;
            this.lbl1600.Text = "4:00 pm";
            this.lbl1600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1530
            // 
            this.lbl1530.AutoSize = true;
            this.lbl1530.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1530.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1530.Location = new System.Drawing.Point(2, 336);
            this.lbl1530.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1530.Name = "lbl1530";
            this.lbl1530.Size = new System.Drawing.Size(90, 21);
            this.lbl1530.TabIndex = 26;
            this.lbl1530.Text = "3:30 pm";
            this.lbl1530.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1500
            // 
            this.lbl1500.AutoSize = true;
            this.lbl1500.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1500.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1500.Location = new System.Drawing.Point(2, 315);
            this.lbl1500.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1500.Name = "lbl1500";
            this.lbl1500.Size = new System.Drawing.Size(90, 21);
            this.lbl1500.TabIndex = 25;
            this.lbl1500.Text = "3:00 pm";
            this.lbl1500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1430
            // 
            this.lbl1430.AutoSize = true;
            this.lbl1430.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1430.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1430.Location = new System.Drawing.Point(2, 294);
            this.lbl1430.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1430.Name = "lbl1430";
            this.lbl1430.Size = new System.Drawing.Size(90, 21);
            this.lbl1430.TabIndex = 24;
            this.lbl1430.Text = "2:30 pm";
            this.lbl1430.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1400
            // 
            this.lbl1400.AutoSize = true;
            this.lbl1400.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1400.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1400.Location = new System.Drawing.Point(2, 273);
            this.lbl1400.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1400.Name = "lbl1400";
            this.lbl1400.Size = new System.Drawing.Size(90, 21);
            this.lbl1400.TabIndex = 23;
            this.lbl1400.Text = "2:00 pm";
            this.lbl1400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1330
            // 
            this.lbl1330.AutoSize = true;
            this.lbl1330.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1330.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1330.Location = new System.Drawing.Point(2, 252);
            this.lbl1330.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1330.Name = "lbl1330";
            this.lbl1330.Size = new System.Drawing.Size(90, 21);
            this.lbl1330.TabIndex = 22;
            this.lbl1330.Text = "1:30 pm";
            this.lbl1330.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1300
            // 
            this.lbl1300.AutoSize = true;
            this.lbl1300.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1300.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1300.Location = new System.Drawing.Point(2, 231);
            this.lbl1300.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1300.Name = "lbl1300";
            this.lbl1300.Size = new System.Drawing.Size(90, 21);
            this.lbl1300.TabIndex = 21;
            this.lbl1300.Text = "1:00 pm";
            this.lbl1300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1230
            // 
            this.lbl1230.AutoSize = true;
            this.lbl1230.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1230.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1230.Location = new System.Drawing.Point(2, 210);
            this.lbl1230.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1230.Name = "lbl1230";
            this.lbl1230.Size = new System.Drawing.Size(90, 21);
            this.lbl1230.TabIndex = 20;
            this.lbl1230.Text = "12:30 pm";
            this.lbl1230.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1200
            // 
            this.lbl1200.AutoSize = true;
            this.lbl1200.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1200.Location = new System.Drawing.Point(2, 189);
            this.lbl1200.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1200.Name = "lbl1200";
            this.lbl1200.Size = new System.Drawing.Size(90, 21);
            this.lbl1200.TabIndex = 19;
            this.lbl1200.Text = "12:00 pm";
            this.lbl1200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1130
            // 
            this.lbl1130.AutoSize = true;
            this.lbl1130.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1130.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1130.Location = new System.Drawing.Point(2, 168);
            this.lbl1130.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1130.Name = "lbl1130";
            this.lbl1130.Size = new System.Drawing.Size(90, 21);
            this.lbl1130.TabIndex = 18;
            this.lbl1130.Text = "11:30 am";
            this.lbl1130.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1100
            // 
            this.lbl1100.AutoSize = true;
            this.lbl1100.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1100.Location = new System.Drawing.Point(2, 147);
            this.lbl1100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1100.Name = "lbl1100";
            this.lbl1100.Size = new System.Drawing.Size(90, 21);
            this.lbl1100.TabIndex = 17;
            this.lbl1100.Text = "11:00 am";
            this.lbl1100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1030
            // 
            this.lbl1030.AutoSize = true;
            this.lbl1030.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1030.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1030.Location = new System.Drawing.Point(2, 126);
            this.lbl1030.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1030.Name = "lbl1030";
            this.lbl1030.Size = new System.Drawing.Size(90, 21);
            this.lbl1030.TabIndex = 108;
            this.lbl1030.Text = "10:30 am";
            this.lbl1030.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1630
            // 
            this.lbl1630.AutoSize = true;
            this.lbl1630.BackColor = System.Drawing.Color.LightGreen;
            this.lbl1630.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1630.Location = new System.Drawing.Point(2, 378);
            this.lbl1630.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1630.Name = "lbl1630";
            this.lbl1630.Size = new System.Drawing.Size(90, 23);
            this.lbl1630.TabIndex = 109;
            this.lbl1630.Text = "4:30 pm";
            this.lbl1630.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLeyenda
            // 
            this.pnlLeyenda.Controls.Add(this.pbLibre);
            this.pnlLeyenda.Controls.Add(this.lblLibre);
            this.pnlLeyenda.Controls.Add(this.pbNoDisponible);
            this.pnlLeyenda.Controls.Add(this.lblNoDisponible);
            this.pnlLeyenda.Controls.Add(this.pbOcupado);
            this.pnlLeyenda.Controls.Add(this.lblOcupado);
            this.pnlLeyenda.Location = new System.Drawing.Point(21, 182);
            this.pnlLeyenda.Name = "pnlLeyenda";
            this.pnlLeyenda.Size = new System.Drawing.Size(187, 84);
            this.pnlLeyenda.TabIndex = 21;
            // 
            // pbLibre
            // 
            this.pbLibre.BackColor = System.Drawing.SystemColors.Window;
            this.pbLibre.Enabled = false;
            this.pbLibre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pbLibre.Location = new System.Drawing.Point(15, 16);
            this.pbLibre.Margin = new System.Windows.Forms.Padding(2);
            this.pbLibre.Name = "pbLibre";
            this.pbLibre.Size = new System.Drawing.Size(20, 16);
            this.pbLibre.TabIndex = 7;
            this.pbLibre.UseVisualStyleBackColor = false;
            // 
            // lblLibre
            // 
            this.lblLibre.AutoSize = true;
            this.lblLibre.Location = new System.Drawing.Point(39, 16);
            this.lblLibre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibre.Name = "lblLibre";
            this.lblLibre.Size = new System.Drawing.Size(56, 13);
            this.lblLibre.TabIndex = 4;
            this.lblLibre.Text = "Disponible";
            // 
            // pbNoDisponible
            // 
            this.pbNoDisponible.BackColor = System.Drawing.Color.DarkGray;
            this.pbNoDisponible.Enabled = false;
            this.pbNoDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pbNoDisponible.Location = new System.Drawing.Point(15, 36);
            this.pbNoDisponible.Margin = new System.Windows.Forms.Padding(2);
            this.pbNoDisponible.Name = "pbNoDisponible";
            this.pbNoDisponible.Size = new System.Drawing.Size(20, 16);
            this.pbNoDisponible.TabIndex = 8;
            this.pbNoDisponible.UseVisualStyleBackColor = false;
            // 
            // lblNoDisponible
            // 
            this.lblNoDisponible.AutoSize = true;
            this.lblNoDisponible.Location = new System.Drawing.Point(39, 36);
            this.lblNoDisponible.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoDisponible.Name = "lblNoDisponible";
            this.lblNoDisponible.Size = new System.Drawing.Size(71, 13);
            this.lblNoDisponible.TabIndex = 5;
            this.lblNoDisponible.Text = "No disponible";
            // 
            // pbOcupado
            // 
            this.pbOcupado.BackColor = System.Drawing.Color.DarkCyan;
            this.pbOcupado.Enabled = false;
            this.pbOcupado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pbOcupado.Location = new System.Drawing.Point(15, 56);
            this.pbOcupado.Margin = new System.Windows.Forms.Padding(2);
            this.pbOcupado.Name = "pbOcupado";
            this.pbOcupado.Size = new System.Drawing.Size(20, 16);
            this.pbOcupado.TabIndex = 9;
            this.pbOcupado.UseVisualStyleBackColor = false;
            // 
            // lblOcupado
            // 
            this.lblOcupado.AutoSize = true;
            this.lblOcupado.Location = new System.Drawing.Point(39, 56);
            this.lblOcupado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcupado.Name = "lblOcupado";
            this.lblOcupado.Size = new System.Drawing.Size(51, 13);
            this.lblOcupado.TabIndex = 6;
            this.lblOcupado.Text = "Ocupado";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(21, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(145, 36);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Font = new System.Drawing.Font("Gill Sans MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(21, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 36);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(21, 522);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(752, 23);
            this.pbCarga.TabIndex = 24;
            // 
            // frmRegistrarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 571);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pnlLeyenda);
            this.Controls.Add(this.tlpHorario);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmRegistrarHorario";
            this.Text = "frmRegistrarHorario";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tlpHorario.ResumeLayout(false);
            this.tlpHorario.PerformLayout();
            this.pnlLeyenda.ResumeLayout(false);
            this.pnlLeyenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TableLayoutPanel tlpHorario;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lbl800;
        private System.Windows.Forms.Label lbl830;
        private System.Windows.Forms.Label lbl900;
        private System.Windows.Forms.Label lbl930;
        private System.Windows.Forms.Label lbl1000;
        private System.Windows.Forms.Label lbl1600;
        private System.Windows.Forms.Label lbl1530;
        private System.Windows.Forms.Label lbl1500;
        private System.Windows.Forms.Label lbl1430;
        private System.Windows.Forms.Label lbl1400;
        private System.Windows.Forms.Label lbl1330;
        private System.Windows.Forms.Label lbl1300;
        private System.Windows.Forms.Label lbl1230;
        private System.Windows.Forms.Label lbl1200;
        private System.Windows.Forms.Label lbl1130;
        private System.Windows.Forms.Label lbl1100;
        private System.Windows.Forms.Label lbl1030;
        private System.Windows.Forms.Label lbl1630;
        private System.Windows.Forms.Panel pnlLeyenda;
        private System.Windows.Forms.Button pbLibre;
        private System.Windows.Forms.Label lblLibre;
        private System.Windows.Forms.Button pbNoDisponible;
        private System.Windows.Forms.Label lblNoDisponible;
        private System.Windows.Forms.Button pbOcupado;
        private System.Windows.Forms.Label lblOcupado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ProgressBar pbCarga;
    }
}