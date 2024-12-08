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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 11.25F);
            label1.Location = new Point(498, 215);
            label1.Name = "label1";
            label1.Size = new Size(43, 18);
            label1.TabIndex = 9;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // buttonPlay
            // 
            buttonPlay.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlay.Location = new Point(498, 105);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(174, 70);
            buttonPlay.TabIndex = 10;
            buttonPlay.Text = "Начать заново";
            buttonPlay.UseVisualStyleBackColor = true;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 511);
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
    }
}
