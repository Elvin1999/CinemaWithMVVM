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
                      var ucVM = new MovieCellViewModel
                      {
                          Movie = m,
                      };

                      var uc = new MovieCellUC(ucVM);

                      var d = double.Parse(m.Rating.Replace('.',',')).ToString();
                     
                      double result=((double.Parse(d)+1)/2);
                      int count = (int)(result);
                      for (int i = 0; i < count; i++)
                      {
                          ucVM.StarsPanel.Children.Add(new StartUc());
                      }
                      uc.Width = 300;
                      uc.Height = 200;
                      uc.Margin = new System.Windows.Thickness(x,y,0,0);
                   
                     

                      MyPanel.Children.Add(uc);



                  }

              });
        }
    }
}
