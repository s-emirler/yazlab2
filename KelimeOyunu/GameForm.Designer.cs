
namespace KelimeOyunu
{
    partial class GameForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.letterTakeBtn = new System.Windows.Forms.Button();
            this.otherAsk = new System.Windows.Forms.Button();
            this.letterNote = new System.Windows.Forms.Label();
            this.lasdlksajlkşd = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.answerTxt = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(37, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soru:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(37, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kelime:";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.question.Location = new System.Drawing.Point(165, 134);
            this.question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(120, 26);
            this.question.TabIndex = 5;
            this.question.Text = "Soru alanı";
            // 
            // letterTakeBtn
            // 
            this.letterTakeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.letterTakeBtn.ForeColor = System.Drawing.Color.White;
            this.letterTakeBtn.Location = new System.Drawing.Point(43, 329);
            this.letterTakeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.letterTakeBtn.Name = "letterTakeBtn";
            this.letterTakeBtn.Size = new System.Drawing.Size(172, 53);
            this.letterTakeBtn.TabIndex = 7;
            this.letterTakeBtn.Text = "Harf Al";
            this.letterTakeBtn.UseVisualStyleBackColor = false;
            this.letterTakeBtn.Click += new System.EventHandler(this.letterTakeBtn_Click);
            // 
            // otherAsk
            // 
            this.otherAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.otherAsk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.otherAsk.Location = new System.Drawing.Point(539, 409);
            this.otherAsk.Margin = new System.Windows.Forms.Padding(4);
            this.otherAsk.Name = "otherAsk";
            this.otherAsk.Size = new System.Drawing.Size(284, 53);
            this.otherAsk.TabIndex = 8;
            this.otherAsk.Text = "Sıradaki Soru";
            this.otherAsk.UseVisualStyleBackColor = false;
            this.otherAsk.Click += new System.EventHandler(this.otherAsk_Click);
            // 
            // letterNote
            // 
            this.letterNote.AutoSize = true;
            this.letterNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.letterNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.letterNote.Location = new System.Drawing.Point(49, 282);
            this.letterNote.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.letterNote.Name = "letterNote";
            this.letterNote.Size = new System.Drawing.Size(311, 31);
            this.letterNote.TabIndex = 17;
            this.letterNote.Text = "Not: Kelime 10 harflidir";
            this.letterNote.Click += new System.EventHandler(this.letterNote_Click);
            // 
            // lasdlksajlkşd
            // 
            this.lasdlksajlkşd.AutoSize = true;
            this.lasdlksajlkşd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lasdlksajlkşd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lasdlksajlkşd.Location = new System.Drawing.Point(586, 282);
            this.lasdlksajlkşd.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.lasdlksajlkşd.Name = "lasdlksajlkşd";
            this.lasdlksajlkşd.Size = new System.Drawing.Size(81, 31);
            this.lasdlksajlkşd.TabIndex = 18;
            this.lasdlksajlkşd.Text = "Puan";
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.point.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.point.Location = new System.Drawing.Point(515, 282);
            this.point.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(30, 31);
            this.point.TabIndex = 19;
            this.point.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.timerLabel.Location = new System.Drawing.Point(41, 483);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 46);
            this.timerLabel.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 53);
            this.button1.TabIndex = 21;
            this.button1.Text = "Tahmin Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answerTxt
            // 
            this.answerTxt.Location = new System.Drawing.Point(236, 329);
            this.answerTxt.Margin = new System.Windows.Forms.Padding(4);
            this.answerTxt.Name = "answerTxt";
            this.answerTxt.Size = new System.Drawing.Size(431, 53);
            this.answerTxt.TabIndex = 9;
            this.answerTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.ForeColor = System.Drawing.Color.Red;
            this.panel.Location = new System.Drawing.Point(162, 196);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(505, 51);
            this.panel.TabIndex = 22;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.point);
            this.Controls.Add(this.lasdlksajlkşd);
            this.Controls.Add(this.letterNote);
            this.Controls.Add(this.answerTxt);
            this.Controls.Add(this.otherAsk);
            this.Controls.Add(this.letterTakeBtn);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "GameForm";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button letterTakeBtn;
        private System.Windows.Forms.Button otherAsk;
        private System.Windows.Forms.Label letterNote;
        private System.Windows.Forms.Label lasdlksajlkşd;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox answerTxt;
        private System.Windows.Forms.Panel panel;
    }
}