using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilalJson
{
    public partial class MovieDetails : Form
    {
        Movie m;
        public MovieDetails(Movie m)
        {
            this.m = m;

            InitializeComponent();

            Load += MovieDetails_Load;
        }

        private void MovieDetails_Load(object? sender, EventArgs e)
        {
            if (m != null)
            {
                lblTitel.Text = m.Title;
                tboxOverview.Text = m.Overview;
                tboxMovieID.Text = m.MovieId.ToString();
                lblRelease.Text = m.ReleaseDate.Year.ToString();
                lblScoreValue.Text = m.VoteAverage.ToString();
                pboxBackdrop.ImageLocation = m.BackdropPath;
                pboxPoster.ImageLocation = m.PosterPath;
                lblVoteCount.Text = m.VoteCount.ToString();
                lblPopularityCount.Text = m.Popularity.ToString();
                try
                {
                    lblGenreList.Text = string.Join(", ", m.Genres.Select(x => x.Name));
                }
                catch (Exception)
                {
                    lblGenreList.Text = "None";
                }
                lblOriginalLang.Text = m.OriginalLanguage.ToString();
                lblOrgTitel.Text = m.OriginalTitle.ToString();
                lblReleaseShortDate.Text = m.ReleaseDate.ToShortDateString();
            }
        }
    }
}
