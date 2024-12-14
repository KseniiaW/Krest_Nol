namespace Krest_Nol
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
            label1 = new Label();
            buttonPlay = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Segoe Print", 10F);
            label1.Location = new Point(498, 244);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 9;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.NavajoWhite;
            buttonPlay.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonPlay.Location = new Point(498, 46);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(174, 70);
            buttonPlay.TabIndex = 10;
            buttonPlay.Text = "Новая игра";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.NavajoWhite;
            button1.Font = new Font("Segoe Print", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(498, 122);
            button1.Name = "button1";
            button1.Size = new Size(174, 70);
            button1.TabIndex = 11;
            button1.Text = "Выход";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Font = new Font("Segoe Print", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(498, 368);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 12;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Font = new Font("Segoe Print", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(498, 413);
            label3.Name = "label3";
            label3.Size = new Size(76, 35);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Font = new Font("Segoe Print", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(498, 318);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 14;
            textBox1.Text = "СЧЕТ";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(buttonPlay);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonPlay;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
    }
}
