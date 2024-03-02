using Repository;
using Repository.Dto;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPF_AppLivery.CustomControllers;
using WPF_AppLivery.Model;

namespace WPF_AppLivery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Author> AuthorsCollection { get; set; }
        private ComicVineRepository Repo { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Repo = new ComicVineRepository();
            AuthorsCollection = new ObservableCollection<Author>();           
        }

        #region Events
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            libAuthors.ItemsSource = AuthorsCollection;
            LoadNextAuthors();

        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            //este evento se dipara numerosas veces ANTES del  Window_Loaded
            if (AuthorsCollection.Any() && scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
                LoadNextAuthors();
            }
        }
        private async void libAuthors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var result = await Repo.GetIssuesByAuthor(((Author)e.AddedItems[0]).Id);

            var element = new ImageAndName(result.Results.First().Name, result.Results.First().Image.MediumUrl);
            RootGrid.Children.Add(element);
            
            Grid.SetRow(element, 0);
            Grid.SetColumn(element, 1);
        }
        #endregion

        private async void LoadNextAuthors()
        {
            var nextGroup = await Repo.GetPeople(new PeopleFilter() { Offset = AuthorsCollection.Count(), ShortByName = "asc" });

            foreach (var auth in nextGroup.Results)
            {
                AuthorsCollection.Add(new Author { Id = auth.Id, Name = auth.Name });
            }
        }

      
    }
}
