namespace Oscilloscopemodoki
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_com = new System.Windows.Forms.Label();
            this.pb_graph = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cmb_com_portname = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbl_v = new System.Windows.Forms.Label();
            this.lbl_ad_value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_temperature = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_use_lpf = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_temperature_lpf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(10, 15);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(32, 12);
            this.lbl_com.TabIndex = 0;
            this.lbl_com.Text = "COM:";
            // 
            // pb_graph
            // 
            this.pb_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_graph.BackColor = System.Drawing.SystemColors.Window;
            this.pb_graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_graph.Location = new System.Drawing.Point(14, 39);
            this.pb_graph.Name = "pb_graph";
            this.pb_graph.Size = new System.Drawing.Size(758, 510);
            this.pb_graph.TabIndex = 1;
            this.pb_graph.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cmb_com_portname
            // 
            this.cmb_com_portname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_com_portname.FormattingEnabled = true;
            this.cmb_com_portname.Location = new System.Drawing.Point(48, 12);
            this.cmb_com_portname.Name = "cmb_com_portname";
            this.cmb_com_portname.Size = new System.Drawing.Size(121, 20);
            this.cmb_com_portname.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(175, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_v
            // 
            this.lbl_v.AutoSize = true;
            this.lbl_v.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_v.Location = new System.Drawing.Point(15, 41);
            this.lbl_v.Name = "lbl_v";
            this.lbl_v.Size = new System.Drawing.Size(15, 12);
            this.lbl_v.TabIndex = 4;
            this.lbl_v.Text = "V:";
            // 
            // lbl_ad_value
            // 
            this.lbl_ad_value.AutoSize = true;
            this.lbl_ad_value.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_ad_value.Location = new System.Drawing.Point(28, 41);
            this.lbl_ad_value.Name = "lbl_ad_value";
            this.lbl_ad_value.Size = new System.Drawing.Size(11, 12);
            this.lbl_ad_value.TabIndex = 5;
            this.lbl_ad_value.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(391, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "t";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_temperature
            // 
            this.lbl_temperature.AutoSize = true;
            this.lbl_temperature.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_temperature.Location = new System.Drawing.Point(121, 41);
            this.lbl_temperature.Name = "lbl_temperature";
            this.lbl_temperature.Size = new System.Drawing.Size(11, 12);
            this.lbl_temperature.TabIndex = 7;
            this.lbl_temperature.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(84, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "温度:";
            // 
            // cb_use_lpf
            // 
            this.cb_use_lpf.AutoSize = true;
            this.cb_use_lpf.Location = new System.Drawing.Point(737, 14);
            this.cb_use_lpf.Name = "cb_use_lpf";
            this.cb_use_lpf.Size = new System.Drawing.Size(44, 16);
            this.cb_use_lpf.TabIndex = 9;
            this.cb_use_lpf.Text = "LPF";
            this.cb_use_lpf.UseVisualStyleBackColor = true;
            this.cb_use_lpf.CheckedChanged += new System.EventHandler(this.cb_use_lpf_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "v";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(173, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "温度(LPF):";
            this.label4.Visible = false;
            // 
            // lbl_temperature_lpf
            // 
            this.lbl_temperature_lpf.AutoSize = true;
            this.lbl_temperature_lpf.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_temperature_lpf.Enabled = false;
            this.lbl_temperature_lpf.Location = new System.Drawing.Point(238, 41);
            this.lbl_temperature_lpf.Name = "lbl_temperature_lpf";
            this.lbl_temperature_lpf.Size = new System.Drawing.Size(11, 12);
            this.lbl_temperature_lpf.TabIndex = 11;
            this.lbl_temperature_lpf.Text = "0";
            this.lbl_temperature_lpf.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_temperature_lpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_use_lpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_temperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ad_value);
            this.Controls.Add(this.lbl_v);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmb_com_portname);
            this.Controls.Add(this.pb_graph);
            this.Controls.Add(this.lbl_com);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "温度表示";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.PictureBox pb_graph;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmb_com_portname;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbl_v;
        private System.Windows.Forms.Label lbl_ad_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_temperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_use_lpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_temperature_lpf;
    }
}

