using Repository;
using Repository.Dto;
using Repository.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPF_AppLivery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<People> Authors { get; set; }
        private ComicVineRepository Repo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Authors = new List<People>();
            Repo = new ComicVineRepository();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadNextAuthors();
        }

        private async void LoadNextAuthors()
        {
            var nextGroup = await Repo.GetPeople(new PeopleFilter() { Offset = Authors.Count(), ShortByName = "asc" });
            Authors.AddRange(nextGroup.Results);

            Resources["AuthorsList"] = Authors.Select(x => x.Name).ToArray();
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            if (Authors.Any() && scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
                LoadNextAuthors();
            }
        }
    }
}
