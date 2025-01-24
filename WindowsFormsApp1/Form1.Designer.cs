namespace TelemetryGroundStation
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblAcceleration;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnStartLogging;
        private System.Windows.Forms.Button btnStopLogging;
        private System.Windows.Forms.Button btnIgnite;
        private System.Windows.Forms.Button btnStartTelemetry;
        private System.Windows.Forms.TextBox txtTelemetry;
        


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
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblAcceleration = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStartLogging = new System.Windows.Forms.Button();
            this.btnStopLogging = new System.Windows.Forms.Button();
            this.btnIgnite = new System.Windows.Forms.Button();
            this.btnStartTelemetry = new System.Windows.Forms.Button();
            this.txtTelemetry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(20, 20);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(48, 13);
            this.lblLatitude.TabIndex = 0;
            this.lblLatitude.Text = "Latitude:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(20, 50);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(57, 13);
            this.lblLongitude.TabIndex = 1;
            this.lblLongitude.Text = "Longitude:";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(20, 80);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(45, 13);
            this.lblAltitude.TabIndex = 2;
            this.lblAltitude.Text = "Altitude:";
            // 
            // lblAcceleration
            // 
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Location = new System.Drawing.Point(20, 110);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(64, 13);
            this.lblAcceleration.TabIndex = 3;
            this.lblAcceleration.Text = "Aceleração:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 218);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(376, 60);
            this.txtLog.TabIndex = 5;
            // 
            // btnStartLogging
            // 
            this.btnStartLogging.Location = new System.Drawing.Point(12, 320);
            this.btnStartLogging.Name = "btnStartLogging";
            this.btnStartLogging.Size = new System.Drawing.Size(100, 30);
            this.btnStartLogging.TabIndex = 6;
            this.btnStartLogging.Text = "Iniciar Registro";
            this.btnStartLogging.UseVisualStyleBackColor = true;
            this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);
            // 
            // btnStopLogging
            // 
            this.btnStopLogging.Location = new System.Drawing.Point(126, 320);
            this.btnStopLogging.Name = "btnStopLogging";
            this.btnStopLogging.Size = new System.Drawing.Size(100, 30);
            this.btnStopLogging.TabIndex = 7;
            this.btnStopLogging.Text = "Parar Registro";
            this.btnStopLogging.UseVisualStyleBackColor = true;
            this.btnStopLogging.Click += new System.EventHandler(this.btnStopLogging_Click);
            // 
            // btnIgnite
            // 
            this.btnIgnite.Location = new System.Drawing.Point(293, 80);
            this.btnIgnite.Name = "btnIgnite";
            this.btnIgnite.Size = new System.Drawing.Size(100, 82);
            this.btnIgnite.TabIndex = 8;
            this.btnIgnite.Text = "Ignitar";
            this.btnIgnite.UseVisualStyleBackColor = true;
            this.btnIgnite.Click += new System.EventHandler(this.btnIgnite_Click);
            // 
            // btnStartTelemetry
            // 
            this.btnStartTelemetry.Location = new System.Drawing.Point(232, 320);
            this.btnStartTelemetry.Name = "btnStartTelemetry";
            this.btnStartTelemetry.Size = new System.Drawing.Size(150, 30);
            this.btnStartTelemetry.TabIndex = 9;
            this.btnStartTelemetry.Text = "Iniciar Telemetria";
            this.btnStartTelemetry.UseVisualStyleBackColor = true;
            this.btnStartTelemetry.Click += new System.EventHandler(this.btnStartTelemetry_Click);
            // 
            // txtTelemetry
            // 
            this.txtTelemetry.Location = new System.Drawing.Point(6, 12);
            this.txtTelemetry.Multiline = true;
            this.txtTelemetry.Name = "txtTelemetry";
            this.txtTelemetry.ReadOnly = true;
            this.txtTelemetry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTelemetry.Size = new System.Drawing.Size(281, 200);
            this.txtTelemetry.TabIndex = 10;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.lblAcceleration);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStartLogging);
            this.Controls.Add(this.btnStopLogging);
            this.Controls.Add(this.btnIgnite);
            this.Controls.Add(this.btnStartTelemetry);
            this.Controls.Add(this.txtTelemetry);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Estação de Telemetria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
