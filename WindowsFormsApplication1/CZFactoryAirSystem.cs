using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using Modbus.Device;
using System.Net.Sockets;
using Microsoft.Win32;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class CZFactoryAirSystem : Form
    {
        public CZFactoryAirSystem()
        {
            InitializeComponent();
            lbl_temperature.ForeColor = Color.Cyan;
            lbl_wdshd.ForeColor = Color.Cyan;
            lbl_humidity.ForeColor = Color.Gold;
            lbl_sdshd.ForeColor = Color.Gold;
            lbl_co2.ForeColor = Color.DeepPink;
            lbl_eyht.ForeColor = Color.DeepPink;
            lbl_tvoc.ForeColor = Color.RoyalBlue;
            lbl_tvocshd.ForeColor = Color.RoyalBlue;
            lblv_temperature.ForeColor = Color.Cyan;
            lblv_humidity.ForeColor = Color.Gold;
            lblv_co2.ForeColor = Color.DeepPink;
            lblv_tvoc.ForeColor = Color.RoyalBlue;
            //设置窗体的双缓冲   防止DataGridView刷新数据闪屏；
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            Type dgvType = this.dataGridView1.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(this.dataGridView1, true, null);
        }

        /* 通讯封装类实例化 */
        private ModbusDriver modbusTcpDriver = new ModbusDriver();
        /* 模拟量通讯变量定义 */
        private List<ushort> ushortdata = new List<ushort>();

        public void connnect()
        {
            /* 建立Modbus通讯连接 */
            try
            {
                /* 通讯对象初始化 */
                string strRes = modbusTcpDriver.Init("192.168.201.4", 502);
                if (strRes != "NO_ERR")
                {
                    strRes = "连接失败！请检查从站IP或电脑与从站的网络连接。";
                    WriteLog(strRes);
                    return;
                }
                else
                {
                    /* 通讯对象设置通讯参数 */
                    strRes = modbusTcpDriver.SetParam();
                }
            }
            catch (Exception ex)
            {
                //写日志
                WriteLog(ex.Message);
            }
 
        }

        /*Modbus开始读取数据*/
        private void BeginReadData()
        {
            
            try
            {
                ushortdata.Clear();
                modbusTcpDriver.ReadHoldingRegisters(Convert.ToUInt16("1065"),
                            Convert.ToUInt16("14"),
                            ref ushortdata);
                AirData ad = new AirData();
                ad.airTemperature1 = ((decimal)ushortdata[0] / 10).ToString();
                ad.airHumidity1 = ((decimal)ushortdata[1] / 10).ToString(); ;
                ad.pm251 = ushortdata[2].ToString();
                ad.cH2O1 = ushortdata[3].ToString();             
                ad.pm101 = ushortdata[4].ToString();
                ad.cO21 = ushortdata[5].ToString();
                ad.tVoc1 = ((decimal)ushortdata[6] / 10).ToString();
                ad.airTemperature2 = ((decimal)ushortdata[7] / 10).ToString();
                ad.airHumidity2 = ((decimal)ushortdata[8] / 10).ToString();
                ad.pm252 = ushortdata[9].ToString();
                ad.cH2O2 = ushortdata[10].ToString();
                ad.pm102 = ushortdata[11].ToString();
                ad.cO22 = ushortdata[12].ToString();
                ad.tVoc2 = ((decimal)ushortdata[13] / 10).ToString();
                
                string sql = string.Format(@"insert into CZFactoryAirQualitity (Area,Datetime,Tempetature,Humidity,[PM2.5],PM10,CO2,CH2O,TVOC) 
                                            values ('1','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
                                            , DateTime.Now, ad.airTemperature1, ad.airHumidity1, ad.pm251, ad.pm101, ad.cO21, ad.cH2O1, ad.tVoc1);
//                string sql1 = string.Format(@"insert into CZFactoryAirQualitity (Area,Datetime,Tempetature,Humidity,[PM2.5],PM10,CO2,CH2O,TVOC) 
//                                            values ('2','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
//                                            , DateTime.Now, ad.airTemperature2, ad.airHumidity2, ad.pm252, ad.pm102, ad.cO22, ad.cH2O2, ad.tVoc2);
                SqlUtil.ExcuteSql(sql);
                //SqlUtil.ExcuteSql(sql1);
            }
            catch (Exception estr)
            {
                //MessageBox.Show(estr.Message.ToString());
                WriteLog(estr.Message);              
                connnect();
                BeginReadData();      
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = e.Graphics;//创建画板(这里是直接写在Form窗体上了)
            gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           // Pen pen = new Pen(Color.LimeGreen,3);//画笔颜色     
            Pen pen1 = new Pen(Color.FloralWhite, 2);
            Pen pen2 = new Pen(Color.Cyan, 2);
            Pen pen3 = new Pen(Color.Gold, 2);
            Pen pen4 = new Pen(Color.DeepPink, 2);
            Pen pen5 = new Pen(Color.RoyalBlue, 2);
            //gra.DrawEllipse(pen, 590, 280, 380, 380);//画椭圆的方法，x坐标、y坐标、宽、高，如果是100，则半径为50
            gra.DrawEllipse(pen1, 390, 220, 220, 220);
            gra.DrawEllipse(pen2,780,110,180,180);
            gra.DrawEllipse(pen3, 1050, 110, 180, 180);
            gra.DrawEllipse(pen4, 780, 340, 180, 180);
            gra.DrawEllipse(pen5, 1050, 340, 180, 180);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connnect();
            try
            {
                ushortdata.Clear();
                modbusTcpDriver.ReadHoldingRegisters(Convert.ToUInt16("1065"),
                            Convert.ToUInt16("14"),
                            ref ushortdata);
                AirData ad = new AirData();
                ad.airTemperature1 = ((decimal)ushortdata[0] / 10).ToString();
                ad.airHumidity1 = ((decimal)ushortdata[1] / 10).ToString(); ;
                ad.pm251 = ushortdata[2].ToString();
                ad.cH2O1 = ushortdata[3].ToString();
                ad.pm101 = ushortdata[4].ToString();
                ad.cO21 = ushortdata[5].ToString();
                ad.tVoc1 = ((decimal)ushortdata[6] / 10).ToString();
                ad.airTemperature2 = ((decimal)ushortdata[7] / 10).ToString();
                ad.airHumidity2 = ((decimal)ushortdata[8] / 10).ToString();
                ad.pm252 = ushortdata[9].ToString();
                ad.cH2O2 = ushortdata[10].ToString();
                ad.pm102 = ushortdata[11].ToString();
                ad.cO22 = ushortdata[12].ToString();
                ad.tVoc2 = ((decimal)ushortdata[13] / 10).ToString();
       
                string sql2 = string.Format(@"insert into CZFactoryAirQualitity (Area,Datetime,Tempetature,Humidity,[PM2.5],PM10,CO2,CH2O,TVOC) 
                                            values ('1','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
                                            , DateTime.Now, ad.airTemperature1, ad.airHumidity1, ad.pm251, ad.pm101, ad.cO21, ad.cH2O1, ad.tVoc1);
//                string sql1 = string.Format(@"insert into CZFactoryAirQualitity (Area,Datetime,Tempetature,Humidity,[PM2.5],PM10,CO2,CH2O,TVOC) 
//                                            values ('2','{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
//                                            , DateTime.Now, ad.airTemperature2, ad.airHumidity2, ad.pm252, ad.pm102, ad.cO22, ad.cH2O2, ad.tVoc2);
                SqlUtil.ExcuteSql(sql2);
                //SqlUtil.ExcuteSql(sql1);
            }
            catch (Exception estr)
            {
                WriteLog(estr.Message);
                connnect();
            }

            timer3.Interval = 60000;//设置读取modbus数据时间为1分钟
            timer3.Start();

            this.KeyPreview = true;
            //查询最新一条数据结果
            string sql0 = "select top 1 [PM2.5],PM10,Tempetature,Humidity ,CO2 ,TVOC,CH2O FROM CZFactoryAirQualitity where area='1' order by datetime desc";
            SqlConnection conn0 = new SqlConnection("server=192.168.1.6;database=scz;uid=sa;pwd=flybarrier");
            SqlDataAdapter sda0 = new SqlDataAdapter(sql0, conn0);
            DataTable dt0 = new DataTable();
            sda0.Fill(dt0);
            conn0.Close();
            if (dt0 != null && dt0.Rows.Count > 0)
            {
                //1、湿度
                string sd = dt0.Rows[0]["Humidity"].ToString();
                lblv_humidity.Text = sd;
                double shidu = double.Parse(sd);
                if (shidu > 60) { lbl_sdshd.Text = "潮湿"; }
                else if (shidu >= 30 && shidu <= 60) { lbl_sdshd.Text = "正常"; }
                else if (shidu < 30) { lbl_sdshd.Text = "干燥"; }
                //2、二氧化碳-->甲醛
                string CO2 = dt0.Rows[0]["CH2O"].ToString();
                int co2 = int.Parse(CO2);
                if (co2 >= 100) { lbl_eyht.Text = "超标"; } else if (co2 < 100&&co2>0) { lbl_eyht.Text = "正常"; }
                lblv_co2.Text = CO2;
                //3、TVOC
                string tv = dt0.Rows[0]["TVOC"].ToString();
                lblv_tvoc.Text = tv;
                double tvoc = double.Parse(tv);
                if (tvoc <= 2) { lbl_tvocshd.Text = "正常"; }
                else if (tvoc > 2) { lbl_tvocshd.Text = "超标"; }
                //4、温度
                string wd = dt0.Rows[0]["Tempetature"].ToString();
                double wendu = double.Parse(wd);
                if (wendu > 12 && wendu < 19) { lbl_wdshd.Text = "凉爽"; }
                else if (wendu >= 19 && wendu <= 24) { lbl_wdshd.Text = "舒适"; }
                else if (wendu <= 12) { lbl_wdshd.Text = "寒冷"; }
                else if (wendu > 24 && wendu < 28) { lbl_wdshd.Text = "温暖"; }
                else if (wendu >= 28) { lbl_wdshd.Text = "炎热"; }
                lblv_temperature.Text = wd;
                //5、pm2.5的值
                string pm = dt0.Rows[0]["PM2.5"].ToString();
                int pm25 = int.Parse(pm);
                lblv_pm.Text = pm.ToString();
                //判断pm2.5的值大小绘制不同的颜色提醒
                if (pm25 > 0 && pm25 <= 35)
                {
                    lblv_pm.ForeColor = Color.LimeGreen;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.LimeGreen, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "优";
                }
                else if (pm25 >= 36 && pm25 <= 75)
                {
                    lblv_pm.ForeColor = Color.Yellow;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Yellow, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "良";
                }
                else if (pm25 >= 76 && pm25 <= 115)
                {
                    lblv_pm.ForeColor = Color.Orange;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Orange, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "轻度污染";
                }
                else if (pm25 >= 116 && pm25 <= 150)
                {
                    lblv_pm.ForeColor = Color.Red;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Red, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "中度污染";
                }
                else if (pm25 >= 151 && pm25 <= 250)
                {
                    lblv_pm.ForeColor = Color.Violet;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Violet, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "重度污染";
                }
                else if (pm25 > 250)
                {
                    lblv_pm.ForeColor = Color.Maroon;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Maroon, 3);
                    gra.DrawEllipse(pen, 590, 280, 380, 380);
                    lbl_con.Text = "严重污染";
                }              
            }

            //全屏显示无边框
            this.SetVisibleCore(false);
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.SetVisibleCore(true);

            //设置标题时间
            lbl_date.Text = DateTime.Now.ToShortDateString();
            lbl_week.Text = DateTime.Now.ToString("dddd");
            lbl_time.Text = DateTime.Now.ToString("t");
            timer1.Interval = 1000;
            timer1.Start();
            timer2.Interval=60000;
            timer2.Start();

            //查询数据表中最新三条记录
            string sql = string.Format(@"SELECT top 3 datetime '时间',[PM2.5],PM10,Tempetature '温度',Humidity '湿度',CO2 '二氧化碳',TVOC,CH2O 
                                         FROM CZFactoryAirQualitity where area='1' order by datetime desc");
            SqlConnection conn = new SqlConnection("server=192.168.1.6;database=scz;uid=sa;pwd=flybarrier");
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0];   
                                 
            this.dataGridView1.RowHeadersVisible = false;//datagridview前面的空白部分去除
            this.dataGridView1.AllowUserToAddRows = false;//去掉最后一行

            //设置列宽
            dataGridView1.Columns[0].Width = 192;
            dataGridView1.Columns[1].Width = 155;
            dataGridView1.Columns[2].Width = 155;
            dataGridView1.Columns[3].Width = 155;
            dataGridView1.Columns[4].Width = 155;
            dataGridView1.Columns[5].Width = 155;
            dataGridView1.Columns[6].Width = 155;
            dataGridView1.Columns[7].Width = 155;

            dataGridView1.Rows[0].Selected = false;   //取消选中第一行
            dataGridView1.ColumnHeadersHeight = 40;    //设置表头高度
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 15);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//设置标题内容居中显示; 
            foreach (DataGridViewColumn item in this.dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;//DataGridView列SortMode属性（排序模式）默认为Automatic 在此模式下，右边会预留一个小箭头
            }
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0,102,204);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;      
        }

        //定时器1刷新时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            lbl_week.Text = DateTime.Now.ToString("dddd");
            lbl_time.Text = DateTime.Now.ToString("t");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int r = 0;
            if (e.RowIndex < 0)
            {
                r = 0;
            }
            else
            {
                r = e.RowIndex;
            }
            dataGridView1.Rows[0].Selected = false;   //取消选中第一行
            dataGridView1.Rows[r].MinimumHeight = 30;
            dataGridView1.Rows[r].Cells[e.ColumnIndex].Style.Font = new Font("微软雅黑", 12);
            dataGridView1.Rows[r].DefaultCellStyle.BackColor = Color.FromArgb(0,51,102);
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //按Esc键退出
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string sql0 = "select top 1 [PM2.5],PM10,Tempetature,Humidity ,CO2 ,TVOC,CH2O FROM CZFactoryAirQualitity where area='1' order by datetime desc";
            SqlConnection conn0 = new SqlConnection("server=192.168.1.6;database=scz;uid=sa;pwd=flybarrier");
            SqlDataAdapter sda0 = new SqlDataAdapter(sql0, conn0);
            DataTable dt0 = new DataTable();
            sda0.Fill(dt0);
            conn0.Close();
            if (dt0 != null && dt0.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = false;   //取消选中第一行
                //1、湿度
                string sd = dt0.Rows[0]["Humidity"].ToString();
                lblv_humidity.Text = sd;
                double shidu = double.Parse(sd);
                if (shidu > 60) { lbl_sdshd.Text = "潮湿"; }
                else if(shidu>=30&&shidu<=60){lbl_sdshd.Text = "正常";}
                else if (shidu < 30) { lbl_sdshd.Text = "干燥"; }
                //2、甲醛
                string CO2 = dt0.Rows[0]["CH2O"].ToString();
                int co2 = int.Parse(CO2);
                if (co2 >= 100) { lbl_eyht.Text = "超标"; } else if (co2 < 100 && co2 > 0) { lbl_eyht.Text = "正常"; }
                lblv_co2.Text = CO2;
                //3、TVOC
                string tv = dt0.Rows[0]["TVOC"].ToString();
                lblv_tvoc.Text = tv;
                double tvoc = double.Parse(tv);
                if (tvoc <= 2) { lbl_tvocshd.Text = "正常"; }
                else if (tvoc > 2) { lbl_tvocshd.Text = "超标"; }
                //4、温度
                string wd = dt0.Rows[0]["Tempetature"].ToString();
                double wendu = double.Parse(wd);
                if (wendu > 12 && wendu < 19) { lbl_wdshd.Text = "凉爽"; }
                else if (wendu >= 19 && wendu <= 24) { lbl_wdshd.Text = "舒适"; }
                else if (wendu <= 12) { lbl_wdshd.Text = "寒冷"; }
                else if (wendu >24 && wendu <28) { lbl_wdshd.Text = "温暖"; }
                else if (wendu >= 28) { lbl_wdshd.Text = "炎热"; }
                lblv_temperature.Text = wd;
                //5、pm2.5的值
                string pm = dt0.Rows[0]["PM2.5"].ToString();
                int pm25= int.Parse(pm);               
                lblv_pm.Text = pm.ToString();
                //判断pm2.5的值大小绘制不同的颜色提醒
                //判断pm2.5的值大小绘制不同的颜色提醒
                if (pm25 > 0 && pm25 <= 35)
                {
                    lblv_pm.ForeColor = Color.LimeGreen;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.LimeGreen, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "优";
                }
                else if (pm25 >= 36 && pm25 <= 75)
                {
                    lblv_pm.ForeColor = Color.Yellow;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Yellow, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "良";
                }
                else if (pm25 >=76 && pm25 <= 115)
                {
                    lblv_pm.ForeColor = Color.Orange;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Orange, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "轻度污染";
                }
                else if (pm25 >= 116 && pm25 <= 150)
                {
                    lblv_pm.ForeColor = Color.Red;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Red, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "中度污染";
                }
                else if (pm25 >=151 && pm25 <= 250)
                {
                    lblv_pm.ForeColor = Color.Violet;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Violet, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "重度污染";
                }
                else if (pm25 > 250)
                {
                    lblv_pm.ForeColor = Color.Maroon;
                    Graphics gra = this.CreateGraphics();
                    Pen pen = new Pen(Color.Maroon, 3);
                    gra.DrawEllipse(pen, 400, 230, 200, 200);
                    lbl_con.Text = "严重污染";
                }                                          
            }

            //查询数据表中最新三条记录
            string sql =string.Format(@"SELECT top 3 datetime '时间',[PM2.5],PM10,Tempetature '温度',Humidity '湿度',CO2 '二氧化碳',TVOC,CH2O 
                                        FROM CZFactoryAirQualitity where area='1' order by datetime desc");
            SqlConnection conn = new SqlConnection("server=192.168.1.6;database=scz;uid=sa;pwd=flybarrier");
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);         
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            BeginReadData();
        }

        //写日志；
        public static void WriteLog(string strLog)
        {
            string LogAddress = "";
            string path = Environment.CurrentDirectory.ToString() + '\\' + "CZ_Log";
            //如果目录下无 CZsp_log 的文件夹，那么新建此文件夹
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            //如果日志文件为空，则默认在Debug目录下新建 YYYY-mm-dd_Log.log文件
            if (LogAddress == "")
            {
                LogAddress = path + '\\' +
                    DateTime.Now.Year + '-' +
                    DateTime.Now.Month + '-' +
                    DateTime.Now.Day + "_Log.log";
            }
            StreamWriter fs = new StreamWriter(LogAddress, true);
            fs.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "   ---   " + strLog);
            fs.Close();
        }
    }
}
