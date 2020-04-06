namespace Nineinchers_BL_farmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEPL = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbEplPicked = new System.Windows.Forms.TextBox();
            this.tbEplNext = new System.Windows.Forms.TextBox();
            this.tbBsPicked = new System.Windows.Forms.TextBox();
            this.tbBsNext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnWS = new System.Windows.Forms.Button();
            this.btnSili = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbWsNext = new System.Windows.Forms.TextBox();
            this.tbWsPicked = new System.Windows.Forms.TextBox();
            this.tbSiliNext = new System.Windows.Forms.TextBox();
            this.tbSiliPicked = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEPL
            // 
            this.btnEPL.Location = new System.Drawing.Point(86, 168);
            this.btnEPL.Name = "btnEPL";
            this.btnEPL.Size = new System.Drawing.Size(75, 23);
            this.btnEPL.TabIndex = 0;
            this.btnEPL.Text = "Click";
            this.btnEPL.UseVisualStyleBackColor = true;
            this.btnEPL.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(358, 168);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(75, 23);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "Click";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Last picked:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 121);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(53, 13);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Next one:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Eastern plaguelands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Burning Steppes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last picked:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Next one:";
            // 
            // flp
            // 
            this.flp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp.Location = new System.Drawing.Point(546, 69);
            this.flp.Margin = new System.Windows.Forms.Padding(0);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(242, 445);
            this.flp.TabIndex = 12;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(546, 43);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 13;
            this.btnAddPlayer.Text = "Add player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.BtnAddPlayer_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 439);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 75);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbEplPicked
            // 
            this.tbEplPicked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEplPicked.Location = new System.Drawing.Point(109, 87);
            this.tbEplPicked.Name = "tbEplPicked";
            this.tbEplPicked.ReadOnly = true;
            this.tbEplPicked.Size = new System.Drawing.Size(85, 13);
            this.tbEplPicked.TabIndex = 15;
            // 
            // tbEplNext
            // 
            this.tbEplNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEplNext.Location = new System.Drawing.Point(109, 121);
            this.tbEplNext.Name = "tbEplNext";
            this.tbEplNext.ReadOnly = true;
            this.tbEplNext.Size = new System.Drawing.Size(85, 13);
            this.tbEplNext.TabIndex = 16;
            // 
            // tbBsPicked
            // 
            this.tbBsPicked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBsPicked.Location = new System.Drawing.Point(382, 87);
            this.tbBsPicked.Name = "tbBsPicked";
            this.tbBsPicked.ReadOnly = true;
            this.tbBsPicked.Size = new System.Drawing.Size(85, 13);
            this.tbBsPicked.TabIndex = 17;
            // 
            // tbBsNext
            // 
            this.tbBsNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBsNext.Location = new System.Drawing.Point(382, 121);
            this.tbBsNext.Name = "tbBsNext";
            this.tbBsNext.ReadOnly = true;
            this.tbBsNext.Size = new System.Drawing.Size(85, 13);
            this.tbBsNext.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Winterspring";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last picked:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Next one:";
            // 
            // btnWS
            // 
            this.btnWS.Location = new System.Drawing.Point(86, 372);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(75, 23);
            this.btnWS.TabIndex = 22;
            this.btnWS.Text = "Click";
            this.btnWS.UseVisualStyleBackColor = true;
            this.btnWS.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnSili
            // 
            this.btnSili.Location = new System.Drawing.Point(359, 372);
            this.btnSili.Name = "btnSili";
            this.btnSili.Size = new System.Drawing.Size(75, 23);
            this.btnSili.TabIndex = 26;
            this.btnSili.Text = "Click";
            this.btnSili.UseVisualStyleBackColor = true;
            this.btnSili.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Next one:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Last picked:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 25);
            this.label11.TabIndex = 23;
            this.label11.Text = "Silithus";
            // 
            // tbWsNext
            // 
            this.tbWsNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWsNext.Location = new System.Drawing.Point(117, 331);
            this.tbWsNext.Name = "tbWsNext";
            this.tbWsNext.ReadOnly = true;
            this.tbWsNext.Size = new System.Drawing.Size(85, 13);
            this.tbWsNext.TabIndex = 28;
            // 
            // tbWsPicked
            // 
            this.tbWsPicked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWsPicked.Location = new System.Drawing.Point(117, 297);
            this.tbWsPicked.Name = "tbWsPicked";
            this.tbWsPicked.ReadOnly = true;
            this.tbWsPicked.Size = new System.Drawing.Size(85, 13);
            this.tbWsPicked.TabIndex = 27;
            // 
            // tbSiliNext
            // 
            this.tbSiliNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSiliNext.Location = new System.Drawing.Point(390, 331);
            this.tbSiliNext.Name = "tbSiliNext";
            this.tbSiliNext.ReadOnly = true;
            this.tbSiliNext.Size = new System.Drawing.Size(85, 13);
            this.tbSiliNext.TabIndex = 30;
            // 
            // tbSiliPicked
            // 
            this.tbSiliPicked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSiliPicked.Location = new System.Drawing.Point(390, 297);
            this.tbSiliPicked.Name = "tbSiliPicked";
            this.tbSiliPicked.ReadOnly = true;
            this.tbSiliPicked.Size = new System.Drawing.Size(85, 13);
            this.tbSiliPicked.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.tbSiliNext);
            this.Controls.Add(this.tbSiliPicked);
            this.Controls.Add(this.tbWsNext);
            this.Controls.Add(this.tbWsPicked);
            this.Controls.Add(this.btnSili);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnWS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBsNext);
            this.Controls.Add(this.tbBsPicked);
            this.Controls.Add(this.tbEplNext);
            this.Controls.Add(this.tbEplPicked);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnEPL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nineinchers Ultimate Lotus Farmer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEPL;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbEplPicked;
        private System.Windows.Forms.TextBox tbEplNext;
        private System.Windows.Forms.TextBox tbBsPicked;
        private System.Windows.Forms.TextBox tbBsNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnWS;
        private System.Windows.Forms.Button btnSili;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbWsNext;
        private System.Windows.Forms.TextBox tbWsPicked;
        private System.Windows.Forms.TextBox tbSiliNext;
        private System.Windows.Forms.TextBox tbSiliPicked;
    }
}

