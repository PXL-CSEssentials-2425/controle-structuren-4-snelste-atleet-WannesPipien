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

namespace Snelste_atleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string name;
        int time = 0;

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            int currentTime = int.Parse(timeTextBox.Text);

            if (currentTime < time || time == 0)
            {
                name = nameTextBox.Text;
                time = currentTime;
                nameTextBox.Clear();
                timeTextBox.Clear();   
                nameTextBox.Focus();
            }
            else
            {
                nameTextBox.Clear();
                timeTextBox.Clear();
                nameTextBox.Focus();
            }
        }

        private void fastButton_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan t = TimeSpan.FromSeconds(time);
            string answer = string.Format("{0:D2}uur\n{1:D2}minuten\n:{2:D2}seconden",
            t.Hours,
            t.Minutes,
            t.Seconds);

            resultTextBox.Text = $"De snelste atleet is {name}.\nTotale tijd {time} seconden.\n\n{answer}";

        }

        private void erasebutton_Click(object sender, RoutedEventArgs e)
        {
            nameTextBox.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();
        }

        private void closebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}