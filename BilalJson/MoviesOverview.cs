namespace BilalJson
{
    public partial class moviesOverview : Form
    {
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
            movies = await jsonConverter.Get();
            if (movies != null)
            {
                dgv.DataSource = movies.Take(10).ToList();
            }
        }
    }
}
