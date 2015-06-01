namespace Reports
{
    partial class frmCharts
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
            this.ucGraph1 = new Reports.ucGraph();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ucGraph1
            // 
            this.ucGraph1.Data = null;
            this.ucGraph1.Location = new System.Drawing.Point(12, 88);
            this.ucGraph1.Name = "ucGraph1";
            this.ucGraph1.Size = new System.Drawing.Size(454, 224);
            this.ucGraph1.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(135, 38);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play data";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 324);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.ucGraph1);
            this.Name = "frmCharts";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucGraph ucGraph1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer;



    }
}

