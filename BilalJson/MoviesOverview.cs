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
        }

        private async void MoviesOverview_Load(object? sender, EventArgs e)
        {
            movies = await jsonConverter.Get();
            dgv.DataSource = movies;
        }
    }
}
