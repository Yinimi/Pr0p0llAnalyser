namespace pr0p0llDiagrams.Views
{
    /// <summary>
    ///     Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();
            var viewModel = new MainWindowViewModel();
            viewModel.Initialize();
            DataContext = viewModel;
        }
    }
}
