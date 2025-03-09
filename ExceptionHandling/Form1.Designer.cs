namespace ExceptionHandling
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
            lstErrorLog = new ListBox();
            btnSimulateError = new Button();
            lblInstructions = new Label();
            SuspendLayout();
            // 
            // lstErrorLog
            // 
            lstErrorLog.BackColor = Color.Black;
            lstErrorLog.Dock = DockStyle.Top;
            lstErrorLog.ForeColor = Color.Chartreuse;
            lstErrorLog.FormattingEnabled = true;
            lstErrorLog.ItemHeight = 15;
            lstErrorLog.Location = new Point(0, 0);
            lstErrorLog.Name = "lstErrorLog";
            lstErrorLog.Size = new Size(800, 364);
            lstErrorLog.TabIndex = 0;
            // 
            // btnSimulateError
            // 
            btnSimulateError.BackColor = Color.Red;
            btnSimulateError.Location = new Point(340, 415);
            btnSimulateError.Name = "btnSimulateError";
            btnSimulateError.Size = new Size(115, 23);
            btnSimulateError.TabIndex = 1;
            btnSimulateError.Text = "Simulate Errors";
            btnSimulateError.UseVisualStyleBackColor = false;
            btnSimulateError.Click += btnSimulateError_Click;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.BackColor = SystemColors.ControlDarkDark;
            lblInstructions.Location = new Point(296, 397);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(208, 15);
            lblInstructions.TabIndex = 2;
            lblInstructions.Text = "Click below to simulate random errors";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInstructions);
            Controls.Add(btnSimulateError);
            Controls.Add(lstErrorLog);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstErrorLog;
        private Button btnSimulateError;
        private Label lblInstructions;
    }
}
