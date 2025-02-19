﻿namespace BilalJson
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
            panel1 = new Panel();
            lblAdult = new Label();
            cboxAdult = new CheckBox();
            lblGenre = new Label();
            lblGenreList = new Label();
            cboxVideo = new CheckBox();
            lblLang = new Label();
            lblOriginalLang = new Label();
            lblOriginalTitle = new Label();
            lblOrgTitel = new Label();
            lblVideo = new Label();
            lblReleaseDate = new Label();
            lblReleaseShortDate = new Label();
            lblOverview = new Label();
            pboxBackdrop = new PictureBox();
            tboxOverview = new TextBox();
            lblRelease = new Label();
            tboxMovieID = new TextBox();
            lblScoreValue = new Label();
            label1 = new Label();
            pboxPoster = new PictureBox();
            lblRating = new Label();
            lblVoters = new Label();
            lblVoteCount = new Label();
            lblPopularity = new Label();
            lblPopularityCount = new Label();
            pnlDetails.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxBackdrop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxPoster).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Source Sans Pro Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitel.Location = new Point(24, 26);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(160, 28);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "No movie found";
            // 
            // pnlDetails
            // 
            pnlDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlDetails.Controls.Add(panel1);
            pnlDetails.Controls.Add(lblOverview);
            pnlDetails.Controls.Add(pboxBackdrop);
            pnlDetails.Controls.Add(tboxOverview);
            pnlDetails.Location = new Point(412, 77);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(486, 510);
            pnlDetails.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblAdult);
            panel1.Controls.Add(cboxAdult);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(lblGenreList);
            panel1.Controls.Add(cboxVideo);
            panel1.Controls.Add(lblLang);
            panel1.Controls.Add(lblOriginalLang);
            panel1.Controls.Add(lblOriginalTitle);
            panel1.Controls.Add(lblOrgTitel);
            panel1.Controls.Add(lblVideo);
            panel1.Controls.Add(lblReleaseDate);
            panel1.Controls.Add(lblReleaseShortDate);
            panel1.Location = new Point(-1, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 118);
            panel1.TabIndex = 53;
            // 
            // lblAdult
            // 
            lblAdult.AutoSize = true;
            lblAdult.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdult.Location = new Point(80, 85);
            lblAdult.Name = "lblAdult";
            lblAdult.Size = new Size(31, 13);
            lblAdult.TabIndex = 71;
            lblAdult.Text = "Adult";
            // 
            // cboxAdult
            // 
            cboxAdult.AutoCheck = false;
            cboxAdult.AutoSize = true;
            cboxAdult.Enabled = false;
            cboxAdult.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboxAdult.Location = new Point(112, 85);
            cboxAdult.Name = "cboxAdult";
            cboxAdult.Size = new Size(15, 14);
            cboxAdult.TabIndex = 73;
            cboxAdult.UseVisualStyleBackColor = true;
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenre.Location = new Point(6, 9);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(39, 13);
            lblGenre.TabIndex = 53;
            lblGenre.Text = "Genre:";
            // 
            // lblGenreList
            // 
            lblGenreList.AutoSize = true;
            lblGenreList.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblGenreList.Location = new Point(43, 9);
            lblGenreList.Name = "lblGenreList";
            lblGenreList.Padding = new Padding(10, 0, 0, 0);
            lblGenreList.Size = new Size(71, 13);
            lblGenreList.TabIndex = 63;
            lblGenreList.Text = "Test, Test2";
            // 
            // cboxVideo
            // 
            cboxVideo.AutoCheck = false;
            cboxVideo.AutoSize = true;
            cboxVideo.Enabled = false;
            cboxVideo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboxVideo.Location = new Point(40, 85);
            cboxVideo.Name = "cboxVideo";
            cboxVideo.Size = new Size(15, 14);
            cboxVideo.TabIndex = 72;
            cboxVideo.UseVisualStyleBackColor = true;
            // 
            // lblLang
            // 
            lblLang.AutoSize = true;
            lblLang.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLang.Location = new Point(6, 47);
            lblLang.Name = "lblLang";
            lblLang.Size = new Size(77, 13);
            lblLang.TabIndex = 64;
            lblLang.Text = "Org. language:";
            // 
            // lblOriginalLang
            // 
            lblOriginalLang.AutoSize = true;
            lblOriginalLang.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOriginalLang.Location = new Point(81, 47);
            lblOriginalLang.Name = "lblOriginalLang";
            lblOriginalLang.Size = new Size(61, 13);
            lblOriginalLang.TabIndex = 65;
            lblOriginalLang.Text = "Test, Test2";
            // 
            // lblOriginalTitle
            // 
            lblOriginalTitle.AutoSize = true;
            lblOriginalTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOriginalTitle.Location = new Point(6, 28);
            lblOriginalTitle.Name = "lblOriginalTitle";
            lblOriginalTitle.Size = new Size(49, 13);
            lblOriginalTitle.TabIndex = 66;
            lblOriginalTitle.Text = "Org. title:";
            // 
            // lblOrgTitel
            // 
            lblOrgTitel.AutoSize = true;
            lblOrgTitel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrgTitel.Location = new Point(54, 28);
            lblOrgTitel.Name = "lblOrgTitel";
            lblOrgTitel.Size = new Size(61, 13);
            lblOrgTitel.TabIndex = 67;
            lblOrgTitel.Text = "Test, Test2";
            // 
            // lblVideo
            // 
            lblVideo.AutoSize = true;
            lblVideo.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVideo.Location = new Point(6, 85);
            lblVideo.Name = "lblVideo";
            lblVideo.Size = new Size(34, 13);
            lblVideo.TabIndex = 70;
            lblVideo.Text = "Video";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseDate.Location = new Point(6, 66);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(73, 13);
            lblReleaseDate.TabIndex = 68;
            lblReleaseDate.Text = "Release date:";
            // 
            // lblReleaseShortDate
            // 
            lblReleaseShortDate.AutoSize = true;
            lblReleaseShortDate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblReleaseShortDate.Location = new Point(77, 66);
            lblReleaseShortDate.Name = "lblReleaseShortDate";
            lblReleaseShortDate.Size = new Size(61, 13);
            lblReleaseShortDate.TabIndex = 69;
            lblReleaseShortDate.Text = "Test, Test2";
            // 
            // lblOverview
            // 
            lblOverview.AutoSize = true;
            lblOverview.Font = new Font("Source Sans Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblOverview.Location = new Point(3, 11);
            lblOverview.Name = "lblOverview";
            lblOverview.Size = new Size(68, 18);
            lblOverview.TabIndex = 52;
            lblOverview.Text = "Overview:";
            // 
            // pboxBackdrop
            // 
            pboxBackdrop.Location = new Point(-1, 105);
            pboxBackdrop.Name = "pboxBackdrop";
            pboxBackdrop.Size = new Size(486, 287);
            pboxBackdrop.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxBackdrop.TabIndex = 51;
            pboxBackdrop.TabStop = false;
            // 
            // tboxOverview
            // 
            tboxOverview.BorderStyle = BorderStyle.None;
            tboxOverview.Font = new Font("Source Sans Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tboxOverview.Location = new Point(9, 35);
            tboxOverview.Multiline = true;
            tboxOverview.Name = "tboxOverview";
            tboxOverview.ReadOnly = true;
            tboxOverview.ScrollBars = ScrollBars.Vertical;
            tboxOverview.Size = new Size(476, 64);
            tboxOverview.TabIndex = 50;
            tboxOverview.TabStop = false;
            // 
            // lblRelease
            // 
            lblRelease.AutoSize = true;
            lblRelease.Font = new Font("Source Sans Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRelease.Location = new Point(26, 54);
            lblRelease.Name = "lblRelease";
            lblRelease.Size = new Size(88, 18);
            lblRelease.TabIndex = 51;
            lblRelease.Text = "Release date:";
            // 
            // tboxMovieID
            // 
            tboxMovieID.BackColor = SystemColors.Control;
            tboxMovieID.BorderStyle = BorderStyle.None;
            tboxMovieID.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            tboxMovieID.ForeColor = SystemColors.ControlDarkDark;
            tboxMovieID.Location = new Point(43, 590);
            tboxMovieID.Name = "tboxMovieID";
            tboxMovieID.ReadOnly = true;
            tboxMovieID.Size = new Size(32, 13);
            tboxMovieID.TabIndex = 40;
            tboxMovieID.TabStop = false;
            tboxMovieID.Text = "454577";
            // 
            // lblScoreValue
            // 
            lblScoreValue.AutoSize = true;
            lblScoreValue.Font = new Font("Source Sans Pro Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoreValue.Location = new Point(541, 48);
            lblScoreValue.Name = "lblScoreValue";
            lblScoreValue.Size = new Size(35, 24);
            lblScoreValue.TabIndex = 54;
            lblScoreValue.Text = "0.0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(26, 590);
            label1.Name = "label1";
            label1.Size = new Size(15, 12);
            label1.TabIndex = 55;
            label1.Text = "id:";
            // 
            // pboxPoster
            // 
            pboxPoster.Location = new Point(26, 77);
            pboxPoster.Name = "pboxPoster";
            pboxPoster.Size = new Size(340, 510);
            pboxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxPoster.TabIndex = 57;
            pboxPoster.TabStop = false;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Source Sans Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblRating.Location = new Point(535, 32);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(47, 18);
            lblRating.TabIndex = 58;
            lblRating.Text = "Rating";
            // 
            // lblVoters
            // 
            lblVoters.AutoSize = true;
            lblVoters.Font = new Font("Source Sans Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblVoters.Location = new Point(623, 32);
            lblVoters.Name = "lblVoters";
            lblVoters.Size = new Size(47, 18);
            lblVoters.TabIndex = 59;
            lblVoters.Text = "Voters";
            // 
            // lblVoteCount
            // 
            lblVoteCount.AutoSize = true;
            lblVoteCount.Font = new Font("Source Sans Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoteCount.Location = new Point(628, 52);
            lblVoteCount.Name = "lblVoteCount";
            lblVoteCount.Size = new Size(43, 18);
            lblVoteCount.TabIndex = 60;
            lblVoteCount.Text = "52522";
            lblVoteCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPopularity
            // 
            lblPopularity.AutoSize = true;
            lblPopularity.Font = new Font("Source Sans Pro Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblPopularity.Location = new Point(710, 32);
            lblPopularity.Name = "lblPopularity";
            lblPopularity.Size = new Size(72, 18);
            lblPopularity.TabIndex = 61;
            lblPopularity.Text = "Popularity";
            // 
            // lblPopularityCount
            // 
            lblPopularityCount.AutoSize = true;
            lblPopularityCount.Font = new Font("Source Sans Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPopularityCount.Location = new Point(722, 53);
            lblPopularityCount.Name = "lblPopularityCount";
            lblPopularityCount.Size = new Size(43, 18);
            lblPopularityCount.TabIndex = 62;
            lblPopularityCount.Text = "52522";
            lblPopularityCount.TextAlign = ContentAlignment.TopCenter;
            // 
            // MovieDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 622);
            Controls.Add(lblPopularityCount);
            Controls.Add(lblPopularity);
            Controls.Add(lblVoteCount);
            Controls.Add(lblVoters);
            Controls.Add(lblRating);
            Controls.Add(pboxPoster);
            Controls.Add(lblScoreValue);
            Controls.Add(label1);
            Controls.Add(tboxMovieID);
            Controls.Add(lblRelease);
            Controls.Add(pnlDetails);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MovieDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Details";
            pnlDetails.ResumeLayout(false);
            pnlDetails.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxBackdrop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Panel pnlDetails;
        private TextBox tboxOverview;
        private Label lblMovieID;
        private TextBox tboxMovieID;
        private Label lblRelease;
        private Label lblScoreValue;
        private Label label1;
        private PictureBox pboxBackdrop;
        private PictureBox pboxPoster;
        private Label lblOverview;
        private Label lblRating;
        private Label lblVoters;
        private Label lblScoreMax;
        private Label lblVoteCount;
        private Label lblPopularity;
        private Label lblPopularityCount;
        private Label lblGenre;
        private Label lblGenreList;
        private Label lblOriginalLang;
        private Label lblLang;
        private Label lblOrgTitel;
        private Label lblOriginalTitle;
        private Label lblReleaseShortDate;
        private Label lblReleaseDate;
        private CheckBox cboxVideo;
        private Label lblAdult;
        private Label lblVideo;
        private CheckBox cboxAdult;
        private Panel panel1;
    }
}