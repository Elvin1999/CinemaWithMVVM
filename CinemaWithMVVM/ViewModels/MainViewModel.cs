using CinemaWithMVVM.Commands;
using CinemaWithMVVM.Services;
using CinemaWithMVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CinemaWithMVVM.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(); }
        }

        public RelayCommand SearchCommand { get; set; }
        public WrapPanel MyPanel { get; set; }

        public MainViewModel()
        {
            SearchCommand = new RelayCommand((e) =>
              {
                  var movies = MovieService.GetMovies(SearchText);
                  int x = 10;
                  int y = 10;
                  foreach (var m in movies)
                  {
                      var uc = new MovieCellUC();
                      uc.Width = 300;
                      uc.Height = 200;
                      uc.Margin = new System.Windows.Thickness(x,y,0,0);
                   
                      var ucVM = new MovieCellViewModel
                      {
                          Movie = m,
                      };
                      uc.DataContext = ucVM;

                      MyPanel.Children.Add(uc);



                  }

              });
        }
    }
}
