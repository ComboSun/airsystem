namespace WindowsFormsApplication1
{
    partial class CZFactoryAirSystem
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CZFactoryAirSystem));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_week = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.lbl_humidity = new System.Windows.Forms.Label();
            this.lbl_co2 = new System.Windows.Forms.Label();
            this.lbl_tvoc = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblv_pm = new System.Windows.Forms.Label();
            this.lblv_temperature = new System.Windows.Forms.Label();
            this.lblv_humidity = new System.Windows.Forms.Label();
            this.lblv_co2 = new System.Windows.Forms.Label();
            this.lblv_tvoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_con = new System.Windows.Forms.Label();
            this.lbl_eyht = new System.Windows.Forms.Label();
            this.lbl_wdshd = new System.Windows.Forms.Label();
            this.lbl_sdshd = new System.Windows.Forms.Label();
            this.lbl_tvocshd = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 580);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 140);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label20);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 500);
            this.panel1.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(250, 71);
            this.label20.TabIndex = 0;
            this.label20.Text = "制造一部设备   一区";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "设备列表";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_time);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_week);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1030, 80);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "辰竹智慧工厂环境质量监测系统";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(952, 34);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(50, 25);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(663, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "上海";
            // 
            // lbl_week
            // 
            this.lbl_week.AutoSize = true;
            this.lbl_week.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_week.ForeColor = System.Drawing.Color.White;
            this.lbl_week.Location = new System.Drawing.Point(747, 34);
            this.lbl_week.Name = "lbl_week";
            this.lbl_week.Size = new System.Drawing.Size(50, 25);
            this.lbl_week.TabIndex = 3;
            this.lbl_week.Text = "星期";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(840, 34);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(50, 25);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "日期";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(453, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "PM2.5";
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_temperature.Location = new System.Drawing.Point(832, 297);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(76, 28);
            this.lbl_temperature.TabIndex = 8;
            this.lbl_temperature.Text = "温度℃";
            this.lbl_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_humidity
            // 
            this.lbl_humidity.AutoSize = true;
            this.lbl_humidity.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_humidity.ForeColor = System.Drawing.Color.White;
            this.lbl_humidity.Location = new System.Drawing.Point(1103, 297);
            this.lbl_humidity.Name = "lbl_humidity";
            this.lbl_humidity.Size = new System.Drawing.Size(73, 28);
            this.lbl_humidity.TabIndex = 9;
            this.lbl_humidity.Text = "湿度%";
            // 
            // lbl_co2
            // 
            this.lbl_co2.AutoSize = true;
            this.lbl_co2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_co2.ForeColor = System.Drawing.Color.White;
            this.lbl_co2.Location = new System.Drawing.Point(823, 532);
            this.lbl_co2.Name = "lbl_co2";
            this.lbl_co2.Size = new System.Drawing.Size(93, 28);
            this.lbl_co2.TabIndex = 10;
            this.lbl_co2.Text = "甲醛ppb";
            // 
            // lbl_tvoc
            // 
            this.lbl_tvoc.AutoSize = true;
            this.lbl_tvoc.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tvoc.ForeColor = System.Drawing.Color.White;
            this.lbl_tvoc.Location = new System.Drawing.Point(1080, 532);
            this.lbl_tvoc.Name = "lbl_tvoc";
            this.lbl_tvoc.Size = new System.Drawing.Size(121, 28);
            this.lbl_tvoc.TabIndex = 11;
            this.lbl_tvoc.Text = "TVOC ppm";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblv_pm
            // 
            this.lblv_pm.Font = new System.Drawing.Font("微软雅黑", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblv_pm.Location = new System.Drawing.Point(420, 286);
            this.lblv_pm.Name = "lblv_pm";
            this.lblv_pm.Size = new System.Drawing.Size(160, 77);
            this.lblv_pm.TabIndex = 12;
            this.lblv_pm.Text = "288";
            this.lblv_pm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblv_temperature
            // 
            this.lblv_temperature.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblv_temperature.Location = new System.Drawing.Point(792, 160);
            this.lblv_temperature.Name = "lblv_temperature";
            this.lblv_temperature.Size = new System.Drawing.Size(156, 75);
            this.lblv_temperature.TabIndex = 13;
            this.lblv_temperature.Text = "24.2";
            this.lblv_temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblv_humidity
            // 
            this.lblv_humidity.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblv_humidity.Location = new System.Drawing.Point(1062, 160);
            this.lblv_humidity.Name = "lblv_humidity";
            this.lblv_humidity.Size = new System.Drawing.Size(156, 75);
            this.lblv_humidity.TabIndex = 14;
            this.lblv_humidity.Text = "56.0";
            this.lblv_humidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblv_co2
            // 
            this.lblv_co2.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblv_co2.Location = new System.Drawing.Point(793, 390);
            this.lblv_co2.Name = "lblv_co2";
            this.lblv_co2.Size = new System.Drawing.Size(156, 72);
            this.lblv_co2.TabIndex = 15;
            this.lblv_co2.Text = "39";
            this.lblv_co2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblv_tvoc
            // 
            this.lblv_tvoc.Font = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblv_tvoc.Location = new System.Drawing.Point(1062, 387);
            this.lblv_tvoc.Name = "lblv_tvoc";
            this.lblv_tvoc.Size = new System.Drawing.Size(156, 75);
            this.lblv_tvoc.TabIndex = 16;
            this.lblv_tvoc.Text = "0.53";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(473, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "室内";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(12, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 41);
            this.label8.TabIndex = 19;
            this.label8.Text = "=";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_con
            // 
            this.lbl_con.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_con.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_con.Location = new System.Drawing.Point(462, 380);
            this.lbl_con.Name = "lbl_con";
            this.lbl_con.Size = new System.Drawing.Size(76, 22);
            this.lbl_con.TabIndex = 20;
            this.lbl_con.Text = "严重污染";
            this.lbl_con.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_eyht
            // 
            this.lbl_eyht.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_eyht.Location = new System.Drawing.Point(823, 475);
            this.lbl_eyht.Name = "lbl_eyht";
            this.lbl_eyht.Size = new System.Drawing.Size(94, 26);
            this.lbl_eyht.TabIndex = 21;
            this.lbl_eyht.Text = "空气质量";
            this.lbl_eyht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_wdshd
            // 
            this.lbl_wdshd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_wdshd.Location = new System.Drawing.Point(821, 240);
            this.lbl_wdshd.Name = "lbl_wdshd";
            this.lbl_wdshd.Size = new System.Drawing.Size(98, 26);
            this.lbl_wdshd.TabIndex = 22;
            this.lbl_wdshd.Text = "空气质量";
            this.lbl_wdshd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sdshd
            // 
            this.lbl_sdshd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_sdshd.Location = new System.Drawing.Point(1092, 240);
            this.lbl_sdshd.Name = "lbl_sdshd";
            this.lbl_sdshd.Size = new System.Drawing.Size(96, 26);
            this.lbl_sdshd.TabIndex = 23;
            this.lbl_sdshd.Text = "空气质量";
            this.lbl_sdshd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tvocshd
            // 
            this.lbl_tvocshd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_tvocshd.Location = new System.Drawing.Point(1090, 475);
            this.lbl_tvocshd.Name = "lbl_tvocshd";
            this.lbl_tvocshd.Size = new System.Drawing.Size(98, 26);
            this.lbl_tvocshd.TabIndex = 24;
            this.lbl_tvocshd.Text = "空气质量";
            this.lbl_tvocshd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 493);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 15);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(331, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(372, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "35";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(428, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "75";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(478, 470);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "115";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(533, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 31;
            this.label11.Text = "150";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(586, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "250";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(350, 511);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "优";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(408, 511);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "良";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(450, 511);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "轻度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(507, 511);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "中度";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(562, 511);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "重度";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(615, 511);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 20);
            this.label19.TabIndex = 39;
            this.label19.Text = "严重";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(639, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "单位（μg/m³）";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // CZFactoryAirSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_tvocshd);
            this.Controls.Add(this.lbl_sdshd);
            this.Controls.Add(this.lbl_wdshd);
            this.Controls.Add(this.lbl_eyht);
            this.Controls.Add(this.lbl_con);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblv_tvoc);
            this.Controls.Add(this.lblv_co2);
            this.Controls.Add(this.lblv_humidity);
            this.Controls.Add(this.lblv_temperature);
            this.Controls.Add(this.lblv_pm);
            this.Controls.Add(this.lbl_tvoc);
            this.Controls.Add(this.lbl_co2);
            this.Controls.Add(this.lbl_humidity);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "CZFactoryAirSystem";
            this.Text = "辰竹空气质量检测系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.Label lbl_humidity;
        private System.Windows.Forms.Label lbl_co2;
        private System.Windows.Forms.Label lbl_tvoc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_week;
        private System.Windows.Forms.Label lblv_pm;
        private System.Windows.Forms.Label lblv_temperature;
        private System.Windows.Forms.Label lblv_humidity;
        private System.Windows.Forms.Label lblv_co2;
        private System.Windows.Forms.Label lblv_tvoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_con;
        private System.Windows.Forms.Label lbl_eyht;
        private System.Windows.Forms.Label lbl_wdshd;
        private System.Windows.Forms.Label lbl_sdshd;
        private System.Windows.Forms.Label lbl_tvocshd;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer3;
    }
}

