namespace BendTableIssueDemo
{
    partial class FrmMain
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
            btnCreateDrawing = new Button();
            SuspendLayout();
            // 
            // btnCreateDrawing
            // 
            btnCreateDrawing.Location = new Point(12, 21);
            btnCreateDrawing.Name = "btnCreateDrawing";
            btnCreateDrawing.Size = new Size(417, 70);
            btnCreateDrawing.TabIndex = 0;
            btnCreateDrawing.Text = "Create Sheetmetal Flat Pattern Drawing of Active";
            btnCreateDrawing.UseVisualStyleBackColor = true;
            btnCreateDrawing.Click += btnCreateDrawing_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 137);
            Controls.Add(btnCreateDrawing);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bend Table Issue Demo";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateDrawing;
    }
}
