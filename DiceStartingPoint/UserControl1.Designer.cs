namespace DiceStartingPoint
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.die1Out = new System.Windows.Forms.Label();
            this.die2Out = new System.Windows.Forms.Label();
            this.die3Out = new System.Windows.Forms.Label();
            this.intDie1img = new System.Windows.Forms.PictureBox();
            this.intDie2img = new System.Windows.Forms.PictureBox();
            this.intDie3img = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedGuess = new System.Windows.Forms.ComboBox();
            this.rollDice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.intDiceCS = new System.Windows.Forms.Label();
            this.intDiceIS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intDie1img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDie2img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDie3img)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.intDiceIS);
            this.groupBox1.Controls.Add(this.intDiceCS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rollDice);
            this.groupBox1.Controls.Add(this.selectedGuess);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.intDie3img);
            this.groupBox1.Controls.Add(this.intDie2img);
            this.groupBox1.Controls.Add(this.intDie1img);
            this.groupBox1.Controls.Add(this.die3Out);
            this.groupBox1.Controls.Add(this.die2Out);
            this.groupBox1.Controls.Add(this.die1Out);
            this.groupBox1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice";
            // 
            // die1Out
            // 
            this.die1Out.AutoSize = true;
            this.die1Out.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1Out.Location = new System.Drawing.Point(63, 23);
            this.die1Out.Name = "die1Out";
            this.die1Out.Size = new System.Drawing.Size(16, 17);
            this.die1Out.TabIndex = 0;
            this.die1Out.Text = "6";
            // 
            // die2Out
            // 
            this.die2Out.AutoSize = true;
            this.die2Out.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2Out.Location = new System.Drawing.Point(216, 23);
            this.die2Out.Name = "die2Out";
            this.die2Out.Size = new System.Drawing.Size(16, 17);
            this.die2Out.TabIndex = 1;
            this.die2Out.Text = "3";
            // 
            // die3Out
            // 
            this.die3Out.AutoSize = true;
            this.die3Out.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die3Out.Location = new System.Drawing.Point(369, 22);
            this.die3Out.Name = "die3Out";
            this.die3Out.Size = new System.Drawing.Size(16, 17);
            this.die3Out.TabIndex = 2;
            this.die3Out.Text = "3";
            this.die3Out.Click += new System.EventHandler(this.label3_Click);
            // 
            // intDie1img
            // 
            this.intDie1img.Image = global::DiceStartingPoint.Properties.Resources._6;
            this.intDie1img.Location = new System.Drawing.Point(7, 51);
            this.intDie1img.Name = "intDie1img";
            this.intDie1img.Size = new System.Drawing.Size(130, 130);
            this.intDie1img.TabIndex = 3;
            this.intDie1img.TabStop = false;
            // 
            // intDie2img
            // 
            this.intDie2img.Image = global::DiceStartingPoint.Properties.Resources._3;
            this.intDie2img.Location = new System.Drawing.Point(159, 51);
            this.intDie2img.Name = "intDie2img";
            this.intDie2img.Size = new System.Drawing.Size(130, 130);
            this.intDie2img.TabIndex = 4;
            this.intDie2img.TabStop = false;
            // 
            // intDie3img
            // 
            this.intDie3img.Image = global::DiceStartingPoint.Properties.Resources._3;
            this.intDie3img.Location = new System.Drawing.Point(311, 51);
            this.intDie3img.Name = "intDie3img";
            this.intDie3img.Size = new System.Drawing.Size(130, 130);
            this.intDie3img.TabIndex = 5;
            this.intDie3img.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Guess";
            // 
            // selectedGuess
            // 
            this.selectedGuess.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedGuess.FormattingEnabled = true;
            this.selectedGuess.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.selectedGuess.Location = new System.Drawing.Point(168, 211);
            this.selectedGuess.Name = "selectedGuess";
            this.selectedGuess.Size = new System.Drawing.Size(121, 23);
            this.selectedGuess.TabIndex = 7;
            this.selectedGuess.Text = "Select guess";
            // 
            // rollDice
            // 
            this.rollDice.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDice.Location = new System.Drawing.Point(7, 252);
            this.rollDice.Name = "rollDice";
            this.rollDice.Size = new System.Drawing.Size(434, 34);
            this.rollDice.TabIndex = 8;
            this.rollDice.Text = "Roll Dice!";
            this.rollDice.UseVisualStyleBackColor = true;
            this.rollDice.Click += new System.EventHandler(this.rollDice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correct";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Incorrect";
            // 
            // intDiceCS
            // 
            this.intDiceCS.AutoSize = true;
            this.intDiceCS.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intDiceCS.Location = new System.Drawing.Point(212, 353);
            this.intDiceCS.Name = "intDiceCS";
            this.intDiceCS.Size = new System.Drawing.Size(16, 17);
            this.intDiceCS.TabIndex = 11;
            this.intDiceCS.Text = "0";
            // 
            // intDiceIS
            // 
            this.intDiceIS.AutoSize = true;
            this.intDiceIS.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intDiceIS.Location = new System.Drawing.Point(234, 353);
            this.intDiceIS.Name = "intDiceIS";
            this.intDiceIS.Size = new System.Drawing.Size(16, 17);
            this.intDiceIS.TabIndex = 12;
            this.intDiceIS.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(225, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "/";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(507, 450);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intDie1img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDie2img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDie3img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox intDie3img;
        private System.Windows.Forms.PictureBox intDie2img;
        private System.Windows.Forms.PictureBox intDie1img;
        private System.Windows.Forms.Label die3Out;
        private System.Windows.Forms.Label die2Out;
        private System.Windows.Forms.Label die1Out;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label intDiceIS;
        private System.Windows.Forms.Label intDiceCS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button rollDice;
        private System.Windows.Forms.ComboBox selectedGuess;
    }
}
