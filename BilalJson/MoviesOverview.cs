namespace BilalJson
{
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

            InitializeComponent();

            Load += MoviesOverview_Load;

            // DataGridView
            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.DataBindingComplete += Dgv_DataBindingComplete;
            dgv.CellDoubleClick += Dgv_CellDoubleClick;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Page navigation
            currentPage = 1;
            btnPrev.Cursor = btnNext.Cursor = Cursors.Hand;
            tboxPage.TextChanged += TboxPage_TextChanged;
            btnPrev.Click += BtnPrev_Click;
            btnNext.Click += BtnNext_Click;
            btnPrev.Enabled = false;

        }

        private void Dgv_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows[e.RowIndex].DataBoundItem is Movie movie)
            {
                mDetails = new MovieDetails(movie);
                mDetails.Show();
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPage.Text))
                tboxPage.Text = "1";
            else
                tboxPage.Text = (int.Parse(tboxPage.Text) + 1).ToString();
        }

        private void BtnPrev_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPage.Text))
                tboxPage.Text = totalPage.ToString();
            else
                tboxPage.Text = (int.Parse(tboxPage.Text) - 1).ToString();
        }

        private void TboxPage_TextChanged(object? sender, EventArgs e)
        {
            bool digit = int.TryParse(tboxPage.Text, out currentPage);

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
                totalPage = movies.Count / pageSize;
            }
            LoadPage(currentPage);
        }

        private void LoadPage(int page)
        {
            if (movies != null)
            {
                dgv.DataSource = movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                dgv.Columns["Id"].Visible = dgv.Columns["Video"].Visible = dgv.Columns["Adult"].Visible =
                dgv.Columns["PosterPath"].Visible = dgv.Columns["BackdropPath"].Visible = false;

                dgv.Columns["Title"].DisplayIndex = 0;
                dgv.Columns["Overview"].DisplayIndex = 1;
                dgv.Columns["ReleaseDate"].DisplayIndex = 2;
                dgv.Columns["VoteAverage"].DisplayIndex = 3;
                dgv.Columns["VoteCount"].DisplayIndex = 4;
                dgv.Columns["OriginalLanguage"].DisplayIndex = 5;
                dgv.Columns["Popularity"].DisplayIndex = 6;
                dgv.Columns["OriginalTitle"].DisplayIndex = 7;
                dgv.Columns["MovieId"].DisplayIndex = 8;
            }
        }
    }
}
