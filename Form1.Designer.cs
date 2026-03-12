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
            CatchButton = new Button();
            SuspendLayout();
            // 
            // CatchButton
            // 
            CatchButton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            CatchButton.Location = new Point(320, 274);
            CatchButton.Name = "CatchButton";
            CatchButton.Size = new Size(180, 73);
            CatchButton.TabIndex = 0;
            CatchButton.Text = "나를잡아봐";
            CatchButton.UseVisualStyleBackColor = true;
            CatchButton.Click += CatchMe_Click;
            CatchButton.MouseEnter += CatchButton_MouseEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 678);
            Controls.Add(CatchButton);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            MouseEnter += CatchButton_MouseEnter;
            ResumeLayout(false);
        }

        #endregion

        private Button CatchButton;

    }
}
