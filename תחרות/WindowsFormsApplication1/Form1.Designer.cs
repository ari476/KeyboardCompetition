namespace WindowsFormsApplication1
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
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.pcb2 = new System.Windows.Forms.PictureBox();
            this.pr1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pr2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb1
            // 
            this.pcb1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcb1.Location = new System.Drawing.Point(482, 64);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(100, 411);
            this.pcb1.TabIndex = 0;
            this.pcb1.TabStop = false;
            this.pcb1.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb1_Paint);
            // 
            // pcb2
            // 
            this.pcb2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pcb2.Location = new System.Drawing.Point(48, 64);
            this.pcb2.Name = "pcb2";
            this.pcb2.Size = new System.Drawing.Size(100, 411);
            this.pcb2.TabIndex = 1;
            this.pcb2.TabStop = false;
            this.pcb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb2_Paint);
            // 
            // pr1
            // 
            this.pr1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pr1.Location = new System.Drawing.Point(175, 64);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(90, 41);
            this.pr1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(21, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "PLAYER 1";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(418, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "PLAYER 2";
            // 
            // pr2
            // 
            this.pr2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pr2.Location = new System.Drawing.Point(370, 64);
            this.pr2.Name = "pr2";
            this.pr2.Size = new System.Drawing.Size(91, 41);
            this.pr2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(176, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 151);
            this.label5.TabIndex = 8;
            this.label5.Text = "PLAYER 1 PLAY WITH  \'A\' AND  \'D\' KEYS\r\nPLAYER 2 PLAY WITH  \'4\' AND  \'6\' KEYS";
            // 
            // res
            // 
            this.res.BackColor = System.Drawing.SystemColors.Control;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.res.Location = new System.Drawing.Point(176, 317);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(270, 97);
            this.res.TabIndex = 9;
            this.res.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(229, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pr1);
            this.Controls.Add(this.pcb2);
            this.Controls.Add(this.pcb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.PictureBox pcb2;
        private System.Windows.Forms.Label pr1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pr2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

