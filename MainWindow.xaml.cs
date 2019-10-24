using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfFirstProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            switch (name)
            {
                case "button1":
                    AnimFunc((sender as Button), Convert.ToInt32(-row0.ActualHeight-(row0.ActualHeight/3)), 0);
                    break;
            }
        }

        private void AnimFunc(Button button, int yproperty, int xproperty)
        {
            TranslateTransform trans = new TranslateTransform();
            button.RenderTransform = trans;
            DoubleAnimation anim = new DoubleAnimation(0, yproperty, TimeSpan.FromSeconds(0.5));
            anim.EasingFunction = new QuadraticEase();
            trans.BeginAnimation(TranslateTransform.YProperty, anim);
            DoubleAnimation anim2 = new DoubleAnimation(0, xproperty, TimeSpan.FromSeconds(0.5));
            anim2.EasingFunction = new QuadraticEase();
            trans.BeginAnimation(TranslateTransform.XProperty, anim2);
        }
    }
}
