namespace BilalJson
{
    public partial class moviesOverview : Form
    {
        const int pageSize = 25;

        JsonConverter jsonConverter;
        List<Movie> movies;
        
        public moviesOverview()
        {
            jsonConverter = new JsonConverter();

            InitializeComponent();

            Load += MoviesOverview_Load;

            dgv.SelectionChanged += Dgv_SelectionChanged;
            dgv.DataBindingComplete += Dgv_DataBindingComplete;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Dgv_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblDisplayedCount.Text = dgv.RowCount.ToString();
            lblTotalCount.Text = movies.Count.ToString();
        }

        private void Dgv_SelectionChanged(object? sender, EventArgs e)
        {
            lblSelectedCount.Text = dgv.SelectedRows.Count.ToString();
        }

        private async void MoviesOverview_Load(object? sender, EventArgs e)
        {
            movies = new List<Movie>(await jsonConverter.Get());
            LoadPage(1);
        }

        private void LoadPage(int page)
        {
            if (movies != null)
            {
                dgv.DataSource = movies.Skip((page - 1) * pageSize).Take(pageSize).ToList();
                dgv.Columns["Id"].Visible = false;
                dgv.Columns["Title"].DisplayIndex = 0;
                dgv.Columns["Overview"].DisplayIndex = 1;
                dgv.Columns["OriginalLanguage"].DisplayIndex = 2;
                dgv.Columns["MovieId"].DisplayIndex = 3;
                dgv.Columns["ReleaseDate"].DisplayIndex = 4;
                dgv.Columns["VoteAverage"].DisplayIndex = 5;
                dgv.Columns["VoteCount"].DisplayIndex = 6;
                dgv.Columns["Popularity"].DisplayIndex = 8;
                dgv.Columns["OriginalTitle"].DisplayIndex = 9;
                dgv.Columns["Video"].DisplayIndex = 10;
                dgv.Columns["Adult"].DisplayIndex = 13;
            }
        }
    }
}
