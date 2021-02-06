
namespace DogOnTop
{
    partial class mainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.watchPanel = new System.Windows.Forms.Panel();
            this.labelWatch = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timerWatch = new System.Windows.Forms.Timer(this.components);
            this.iconDogOnTop = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.watchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.watchPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "拖曳視窗至此置頂";
            // 
            // watchPanel
            // 
            this.watchPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.watchPanel.Controls.Add(this.labelWatch);
            this.watchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchPanel.Location = new System.Drawing.Point(3, 23);
            this.watchPanel.Name = "watchPanel";
            this.watchPanel.Size = new System.Drawing.Size(246, 110);
            this.watchPanel.TabIndex = 0;
            // 
            // labelWatch
            // 
            this.labelWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWatch.Location = new System.Drawing.Point(0, 0);
            this.labelWatch.Name = "labelWatch";
            this.labelWatch.Size = new System.Drawing.Size(246, 110);
            this.labelWatch.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonStart.Location = new System.Drawing.Point(8, 147);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(120, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "開始置頂";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonCancel.Location = new System.Drawing.Point(134, 147);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 35);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "取消置頂";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timerWatch
            // 
            this.timerWatch.Interval = 250;
            this.timerWatch.Tick += new System.EventHandler(this.timerWatch_Tick);
            // 
            // iconDogOnTop
            // 
            this.iconDogOnTop.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconDogOnTop.BalloonTipText = "執行中...";
            this.iconDogOnTop.BalloonTipTitle = "DogOnTop";
            this.iconDogOnTop.Icon = ((System.Drawing.Icon)(resources.GetObject("iconDogOnTop.Icon")));
            this.iconDogOnTop.Text = "DogOnTop 執行中...";
            this.iconDogOnTop.DoubleClick += new System.EventHandler(this.iconDogOnTop_DoubleClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 193);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Dog On Top";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.watchPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel watchPanel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timerWatch;
        private System.Windows.Forms.Label labelWatch;
        private System.Windows.Forms.NotifyIcon iconDogOnTop;
    }
}

