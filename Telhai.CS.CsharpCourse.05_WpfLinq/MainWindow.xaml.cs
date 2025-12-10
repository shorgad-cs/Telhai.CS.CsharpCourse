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
using Telhai.CS.CsharpCourse._05_WpfLinq.Models;

namespace Telhai.CS.CsharpCourse._05_WpfLinq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.songsListBox.SelectionChanged += SongsListBox_SelectionChanged;
                
        }

        private void SongsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (songsListBox.Items.Count > 0)
            {
                this.Title = songsListBox.SelectedItem.ToString();
                lbl.Content = songsListBox.SelectedItem.ToString();
            }
        }

        int index = 0;
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
          
            index++;
            this.songsListBox.Items.Add("Item_"+index);
        }

        List<Song> songs = new List<Song>() {
              new Song{ Id=Guid.NewGuid().ToString(),Name="song 1",Duration=3.20f },
              new Song{ Id=Guid.NewGuid().ToString(),Name="song 2",Duration=2.20f },
              new Song{ Id=Guid.NewGuid().ToString(),Name="song 3",Duration=1.20f },

            };


        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            //this.songsListBox.ItemsSource = null;
            // this.songsListBox.ItemsSource = songs;

            var rangeList = songs
                  .Where(s => s.Duration > 1f && s.Duration < 2.5f)
                  .OrderBy(s => s.Duration);
             

            songsListBox.Items.Clear();
            foreach (Song s in rangeList)
            {
                songsListBox.Items.Add(s);
            }





        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}