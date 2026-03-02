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
using Microsoft.VisualBasic;
using Microsoft.Windows.Themes;

namespace DroneATC;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        // Create the application's main window
        InitializeComponent();

        // Create a canvas sized to fill the window
        Canvas myCanvas = new Canvas();
        myCanvas.Background = Brushes.LightGray;
        this.Content = myCanvas;

        // Create a rectangle to represent a drone
        Rectangle drone = new Rectangle(); 

        drone.Width = 20;
        drone.Height = 20;

        drone.Fill = Brushes.Black;

        // Position the drone on the canvas
        Canvas.SetLeft(drone, 100);
        Canvas.SetTop(drone, 100); 

        // Add the drone to the canvas
        myCanvas.Children.Add(drone);

        //canvas update loop
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();

        timer.Interval = TimeSpan.FromMilliseconds(1); // Update every 1 ms

        timer.Tick += (sender, e) =>
        {
            // Move the drone to the right
            double currentLeft = Canvas.GetLeft(drone);
            Canvas.SetLeft(drone, currentLeft + 1);
        };

        timer.Start();

        List<Models.Drone> Drones = new List<Models.Drone>
        {
            new Models.Drone(1, 100, 100, 1000, 50),
            new Models.Drone(2, 200, 200, 1500, 60),
            new Models.Drone(3, 300, 300, 1200, 55)
        };
    }
}