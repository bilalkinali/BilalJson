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

            StartPosition = FormStartPosition.CenterParent;

            Load += MovieDetails_Load;
        }

        private void MovieDetails_Load(object? sender, EventArgs e)
        {
            if (m != null)
            {
                lblTitel.Text = m.Title;
                tboxOverview.Text = m.Overview;
                tboxMovieID.Text = m.MovieId.ToString();
                tboxRelease.Text = m.ReleaseDate.ToShortDateString();
                lblScoreValue.Text = m.VoteAverage.ToString();
            }
        }
    }
}
