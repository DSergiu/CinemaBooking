namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // Movies
    {
        private void FirstLoad_Movie() 
        {
            GetMoviesFromDB(0, 10);
        }


        private void GetMoviesFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of movies...");
                ICollection<Movie> movies = CinemaClient.Client.GetMoviePerPage(page.ToString(), noperpage.ToString());
                Grid_Movie.Rows.Clear();

                foreach (var movie in movies)  AddRow(movie);

                Grid_Movie.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void AddRow(Movie movie)
        {
            var index = Grid_Movie.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_Movie.Rows[index];
            row.Cells[0].Value = movie.MovieId;
            row.Cells[1].Value = String.Format("{0} ({1})", movie.MovieInfo.Title, movie.MovieInfoId);
            row.Cells[2].Value = movie.Is3D;
        }



        private void Movie_Button_Insert_Click(object sender, EventArgs e)
        {
            Movie movieToInsert = GetMovieDataFromFields();

            try
            {
                movieToInsert.MovieId = CinemaClient.Client.CreateMovie(movieToInsert);
                AddRow(movieToInsert);

                Info_Right_Show(String.Format("The Movie ({0}) was successfully inserted.", movieToInsert.MovieId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Movie_Button_Update_Click(object sender, EventArgs e)
        {
            Movie movieToUpdate = GetMovieDataFromFields();

            if (movieToUpdate.MovieId <= 0 || movieToUpdate.MovieInfoId <= 0)
            {
                Info_Wrong_Show("You didn't select a movie row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateMovie(movieToUpdate, movieToUpdate.MovieId.ToString());
                Grid_Movie.Rows.RemoveAt(Grid_Movie.SelectedRows[0].Index);
                AddRow(movieToUpdate);

                Info_Right_Show(String.Format("The Movie ({0}) was successfully updated.", movieToUpdate.MovieInfoId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void Movie_Button_Clear_Click(object sender, EventArgs e)
        {
            Movie_Textbox_Id.Text = "auto";
            Movie_Textbox_MovieInfoId.Value = 0;
            Movie_CheckBox_Is3D.Checked = false;

            Movie_Button_Update.Visible = false;
            Movie_Button_Insert.Visible = true;

            Grid_Movie.ClearSelection();
        }

        private void Grid_Movie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try  {
                Movie movie = CinemaClient.Client.GetMovie(Grid_Movie.Rows[e.RowIndex].Cells[0].Value.ToString());

                Movie_Textbox_Id.Text = movie.MovieId.ToString();
                Movie_Textbox_MovieInfoId.Value = (decimal)movie.MovieInfoId;
                Movie_CheckBox_Is3D.Checked = movie.Is3D;

                Movie_Button_Insert.Visible = false;
                Movie_Button_Update.Visible = true;
            } catch { }
        }

        private void Grid_Movie_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_Movie.Rows[e.RowIndex].Selected = true;
        }  

        private void Grid_Movie_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Movie Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteMovie(Grid_Movie.Rows[Grid_Movie.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Movie was successfully deleted."));
                }
                catch (Exception ex)
                {
                    HandleException(ex);

                    e.Cancel = true;     //cancel this operation
                }
                
            }
            else
            {
                e.Cancel = true; //cancel this operation
            }
        }




        private Movie GetMovieDataFromFields() 
        {
            int id = 0;
            int movieinfoid = 0;
            try
            {
                id = Int32.Parse(Movie_Textbox_Id.Text);
                movieinfoid = Int32.Parse(Movie_Textbox_MovieInfoId.Value.ToString());
            }
            catch {}


            bool is3d = Movie_CheckBox_Is3D.Checked;

            Movie movie = new Movie
            {
                MovieId = id,
                MovieInfoId = movieinfoid,
                Is3D = is3d
            };

            return movie;
        }
    }
}
