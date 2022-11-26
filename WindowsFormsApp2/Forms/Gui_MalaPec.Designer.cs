
namespace WindowsFormsApp2
{
    partial class Gui_MalaPec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui_MalaPec));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44891.432971064816D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44891.432971064816D, 300D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.connectedButton1 = new WindowsFormsApp2.ConnectedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sensorStatus6 = new WindowsFormsApp2.SensorStatus();
            this.sensorStatus5 = new WindowsFormsApp2.SensorStatus();
            this.sensorStatus4 = new WindowsFormsApp2.SensorStatus();
            this.sensorStatus3 = new WindowsFormsApp2.SensorStatus();
            this.sensorStatus2 = new WindowsFormsApp2.SensorStatus();
            this.sensorStatus1 = new WindowsFormsApp2.SensorStatus();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.warningManager1 = new WindowsFormsApp2.WarningManager();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label6 = new System.Windows.Forms.Label();            
            this.panelTop.SuspendLayout();
            this.groupBox1.SuspendLayout();           
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTop.Controls.Add(this.connectedButton1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.btnSettings);
            this.panelTop.Location = new System.Drawing.Point(1, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1469, 78);
            this.panelTop.TabIndex = 4;
            // 
            // connectedButton1
            // 
            this.connectedButton1.BackColor = System.Drawing.Color.Transparent;
            this.connectedButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectedButton1.BackgroundImage")));
            this.connectedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectedButton1.ConnectionStatus = -4;
            this.connectedButton1.ID = -1;
            this.connectedButton1.Location = new System.Drawing.Point(13, 26);
            this.connectedButton1.Name = "connectedButton1";
            this.connectedButton1.RefreshOriginalVal = 500;
            this.connectedButton1.Size = new System.Drawing.Size(60, 40);
            this.connectedButton1.TabIndex = 21;
            this.connectedButton1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peč PC1";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(881, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(194, 45);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Napredne Nastavitve";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Dan";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "En";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sensorStatus6);
            this.groupBox1.Controls.Add(this.sensorStatus5);
            this.groupBox1.Controls.Add(this.sensorStatus4);
            this.groupBox1.Controls.Add(this.sensorStatus3);
            this.groupBox1.Controls.Add(this.sensorStatus2);
            this.groupBox1.Controls.Add(this.sensorStatus1);
            this.groupBox1.Location = new System.Drawing.Point(682, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnostika Temp. Tipal";
            // 
            // sensorStatus6
            // 
            this.sensorStatus6.Location = new System.Drawing.Point(22, 132);
            this.sensorStatus6.Name = "sensorStatus6";
            this.sensorStatus6.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus6.TabIndex = 5;
            this.sensorStatus6.Text = "sensorStatus6";
            this.sensorStatus6.Value_PlcBit = null;
            // 
            // sensorStatus5
            // 
            this.sensorStatus5.Location = new System.Drawing.Point(22, 110);
            this.sensorStatus5.Name = "sensorStatus5";
            this.sensorStatus5.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus5.TabIndex = 4;
            this.sensorStatus5.Text = "sensorStatus5";
            this.sensorStatus5.Value_PlcBit = null;
            // 
            // sensorStatus4
            // 
            this.sensorStatus4.Location = new System.Drawing.Point(22, 88);
            this.sensorStatus4.Name = "sensorStatus4";
            this.sensorStatus4.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus4.TabIndex = 3;
            this.sensorStatus4.Text = "sensorStatus4";
            this.sensorStatus4.Value_PlcBit = null;
            // 
            // sensorStatus3
            // 
            this.sensorStatus3.Location = new System.Drawing.Point(22, 66);
            this.sensorStatus3.Name = "sensorStatus3";
            this.sensorStatus3.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus3.TabIndex = 2;
            this.sensorStatus3.Text = "sensorStatus3";
            this.sensorStatus3.Value_PlcBit = null;
            // 
            // sensorStatus2
            // 
            this.sensorStatus2.Location = new System.Drawing.Point(22, 44);
            this.sensorStatus2.Name = "sensorStatus2";
            this.sensorStatus2.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus2.TabIndex = 1;
            this.sensorStatus2.Text = "sensorStatus2";
            this.sensorStatus2.Value_PlcBit = null;
            // 
            // sensorStatus1
            // 
            this.sensorStatus1.Location = new System.Drawing.Point(22, 22);
            this.sensorStatus1.Name = "sensorStatus1";
            this.sensorStatus1.Size = new System.Drawing.Size(150, 25);
            this.sensorStatus1.TabIndex = 0;
            this.sensorStatus1.Text = "sensorStatus1";
            this.sensorStatus1.Value_PlcBit = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // warningManager1
            // 
            this.warningManager1.Location = new System.Drawing.Point(420, 496);
            this.warningManager1.Name = "warningManager1";
            this.warningManager1.ReadOnly = true;
            this.warningManager1.Size = new System.Drawing.Size(250, 170);
            this.warningManager1.TabIndex = 18;
            this.warningManager1.Text = "";
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.HeaderText = "On";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            // 
            // dataGridViewComboBoxColumn6
            // 
            this.dataGridViewComboBoxColumn6.HeaderText = "Off";
            this.dataGridViewComboBoxColumn6.Name = "dataGridViewComboBoxColumn6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Info:";            
            // 
            // Gui_MalaPec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1088, 981);            
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warningManager1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelTop);
            this.Name = "Gui_MalaPec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kontrola Peči";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label2;       
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;       
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SensorStatus sensorStatus5;
        private SensorStatus sensorStatus4;
        private SensorStatus sensorStatus3;
        private SensorStatus sensorStatus2;
        private SensorStatus sensorStatus1;
        private WarningManager warningManager1;
        private ConnectedButton connectedButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private SensorStatus sensorStatus6;
        private System.Windows.Forms.Label label6;        
    }
}