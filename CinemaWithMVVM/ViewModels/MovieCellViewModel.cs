using CinemaWithMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWithMVVM.ViewModels
{
    public class MovieCellViewModel : BaseViewModel
    {

        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set
            {
                movie = value; movie.Description = movie.Description.Substring(0, 30);
                OnPropertyChanged();
            }
        }


        public MovieCellViewModel()
        {

        }


    }
}
