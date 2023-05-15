using Desktop.DB;
using System.Linq;
using System.Windows;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickButton(object sender, RoutedEventArgs e)
        {
            var Cur = AppData.db.position.FirstOrDefault(p => p.Number == Number.Text && p.Password == Password.Text);
            if(Cur != null)
            {
                string userName = string.IsNullOrEmpty(Cur.Role) ? "No name" : Cur.Role;
                MessageBox.Show($"User name: {userName}");
            }
            else
            {
                MessageBox.Show("NOYYYYYYYYYYYY");
            }
        }
    }
}