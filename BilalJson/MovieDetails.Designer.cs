namespace BilalJson
{
    partial class MovieDetails
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
            lblTitel = new Label();
            pnlDetails = new Panel();
            tboxOverview = new TextBox();
            tboxRelease = new TextBox();
            lblRelease = new Label();
            tboxMovieID = new TextBox();
            lblScoreValue = new Label();
            label1 = new Label();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitel.Location = new Point(37, 28);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(135, 21);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "No movie found";
            // 
            // pnlDetails
            // 
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(tboxOverview);
            pnlDetails.Location = new Point(37, 52);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(486, 354);
            pnlDetails.TabIndex = 1;
            // 
            // tboxOverview
            // 
            tboxOverview.BorderStyle = BorderStyle.None;
            tboxOverview.Location = new Point(3, 3);
            tboxOverview.Multiline = true;
            tboxOverview.Name = "tboxOverview";
            tboxOverview.ReadOnly = true;
            tboxOverview.ScrollBars = ScrollBars.Vertical;
            tboxOverview.Size = new Size(478, 57);
            tboxOverview.TabIndex = 50;
            tboxOverview.TabStop = false;
            // 
            // tboxRelease
            // 
            tboxRelease.BackColor = SystemColors.Control;
            tboxRelease.BorderStyle = BorderStyle.None;
            tboxRelease.Location = new Point(118, 409);
            tboxRelease.Name = "tboxRelease";
            tboxRelease.ReadOnly = true;
            tboxRelease.Size = new Size(75, 16);
            tboxRelease.TabIndex = 52;
            // 
            // lblRelease
            // 
            lblRelease.AutoSize = true;
            lblRelease.Location = new Point(37, 409);
            lblRelease.Name = "lblRelease";
            lblRelease.Size = new Size(75, 15);
            lblRelease.TabIndex = 51;
            lblRelease.Text = "Release date:";
            // 
            // tboxMovieID
            // 
            tboxMovieID.BackColor = SystemColors.Control;
            tboxMovieID.BorderStyle = BorderStyle.None;
            tboxMovieID.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            tboxMovieID.ForeColor = SystemColors.ControlDarkDark;
            tboxMovieID.Location = new Point(491, 409);
            tboxMovieID.Name = "tboxMovieID";
            tboxMovieID.ReadOnly = true;
            tboxMovieID.Size = new Size(32, 13);
            tboxMovieID.TabIndex = 40;
            tboxMovieID.TabStop = false;
            tboxMovieID.Text = "454577";
            tboxMovieID.TextAlign = HorizontalAlignment.Right;
            // 
            // lblScoreValue
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreValue.Location = new Point(491, 28);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(32, 21);
            lblScoreValue.TabIndex = 54;
            lblScoreValue.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(474, 409);
            label1.Name = "label1";
            label1.Size = new Size(15, 12);
            label1.TabIndex = 55;
            label1.Text = "id:";
            // 
            // MovieDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblScoreValue);
            Controls.Add(tboxRelease);
            Controls.Add(tboxMovieID);
            Controls.Add(lblRelease);
            Controls.Add(pnlDetails);
            Controls.Add(lblTitel);
            Name = "MovieDetails";
            Text = "Movie Details";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Panel pnlDetails;
        private TextBox tboxOverview;
        private Label lblMovieID;
        private TextBox tboxMovieID;
        private TextBox tboxRelease;
        private Label lblRelease;
        private Label lblScoreValue;
        private Label label1;
    }
}