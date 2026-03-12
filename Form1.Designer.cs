namespace CatchButton
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
            runbutton = new Button();
            SuspendLayout();
            // 
            // runbutton
            // 
            runbutton.BackColor = SystemColors.ActiveCaption;
            runbutton.Font = new Font("맑은 고딕", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            runbutton.Location = new Point(345, 175);
            runbutton.Name = "runbutton";
            runbutton.Size = new Size(372, 158);
            runbutton.TabIndex = 0;
            runbutton.Text = "나를 잡아봐";
            runbutton.UseVisualStyleBackColor = false;
            runbutton.Click += runbutton_Click;
            runbutton.MouseEnter += button1_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 575);
            Controls.Add(runbutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button runbutton;
    }
}
