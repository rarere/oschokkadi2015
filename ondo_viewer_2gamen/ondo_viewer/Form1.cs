using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oscilloscopemodoki
{
    public partial class Form1 : Form
    {
        Bitmap canvas;                  // 画像描画するbitmap
        Bitmap canvas2;                  // 画像描画するbitmap
        double input_data = 0.0;        // 入力値(電圧)
        double temperature = 0.0;       // 入力値(温度)
        double temperature_old = 0.0;    // A/D入力値一個古い分(線描画用)
        double temperature_lpf = 0.0;
        double temperature_old_lpf = 0.0;    // A/D入力値一個古い分(線描画用)
        int scroll_num = 5;             // グラフ横移動ピクセル数

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetGraph();
            try 
	        {
                cmb_com_portname.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                cmb_com_portname.SelectedIndex = 0;
	         }
        	catch (Exception)   
            {
                MessageBox.Show("シリアルポートが見つかりません", "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                cmb_com_portname.Enabled  = false;
                btnStart.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true) {
                timer1.Enabled = false;
                serialPort1.Close();
                btnStart.Text = "開始";
            } else {
                serialPort1.PortName = cmb_com_portname.SelectedItem.ToString();
                try
                {
                     serialPort1.Open();
                     timer1.Enabled = true;
                     btnStart.Text = "停止";
                     ResetGraph();
                }
                catch (Exception)
                {
                    MessageBox.Show("シリアルポートが開けませんでした");
                }


            }

        }

        /// <summary>
        /// グラフ描画を初期化
        /// </summary>
        private void ResetGraph() {
            canvas = new Bitmap(pb_graph.Width, pb_graph.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(Brushes.White, 0, 0, canvas.Width, canvas.Height);
            g.Dispose();
            pb_graph.Image = canvas;

            canvas2 = new Bitmap(pb_graph_lpf.Width, pb_graph_lpf.Height);
            Graphics g2 = Graphics.FromImage(canvas2);
            g2.FillRectangle(Brushes.White, 0, 0, canvas2.Width, canvas2.Height);
            g2.Dispose();
            pb_graph_lpf.Image = canvas2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Enabled = false;

            lbl_ad_value.Text = input_data.ToString();
            lbl_temperature.Text = temperature.ToString();
            lbl_temperature_lpf.Text = temperature_lpf.ToString();
            DrawGraph();

            //timer1.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            string[] spline = line.Split(',');
            input_data = double.Parse(spline[1]);
            temperature = double.Parse(spline[2]);
            temperature_lpf = double.Parse(spline[3]);
        }

        /// <summary>
        /// 波形描画
        /// </summary>
        private void DrawGraph()
        {
            int x1, x2, y1, y2;
            double plot_point, plot_point2;
            double minus_temperature = 20;

            pb_graph.Visible = false;
            pb_graph_lpf.Visible = false;

            try
            {
               
                Graphics g;
                Bitmap bmx;
                g = Graphics.FromImage(canvas);

                // 画像移動
                bmx = canvas;
                g.DrawImage(bmx, -1 * scroll_num, 0); // 左へ移動
                g.FillRectangle(Brushes.White, canvas.Width - scroll_num, 0, canvas.Width - 1, canvas.Height); // ゴミ削除用
                pb_graph.Image = bmx;

                // 軸描画
                //g.DrawLine(Pens.Black, 0, canvas.Height / 2, canvas.Width, canvas.Height / 2);

                // 表示する値
                plot_point = temperature - minus_temperature; // origin
                plot_point2 = temperature_old;
                
                // 波形描画
                x1 = pb_graph.Width - scroll_num;
                y1 = (int)((pb_graph.Height) - (plot_point2 * 49));
                x2 = pb_graph.Width - 1;
                y2 = (int)((pb_graph.Height) - (plot_point * 49));
                g.DrawLine(Pens.Red, x1, y1, x2, y2);

                g.Dispose();
                pb_graph.Image = canvas;

                // 次の線描画のために値を保存
                temperature_old = plot_point;

            }
            catch (Exception)
            {
                
            }

            try
            {

                Graphics g2;
                Bitmap bmx2;
                g2 = Graphics.FromImage(canvas2);

                // 画像移動
                bmx2 = canvas2;
                g2.DrawImage(bmx2, -1 * scroll_num, 0); // 左へ移動
                g2.FillRectangle(Brushes.White, canvas2.Width - scroll_num, 0, canvas2.Width - 1, canvas2.Height); // ゴミ削除用
                pb_graph_lpf.Image = bmx2;

                // 表示する値
                plot_point = temperature_lpf - minus_temperature; // origin
                plot_point2 = temperature_old_lpf;

                // 波形描画
                x1 = pb_graph_lpf.Width - scroll_num;
                y1 = (int)((pb_graph_lpf.Height) - (plot_point2 * 49));
                x2 = pb_graph_lpf.Width - 1;
                y2 = (int)((pb_graph_lpf.Height) - (plot_point * 49));
                g2.DrawLine(Pens.Red, x1, y1, x2, y2);

                g2.Dispose();
                pb_graph_lpf.Image = canvas2;

                // 次の線描画のために値を保存
                temperature_old_lpf = plot_point;

            }
            catch (Exception)
            {

            }

            // 表示
            pb_graph.Visible = true;
            pb_graph_lpf.Visible = true;


        }

    }
}
