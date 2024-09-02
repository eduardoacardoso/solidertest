using Azure.Core.GeoJson;
using Newtonsoft.Json;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfSoldier.Application.Interface;
using WpfSoldier.Domain.Entities;

namespace WpfAppSoldier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IGenericRepository<Soldier> _repositorySoldier;
        private readonly IGenericRepository<Position> _repositoryPosition;
        private readonly IGenericRepository<Training> _repositoryTraining;
        private readonly IGenericRepository<Sensor> _repositorySensor;
        public MainWindow()
        {
            //InitializeComponent();
        }
        public MainWindow(IGenericRepository<Soldier> repositorySoldier, IGenericRepository<Position> repositoryPosition, IGenericRepository<Training> repositoryTraining, IGenericRepository<Sensor> repositorySensor)
        {
            _repositorySoldier = repositorySoldier;
            _repositoryPosition = repositoryPosition;
            _repositoryTraining = repositoryTraining;
            _repositorySensor = repositorySensor;
            
            InitializeComponent();
        }

        private void btnSimulation_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            // Latitude ranges from -90 to 90
            double latitude = random.NextDouble() * 180 - 90;

            // Longitude ranges from -180 to 180
            double longitude = random.NextDouble() * 360 - 180;

            //On Simulate Get User
            var soldier = _repositorySoldier.SelectAll().FirstOrDefault();

            soldier.Positions = new List<Position>();

            var item = new Position  { SoldierId = soldier.SoldierId, Latitude = (decimal)latitude, Longitude = (decimal)longitude };

            _repositoryPosition.Insert(new Position { PositionId = Guid.NewGuid(),SoldierId = soldier.SoldierId, Latitude = (decimal)latitude, Longitude = (decimal)longitude });
            _repositoryPosition.Save();

            MessageBox.Show("Move Soldier: latitude -> " + latitude.ToString() + " , " + "longitude -> "+ longitude.ToString());
        }

        private void btnLoadJson_Click(object sender, RoutedEventArgs e)
        {
            //On Simulate Get User
            var soldier = _repositorySoldier.SelectAll().FirstOrDefault();
            MessageBox.Show("History Soldier Position: " + JsonConvert.SerializeObject(_repositoryPosition.SelectAll().Where(x=>x.SoldierId == soldier.SoldierId).ToList()));
        }

        private void btnGetSoldierInformation_Click(object sender, RoutedEventArgs e)
        {
            //On Simulate Get User
            var soldier = _repositorySoldier.SelectAll().FirstOrDefault();

            MessageBox.Show("Soldier Information: " + JsonConvert.SerializeObject(_repositorySoldier.SelectByID(soldier.SoldierId)));
        }
    }
}