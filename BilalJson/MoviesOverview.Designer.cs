namespace BilalJson
{
    partial class moviesOverview
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
            dgv = new DataGridView();
            lblDisplayed = new Label();
            lblDisplayedCount = new Label();
            lblSelectedCount = new Label();
            lblSelected = new Label();
            lblTotalCount = new Label();
            lblTotal = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            tboxPage = new TextBox();
            lblPages = new Label();
            lblPagesCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(1012, 656);
            dgv.TabIndex = 0;
            // 
            // lblDisplayed
            // 
            lblDisplayed.AutoSize = true;
            lblDisplayed.Location = new Point(12, 686);
            lblDisplayed.Name = "lblDisplayed";
            lblDisplayed.Size = new Size(61, 15);
            lblDisplayed.TabIndex = 1;
            lblDisplayed.Text = "Displayed:";
            // 
            // lblDisplayedCount
            // 
            lblDisplayedCount.AutoSize = true;
            lblDisplayedCount.Location = new Point(73, 686);
            lblDisplayedCount.Name = "lblDisplayedCount";
            lblDisplayedCount.Size = new Size(0, 15);
            lblDisplayedCount.TabIndex = 2;
            // 
            // lblSelectedCount
            // 
            lblSelectedCount.AutoSize = true;
            lblSelectedCount.Location = new Point(1011, 671);
            lblSelectedCount.Name = "lblSelectedCount";
            lblSelectedCount.Size = new Size(0, 15);
            lblSelectedCount.TabIndex = 4;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(959, 671);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(54, 15);
            lblSelected.TabIndex = 3;
            lblSelected.Text = "Selected:";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(47, 671);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(0, 15);
            lblTotalCount.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 671);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(545, 680);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(25, 25);
            btnNext.TabIndex = 7;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrev.Location = new Point(465, 680);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(25, 25);
            btnPrev.TabIndex = 8;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // tboxPage
            // 
            tboxPage.BackColor = SystemColors.ControlLightLight;
            tboxPage.BorderStyle = BorderStyle.None;
            tboxPage.Location = new Point(498, 685);
            tboxPage.Name = "tboxPage";
            tboxPage.Size = new Size(40, 16);
            tboxPage.TabIndex = 9;
            tboxPage.Text = "1";
            tboxPage.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPages
            // 
            lblPages.AutoSize = true;
            lblPages.Location = new Point(12, 701);
            lblPages.Name = "lblPages";
            lblPages.Size = new Size(41, 15);
            lblPages.TabIndex = 10;
            lblPages.Text = "Pages:";
            // 
            // lblPagesCount
            // 
            lblPagesCount.AutoSize = true;
            lblPagesCount.Location = new Point(53, 701);
            lblPagesCount.Name = "lblPagesCount";
            lblPagesCount.Size = new Size(0, 15);
            lblPagesCount.TabIndex = 11;
            // 
            // moviesOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 722);
            Controls.Add(lblPagesCount);
            Controls.Add(lblPages);
            Controls.Add(tboxPage);
            Controls.Add(btnPrev);
            Controls.Add(btnNext);
            Controls.Add(lblTotalCount);
            Controls.Add(lblTotal);
            Controls.Add(lblSelectedCount);
            Controls.Add(lblSelected);
            Controls.Add(lblDisplayedCount);
            Controls.Add(lblDisplayed);
            Controls.Add(dgv);
            Name = "moviesOverview";
            Text = "Movies Overview";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Label lblDisplayed;
        private Label lblDisplayedCount;
        private Label lblSelectedCount;
        private Label lblSelected;
        private Label lblTotalCount;
        private Label lblTotal;
        private Button btnNext;
        private Button btnPrev;
        private TextBox tboxPage;
        private Label lblPages;
        private Label lblPagesCount;
    }
}
