namespace Macchine_BGW
{
    partial class Form1
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
            this.ptb3 = new System.Windows.Forms.PictureBox();
            this.MacchinaRossa = new System.Windows.Forms.PictureBox();
            this.MacchinaNera = new System.Windows.Forms.PictureBox();
            this.btnRivincita = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaRossa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaNera)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb3
            // 
            this.ptb3.Image = global::Macchine_BGW.Properties.Resources.road_trip_background_10864211;
            this.ptb3.Location = new System.Drawing.Point(1, 0);
            this.ptb3.Name = "ptb3";
            this.ptb3.Size = new System.Drawing.Size(784, 243);
            this.ptb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb3.TabIndex = 5;
            this.ptb3.TabStop = false;
            // 
            // MacchinaRossa
            // 
            this.MacchinaRossa.Image = global::Macchine_BGW.Properties.Resources.macchinarossa;
            this.MacchinaRossa.Location = new System.Drawing.Point(12, 146);
            this.MacchinaRossa.Name = "MacchinaRossa";
            this.MacchinaRossa.Size = new System.Drawing.Size(130, 60);
            this.MacchinaRossa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MacchinaRossa.TabIndex = 7;
            this.MacchinaRossa.TabStop = false;
            // 
            // MacchinaNera
            // 
            this.MacchinaNera.Image = global::Macchine_BGW.Properties.Resources.macchinabianca;
            this.MacchinaNera.Location = new System.Drawing.Point(12, 31);
            this.MacchinaNera.Name = "MacchinaNera";
            this.MacchinaNera.Size = new System.Drawing.Size(130, 60);
            this.MacchinaNera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MacchinaNera.TabIndex = 6;
            this.MacchinaNera.TabStop = false;
            // 
            // btnRivincita
            // 
            this.btnRivincita.Location = new System.Drawing.Point(147, 258);
            this.btnRivincita.Name = "btnRivincita";
            this.btnRivincita.Size = new System.Drawing.Size(96, 31);
            this.btnRivincita.TabIndex = 9;
            this.btnRivincita.Text = "Rematch";
            this.btnRivincita.UseVisualStyleBackColor = true;
            this.btnRivincita.Click += new System.EventHandler(this.btnRivincita_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 31);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(787, 304);
            this.Controls.Add(this.btnRivincita);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.MacchinaRossa);
            this.Controls.Add(this.MacchinaNera);
            this.Controls.Add(this.ptb3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaRossa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MacchinaNera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb3;
        private System.Windows.Forms.PictureBox MacchinaRossa;
        private System.Windows.Forms.PictureBox MacchinaNera;
        private System.Windows.Forms.Button btnRivincita;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

