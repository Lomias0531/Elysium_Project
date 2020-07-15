namespace Elysium_Project
{
    partial class StartUp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Load_Btn = new System.Windows.Forms.Button();
            this.Archive_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_Btn
            // 
            this.Start_Btn.Location = new System.Drawing.Point(51, 99);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(200, 45);
            this.Start_Btn.TabIndex = 0;
            this.Start_Btn.Text = "开始游戏";
            this.Start_Btn.UseVisualStyleBackColor = true;
            this.Start_Btn.Click += new System.EventHandler(this.start_Btn);
            // 
            // Load_Btn
            // 
            this.Load_Btn.Location = new System.Drawing.Point(51, 150);
            this.Load_Btn.Name = "Load_Btn";
            this.Load_Btn.Size = new System.Drawing.Size(200, 45);
            this.Load_Btn.TabIndex = 1;
            this.Load_Btn.Text = "读取进度";
            this.Load_Btn.UseVisualStyleBackColor = true;
            this.Load_Btn.Click += new System.EventHandler(this.load_Btn);
            // 
            // Archive_Btn
            // 
            this.Archive_Btn.Location = new System.Drawing.Point(51, 201);
            this.Archive_Btn.Name = "Archive_Btn";
            this.Archive_Btn.Size = new System.Drawing.Size(200, 45);
            this.Archive_Btn.TabIndex = 2;
            this.Archive_Btn.Text = "资料档案";
            this.Archive_Btn.UseVisualStyleBackColor = true;
            this.Archive_Btn.Click += new System.EventHandler(this.archive_Btn);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.Location = new System.Drawing.Point(51, 252);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(200, 45);
            this.Exit_Btn.TabIndex = 3;
            this.Exit_Btn.Text = "退出游戏";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.exit_Btn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elusium Project";
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.Location = new System.Drawing.Point(235, 331);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(37, 38);
            this.Settings_Btn.TabIndex = 5;
            this.Settings_Btn.UseVisualStyleBackColor = true;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.Settings_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.Archive_Btn);
            this.Controls.Add(this.Load_Btn);
            this.Controls.Add(this.Start_Btn);
            this.Name = "StartUp";
            this.Text = "Elysium Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button Load_Btn;
        private System.Windows.Forms.Button Archive_Btn;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Settings_Btn;
    }
}

