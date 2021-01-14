namespace kronometre1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbasla = new System.Windows.Forms.Button();
            this.btndur = new System.Windows.Forms.Button();
            this.btnsıfırla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // btnbasla
            // 
            this.btnbasla.Location = new System.Drawing.Point(12, 12);
            this.btnbasla.Name = "btnbasla";
            this.btnbasla.Size = new System.Drawing.Size(96, 60);
            this.btnbasla.TabIndex = 1;
            this.btnbasla.Text = "Başla";
            this.btnbasla.UseVisualStyleBackColor = true;
            this.btnbasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndur
            // 
            this.btndur.Location = new System.Drawing.Point(125, 12);
            this.btndur.Name = "btndur";
            this.btndur.Size = new System.Drawing.Size(96, 60);
            this.btndur.TabIndex = 2;
            this.btndur.Text = "Durdur";
            this.btndur.UseVisualStyleBackColor = true;
            this.btndur.Click += new System.EventHandler(this.btndur_Click);
            // 
            // btnsıfırla
            // 
            this.btnsıfırla.Location = new System.Drawing.Point(227, 12);
            this.btnsıfırla.Name = "btnsıfırla";
            this.btnsıfırla.Size = new System.Drawing.Size(96, 60);
            this.btnsıfırla.TabIndex = 3;
            this.btnsıfırla.Text = "Sıfırla";
            this.btnsıfırla.UseVisualStyleBackColor = true;
            this.btnsıfırla.Click += new System.EventHandler(this.btnsıfırla_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 147);
            this.Controls.Add(this.btnsıfırla);
            this.Controls.Add(this.btndur);
            this.Controls.Add(this.btnbasla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Kronometre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbasla;
        private System.Windows.Forms.Button btndur;
        private System.Windows.Forms.Button btnsıfırla;
        private System.Windows.Forms.Timer timer1;
    }
}

