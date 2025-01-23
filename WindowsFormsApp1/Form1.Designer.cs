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

            this.SuspendLayout();

            // Latitude
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(20, 20);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(60, 15);
            this.lblLatitude.Text = "Latitude:";

            // Longitude
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(20, 50);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(65, 15);
            this.lblLongitude.Text = "Longitude:";

            // Altitude
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(20, 80);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(56, 15);
            this.lblAltitude.Text = "Altitude:";

            // Acceleration
            this.lblAcceleration.AutoSize = true;
            this.lblAcceleration.Location = new System.Drawing.Point(20, 110);
            this.lblAcceleration.Name = "lblAcceleration";
            this.lblAcceleration.Size = new System.Drawing.Size(76, 15);
            this.lblAcceleration.Text = "Aceleração:";

            // Status
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.Text = "Status:";

            // Log TextBox
            this.txtLog.Location = new System.Drawing.Point(20, 180);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(360, 120);

            // Start Logging Button
            this.btnStartLogging.Location = new System.Drawing.Point(20, 320);
            this.btnStartLogging.Name = "btnStartLogging";
            this.btnStartLogging.Size = new System.Drawing.Size(100, 30);
            this.btnStartLogging.Text = "Iniciar Registro";
            this.btnStartLogging.UseVisualStyleBackColor = true;
            this.btnStartLogging.Click += new System.EventHandler(this.btnStartLogging_Click);

            // Stop Logging Button
            this.btnStopLogging.Location = new System.Drawing.Point(140, 320);
            this.btnStopLogging.Name = "btnStopLogging";
            this.btnStopLogging.Size = new System.Drawing.Size(100, 30);
            this.btnStopLogging.Text = "Parar Registro";
            this.btnStopLogging.UseVisualStyleBackColor = true;
            this.btnStopLogging.Click += new System.EventHandler(this.btnStopLogging_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.lblAcceleration);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStartLogging);
            this.Controls.Add(this.btnStopLogging);
            this.Name = "Form1";
            this.Text = "Estação de Telemetria";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            // Dentro do método InitializeComponent:
            this.btnIgnite = new System.Windows.Forms.Button();
            this.btnStartTelemetry = new System.Windows.Forms.Button();
            this.txtTelemetry = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();

            // Configuração do botão "Ignitar"
            this.btnIgnite.Location = new System.Drawing.Point(20, 320);
            this.btnIgnite.Name = "btnIgnite";
            this.btnIgnite.Size = new System.Drawing.Size(100, 30);
            this.btnIgnite.Text = "Ignitar";
            this.btnIgnite.UseVisualStyleBackColor = true;
            this.btnIgnite.Click += new System.EventHandler(this.btnIgnite_Click);

            // Configuração do botão "Iniciar Telemetria"
            this.btnStartTelemetry.Location = new System.Drawing.Point(140, 320);
            this.btnStartTelemetry.Name = "btnStartTelemetry";
            this.btnStartTelemetry.Size = new System.Drawing.Size(150, 30);
            this.btnStartTelemetry.Text = "Iniciar Telemetria";
            this.btnStartTelemetry.UseVisualStyleBackColor = true;
            this.btnStartTelemetry.Click += new System.EventHandler(this.btnStartTelemetry_Click);

            // Configuração do campo de telemetria
            this.txtTelemetry.Location = new System.Drawing.Point(20, 20);
            this.txtTelemetry.Multiline = true;
            this.txtTelemetry.Name = "txtTelemetry";
            this.txtTelemetry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTelemetry.Size = new System.Drawing.Size(500, 200);
            this.txtTelemetry.ReadOnly = true;

            // Configuração do campo de logs
            this.txtLog.Location = new System.Drawing.Point(20, 240);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(500, 60);
            this.txtLog.ReadOnly = true;

            // Adicionando elementos ao formulário
            this.Controls.Add(this.btnIgnite);
            this.Controls.Add(this.btnStartTelemetry);
            this.Controls.Add(this.txtTelemetry);
            this.Controls.Add(this.txtLog);

        }
    }
}
