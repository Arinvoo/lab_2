namespace lab_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateRace;
        private System.Windows.Forms.Label lblTrackType;
        private System.Windows.Forms.Label lblRunnerType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateRace = new System.Windows.Forms.Button();
            this.lblTrackType = new System.Windows.Forms.Label();
            this.lblRunnerType = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnCreateRace
            this.btnCreateRace.Location = new System.Drawing.Point(20, 20);
            this.btnCreateRace.Name = "btnCreateRace";
            this.btnCreateRace.Size = new System.Drawing.Size(120, 40);
            this.btnCreateRace.TabIndex = 0;
            this.btnCreateRace.Text = "Створити змагання";
            this.btnCreateRace.UseVisualStyleBackColor = true;
            this.btnCreateRace.Click += new System.EventHandler(this.btnCreateRace_Click);

            // lblTrackType
            this.lblTrackType.AutoSize = true;
            this.lblTrackType.Location = new System.Drawing.Point(20, 80);
            this.lblTrackType.Name = "lblTrackType";
            this.lblTrackType.Size = new System.Drawing.Size(50, 20);
            this.lblTrackType.TabIndex = 1;
            this.lblTrackType.Text = "Track:";

            // lblRunnerType
            this.lblRunnerType.AutoSize = true;
            this.lblRunnerType.Location = new System.Drawing.Point(20, 120);
            this.lblRunnerType.Name = "lblRunnerType";
            this.lblRunnerType.Size = new System.Drawing.Size(59, 20);
            this.lblRunnerType.TabIndex = 2;
            this.lblRunnerType.Text = "Runner:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.btnCreateRace);
            this.Controls.Add(this.lblTrackType);
            this.Controls.Add(this.lblRunnerType);
            this.Name = "MainForm";
            this.Text = "Короткі дистанції - Абстрактна фабрика";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

