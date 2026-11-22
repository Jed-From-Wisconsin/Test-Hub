namespace JE.TestHub.UI
{
    partial class TestHub
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
            btnDrawCircle = new Button();
            btnToggleCircle = new Button();
            SuspendLayout();
            // 
            // btnDrawCircle
            // 
            btnDrawCircle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrawCircle.Location = new Point(12, 12);
            btnDrawCircle.Name = "btnDrawCircle";
            btnDrawCircle.Size = new Size(171, 75);
            btnDrawCircle.TabIndex = 0;
            btnDrawCircle.Text = "Basic Circle";
            btnDrawCircle.UseVisualStyleBackColor = true;
            btnDrawCircle.Click += btnDrawCircle_Click;
            // 
            // btnToggleCircle
            // 
            btnToggleCircle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggleCircle.Location = new Point(189, 12);
            btnToggleCircle.Name = "btnToggleCircle";
            btnToggleCircle.Size = new Size(171, 75);
            btnToggleCircle.TabIndex = 0;
            btnToggleCircle.Text = "Toggle Circle";
            btnToggleCircle.UseVisualStyleBackColor = true;
            btnToggleCircle.Click += btnToggleCircle_Click;
            // 
            // TestHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToggleCircle);
            Controls.Add(btnDrawCircle);
            Name = "TestHub";
            Text = "TestHub";
            Load += TestHub_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDrawCircle;
        private Button btnToggleCircle;
    }
}
