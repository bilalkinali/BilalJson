using System.Windows.Forms;

namespace BilalJson
{
    // "..\bin\Debug\net6.0-windows\TopratedRelations.json"                     --*

    public partial class moviesOverview : Form
    {
        const int pageSize = 25;

        JsonConverter jsonConverter;
        MovieDetails mDetails;
        List<Movie> movies;

        int totalPage;
        int currentPage;

        public moviesOverview()
        {
            jsonConverter = new JsonConverter();

            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            float test = (float)DeviceDpi / 96;
            InitializeComponent();
            test = (float)DeviceDpi / 96;
            Load += MoviesOverview_Load;

            // DataGridView                                                     --*
            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.DataBindingComplete += Dgv_DataBindingComplete;
            dgv.CellDoubleClick += Dgv_CellDoubleClick;            

            // Page navigation                                                  --*
            currentPage = 1;
            btnPrev.Cursor = btnNext.Cursor = Cursors.Hand;
            tboxPage.TextChanged += TboxPage_TextChanged;
            btnPrev.Click += BtnPrev_Click;
            btnNext.Click += BtnNext_Click;
            btnPrev.Enabled = false;

            // Combobox                                                         --*
            cmbox.SelectionChangeCommitted += Cmbox_SelectionChangeCommitted;

            // Add filtering options                                            --*

        }

        private void Cmbox_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            switch (cmbox.SelectedItem)
            {
                case "Rating":
                    movies = movies.OrderByDescending(m => m.VoteAverage).ThenBy(m => m.Id).ToList();
                    break;
                case "Title":
                    movies = movies.OrderBy(m => m.Title).ToList();
                    break;
                case "Release date":
                    movies = movies.OrderByDescending(m => m.ReleaseDate).ThenBy(m => m.Id).ToList();
                    break;
                case "Popularity":
                    movies = movies.OrderByDescending(m => m.Popularity).ToList();
                    break;
            }
            // Defaults to front page
            currentPage = 1;
            LoadPage(currentPage);
        }

        private void Dgv_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Skip the headers
            if (e.RowIndex >= 0)
            {
                // Open data bount object
                if (dgv.Rows[e.RowIndex].DataBoundItem is Movie movie)
                {
                    mDetails = new MovieDetails(movie);
                    mDetails.Show();
                } 
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            // If field is empty and button is pressed, show first page
            if (string.IsNullOrEmpty(tboxPage.Text))
                tboxPage.Text = "1";
            else
                tboxPage.Text = (int.Parse(tboxPage.Text) + 1).ToString();
        }

        private void BtnPrev_Click(object? sender, EventArgs e)
        {
            // If field is empty and button is pressed, show last page
            if (string.IsNullOrEmpty(tboxPage.Text))
                tboxPage.Text = totalPage.ToString();
            else
                tboxPage.Text = (int.Parse(tboxPage.Text) - 1).ToString();
        }

        private void TboxPage_TextChanged(object? sender, EventArgs e)
        {
            // Reject non-digit input
            bool digit = int.TryParse(tboxPage.Text, out currentPage);

            // Manage prev / next button according to the current page
            if (digit && currentPage >= 1 && currentPage <= totalPage)
            {
                btnPrev.Enabled = currentPage != 1;
                btnNext.Enabled = currentPage != totalPage;

                LoadPage(currentPage);
            }
            else
            {
                tboxPage.Text = "";
                btnPrev.Enabled = btnNext.Enabled = true;
            }
        }

        private void Dgv_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblDisplayedCount.Text = dgv.RowCount.ToString();
            lblTotalCount.Text = movies.Count.ToString();
            lblPagesCount.Text = totalPage.ToString();
        }

        private void Dgv_SelectionChanged(object? sender, EventArgs e)
        {
            lblSelectedCount.Text = dgv.SelectedRows.Count.ToString();
        }

        private async void MoviesOverview_Load(object? sender, EventArgs e)
        {
            movies = new List<Movie>(await jsonConverter.Get());
            if (movies != null)
            {
                // Calculate total pages
                totalPage = (movies.Count + pageSize - 1) / pageSize;

                // Sorting : Combobox
                cmbox.Items.Insert(0, "Rating");
                cmbox.Items.Add("Title");
                cmbox.Items.Add("Release date");
                cmbox.Items.Add("Popularity");
                cmbox.SelectedIndex = 0;

                LoadPage(currentPage);
                OrganizeDgv();
            }
        }

        private void LoadPage(int page)
        {
            if (movies != null)
            {
                // Paging
                dgv.DataSource = movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                tboxPage.Text = currentPage.ToString();
                OrganizeDgv();
            }
        }

        private void OrganizeDgv()
        {
            if (movies != null)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                dgv.Columns["Id"].Visible = dgv.Columns["Video"].Visible = dgv.Columns["Adult"].Visible =
                dgv.Columns["PosterPath"].Visible = dgv.Columns["BackdropPath"].Visible = false;

                
                dgv.Columns["Title"].DisplayIndex = 0;

                dgv.Columns["Overview"].DisplayIndex = 1;

                dgv.Columns["ReleaseDate"].HeaderText = "Release";
                dgv.Columns["ReleaseDate"].DisplayIndex = 2;

                dgv.Columns["OriginalLanguage"].HeaderText = "Origin";
                dgv.Columns["OriginalLanguage"].DisplayIndex = 3;

                dgv.Columns["VoteAverage"].HeaderText = "Rating";
                dgv.Columns["VoteAverage"].DisplayIndex = 4;

                dgv.Columns["VoteCount"].HeaderText = "Votes";
                dgv.Columns["VoteCount"].DisplayIndex = 5;

                dgv.Columns["Popularity"].DisplayIndex = 6;

                dgv.Columns["OriginalTitle"].HeaderText = "Original title";
                dgv.Columns["OriginalTitle"].DisplayIndex = 7;

                dgv.Columns["MovieId"].HeaderText = "Movie id";
                dgv.Columns["MovieId"].DisplayIndex = 8;
            }
        }
    }
}
