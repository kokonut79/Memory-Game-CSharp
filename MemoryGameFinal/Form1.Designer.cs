namespace MemoryGameFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lStratus = new System.Windows.Forms.Label();
            this.bRestart = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lStratus
            // 
            this.lStratus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lStratus.Location = new System.Drawing.Point(241, 70);
            this.lStratus.Name = "lStratus";
            this.lStratus.Size = new System.Drawing.Size(178, 84);
            this.lStratus.TabIndex = 0;
            this.lStratus.Text = "Memory Game By Vasil Parshev";
            this.lStratus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lStratus.Click += new System.EventHandler(this.lStratus_Click);
            // 
            // bRestart
            // 
            this.bRestart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bRestart.Location = new System.Drawing.Point(274, 22);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(114, 45);
            this.bRestart.TabIndex = 1;
            this.bRestart.Text = "Restart";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.RestartGameEvent);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 273);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.lStratus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lStratus;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Timer GameTimer;
    }
}
