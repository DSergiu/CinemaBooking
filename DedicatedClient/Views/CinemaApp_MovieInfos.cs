namespace DedicatedClient
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using CinemaService;
    using System.Windows.Forms;

    public partial class CinemaApp      // MovieInfos
    {
        private void FirstLoad_MovieInfo() 
        {
            GetMoviesInfoFromDB(0, 10);

            foreach (var agerestrict in Enum.GetValues(typeof(AgeRestriction)))
                MovieInfo_Combobox_AgeRestriction.Items.Add(agerestrict);

            MovieInfo_Combobox_AgeRestriction.SelectedIndex = 0;
        }


        async private void GetMoviesInfoFromDB(int page, int noperpage)
        {
            try
            {
                Info_Loading_Show("Getting a list of movie informations...");
                ICollection<MovieInfo> movieinfos = await CinemaClient.Client.GetMovieInfosPerPageAsync(page.ToString(), noperpage.ToString());
                Grid_MovieInfo.Rows.Clear();

                foreach (var movieinfo in movieinfos)
                    AddRow(movieinfo);

                Grid_MovieInfo.ClearSelection();

                Info_Hide();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void AddRow(MovieInfo movieinfo)
        {
            var index = Grid_MovieInfo.Rows.Add();
            DataGridViewRow row = (DataGridViewRow)Grid_MovieInfo.Rows[index];
            row.Cells[0].Value = movieinfo.MovieInfoId;
            row.Cells[1].Value = movieinfo.Title;
            row.Cells[2].Value = movieinfo.Description;
            row.Cells[3].Value = movieinfo.Director;
            row.Cells[4].Value = movieinfo.Actors;
            row.Cells[5].Value = movieinfo.ReleaseDate;
            row.Cells[6].Value = movieinfo.LenghtTime;
            row.Cells[7].Value = movieinfo.AgeRestriction;
            row.Cells[8].Value = movieinfo.Genre;
        }



        private void MovieInfo_Button_Insert_Click(object sender, EventArgs e)
        {
            MovieInfo movieinfoToInsert = GetMovieInfoDataFromFields();

            try
            {
                movieinfoToInsert.MovieInfoId = CinemaClient.Client.CreateMovieInfo(movieinfoToInsert);
                AddRow(movieinfoToInsert);

                Info_Right_Show(String.Format("The Movie Info ({0}) was successfully inserted.", movieinfoToInsert.MovieInfoId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void MovieInfo_Button_Update_Click(object sender, EventArgs e)
        {
            MovieInfo movieinfoToUpdate = GetMovieInfoDataFromFields();

            if (movieinfoToUpdate.MovieInfoId == 0)
            {
                Info_Wrong_Show("You didn't select a movie info row (Invalid ID).");
                return;
            }

            try
            {
                CinemaClient.Client.UpdateMovieInfo(movieinfoToUpdate, movieinfoToUpdate.MovieInfoId.ToString());
                Grid_MovieInfo.Rows.RemoveAt(Grid_MovieInfo.SelectedRows[0].Index);
                AddRow(movieinfoToUpdate);
                Info_Right_Show(String.Format("The Movie Info ({0}) was successfully updated.", movieinfoToUpdate.MovieInfoId));
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void MovieInfo_Button_Clear_Click(object sender, EventArgs e)
        {
            MovieInfo_Textbox_Id.Text = "auto";
            MovieInfo_Textbox_Title.Text = "";
            MovieInfo_Textbox_Description.Text = "";
            MovieInfo_Textbox_Actors.Text = "";
            MovieInfo_Textbox_Directors.Text = "";
            MovieInfo_Textbox_Genre.Text = "";
            MovieInfo_Combobox_AgeRestriction.SelectedItem = null;
            Movieinfo_Textbox_LenghtTime.Value = 0;
            MovieInfo_DatePicker_ReleaseDate.Value = DateTime.UtcNow;

            MovieInfo_Button_Update.Visible = false;
            MovieInfo_Button_Insert.Visible = true;

            Grid_MovieInfo.ClearSelection();
        }

        private void Grid_MovieInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MovieInfo movieinfo = CinemaClient.Client.GetMovieInfo(Grid_MovieInfo.Rows[e.RowIndex].Cells[0].Value.ToString());

                MovieInfo_Textbox_Id.Text = movieinfo.MovieInfoId.ToString();
                MovieInfo_Textbox_Title.Text = movieinfo.Title;
                MovieInfo_Textbox_Description.Text = movieinfo.Description;
                MovieInfo_Textbox_Actors.Text = movieinfo.Actors;
                MovieInfo_Textbox_Directors.Text = movieinfo.Director;
                MovieInfo_Textbox_Genre.Text = movieinfo.Genre;                
                MovieInfo_Combobox_AgeRestriction.SelectedItem = movieinfo.AgeRestriction;
                Movieinfo_Textbox_LenghtTime.Value = (decimal)movieinfo.LenghtTime;
                MovieInfo_DatePicker_ReleaseDate.Value = movieinfo.ReleaseDate;

                MovieInfo_Button_Insert.Visible = false;
                MovieInfo_Button_Update.Visible = true;
            }
            catch { }
        }



        private void Grid_MovieInfo_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Grid_MovieInfo.Rows[e.RowIndex].Selected = true;
        }  


        private void Grid_MovieInfo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Movie Info Row ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    CinemaClient.Client.DeleteMovieInfo(Grid_MovieInfo.Rows[Grid_MovieInfo.SelectedRows[0].Index].Cells[0].Value.ToString());
                    Info_Right_Show(String.Format("The selected Movie Info was successfully deleted."));
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

        private MovieInfo GetMovieInfoDataFromFields() 
        {
            int id = 0;
            try
            {
                id = Int32.Parse(MovieInfo_Textbox_Id.Text);
            }
            catch {}

            
            string title = MovieInfo_Textbox_Title.Text;
            string description = MovieInfo_Textbox_Description.Text;
            string actors = MovieInfo_Textbox_Actors.Text;
            string directors = MovieInfo_Textbox_Directors.Text;
            string genre = MovieInfo_Textbox_Genre.Text;

            AgeRestriction agerestriction = CinemaService.AgeRestriction.R_11;
            try {  agerestriction = (AgeRestriction)MovieInfo_Combobox_AgeRestriction.SelectedItem; } catch {  }
            
            int lenghttime = Int32.Parse(Movieinfo_Textbox_LenghtTime.Value.ToString());
            DateTime releaseDate = MovieInfo_DatePicker_ReleaseDate.Value;

            MovieInfo movieinfo = new MovieInfo
            {
                MovieInfoId = id,
                Title = title,
                Description = description,
                Actors = actors,
                Director = directors,
                Genre = genre,
                LenghtTime = lenghttime,
                AgeRestriction = agerestriction,
                ReleaseDate = releaseDate
            };

            return movieinfo;
        }
    }
}
