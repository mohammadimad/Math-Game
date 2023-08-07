
namespace WindowsFormsApp12
{
    partial class MathQuizz
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.lblQuizzLevel = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.nubNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.cbQuizzLevel = new System.Windows.Forms.ComboBox();
            this.cbOperationType = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubNumberOfQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp12.Properties.Resources.thinking;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(67, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestions.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(313, 163);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(223, 23);
            this.lblNumberOfQuestions.TabIndex = 1;
            this.lblNumberOfQuestions.Text = "Number Of Questions";
            // 
            // lblQuizzLevel
            // 
            this.lblQuizzLevel.AutoSize = true;
            this.lblQuizzLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.lblQuizzLevel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizzLevel.ForeColor = System.Drawing.Color.White;
            this.lblQuizzLevel.Location = new System.Drawing.Point(313, 219);
            this.lblQuizzLevel.Name = "lblQuizzLevel";
            this.lblQuizzLevel.Size = new System.Drawing.Size(126, 23);
            this.lblQuizzLevel.TabIndex = 2;
            this.lblQuizzLevel.Text = "Quizz Level";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(139)))), ((int)(((byte)(99)))));
            this.lblOperationType.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationType.ForeColor = System.Drawing.Color.White;
            this.lblOperationType.Location = new System.Drawing.Point(313, 271);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(173, 23);
            this.lblOperationType.TabIndex = 3;
            this.lblOperationType.Text = "Operation Type";
            // 
            // nubNumberOfQuestions
            // 
            this.nubNumberOfQuestions.BackColor = System.Drawing.Color.SandyBrown;
            this.nubNumberOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nubNumberOfQuestions.Location = new System.Drawing.Point(586, 161);
            this.nubNumberOfQuestions.Name = "nubNumberOfQuestions";
            this.nubNumberOfQuestions.Size = new System.Drawing.Size(44, 29);
            this.nubNumberOfQuestions.TabIndex = 4;
            this.nubNumberOfQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nubNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbQuizzLevel
            // 
            this.cbQuizzLevel.BackColor = System.Drawing.Color.SandyBrown;
            this.cbQuizzLevel.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuizzLevel.FormattingEnabled = true;
            this.cbQuizzLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mixed"});
            this.cbQuizzLevel.Location = new System.Drawing.Point(533, 219);
            this.cbQuizzLevel.Name = "cbQuizzLevel";
            this.cbQuizzLevel.Size = new System.Drawing.Size(143, 28);
            this.cbQuizzLevel.TabIndex = 5;
            // 
            // cbOperationType
            // 
            this.cbOperationType.BackColor = System.Drawing.Color.SandyBrown;
            this.cbOperationType.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperationType.FormattingEnabled = true;
            this.cbOperationType.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division",
            "Mixed"});
            this.cbOperationType.Location = new System.Drawing.Point(533, 266);
            this.cbOperationType.Name = "cbOperationType";
            this.cbOperationType.Size = new System.Drawing.Size(143, 28);
            this.cbOperationType.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.SandyBrown;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(433, 367);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 54);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MathQuizz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp12.Properties.Resources.Background_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 538);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbOperationType);
            this.Controls.Add(this.cbQuizzLevel);
            this.Controls.Add(this.nubNumberOfQuestions);
            this.Controls.Add(this.lblOperationType);
            this.Controls.Add(this.lblQuizzLevel);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MathQuizz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Quizz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubNumberOfQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Label lblQuizzLevel;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.NumericUpDown nubNumberOfQuestions;
        private System.Windows.Forms.ComboBox cbQuizzLevel;
        private System.Windows.Forms.ComboBox cbOperationType;
        private System.Windows.Forms.Button btnStart;
    }
}

