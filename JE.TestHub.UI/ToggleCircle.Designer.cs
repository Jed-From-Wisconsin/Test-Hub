namespace JE.TestHub.UI
{
    partial class ToggleCircle
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
            btnToggle = new Button();
            btnShow = new Button();
            btnHide = new Button();
            txtTracker = new TextBox();
            SuspendLayout();
            // 
            // btnToggle
            // 
            btnToggle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(12, 12);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(141, 43);
            btnToggle.TabIndex = 0;
            btnToggle.Text = "Toggle";
            btnToggle.UseVisualStyleBackColor = true;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnShow
            // 
            btnShow.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShow.Location = new Point(176, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(141, 43);
            btnShow.TabIndex = 0;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHide.Location = new Point(331, 12);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(141, 43);
            btnHide.TabIndex = 0;
            btnHide.Text = "Hide";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // txtTracker
            // 
            txtTracker.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTracker.Location = new Point(12, 61);
            txtTracker.Name = "txtTracker";
            txtTracker.ReadOnly = true;
            txtTracker.Size = new Size(460, 39);
            txtTracker.TabIndex = 1;
            txtTracker.TextAlign = HorizontalAlignment.Center;
            // 
            // ToggleCircle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(txtTracker);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(btnToggle);
            KeyPreview = true;
            Name = "ToggleCircle";
            Text = "ToggleCircle";
            Load += ToggleCircle_Load;
            KeyDown += ToggleCircle_KeyDown;
            KeyUp += ToggleCircle_KeyUp;
            Paint += ToggleCircle_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnToggle;
        private Button btnShow;
        private Button btnHide;
        private TextBox txtTracker;
    }
}