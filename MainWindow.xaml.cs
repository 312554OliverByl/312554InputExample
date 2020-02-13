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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _312554InputExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global variables:
        //Declare here so that multiple methods can access.
        int counter;

        public MainWindow()
        {
            InitializeComponent();
            counter = 0;
        }

        private void onBtnAddButtonClick(object sender, RoutedEventArgs e)
        {
            //Writing this line is equivalent to declaring a <Button></Button> in xaml
            //Any xaml object can be created with C# code in this way.
            Button b = new Button();

            b.Name = "b" + counter.ToString(); //b.Name instead of xaml x:Name=""
            b.Content = "I am button " + counter.ToString(); //b.Content instead of xaml Content=""
            //All xaml properties can be set in this way as well: <variable>.<property>

            counter++; //"counter++;" is equivalent to "counter = counter + 1;"
            //this is a feature because programmers are lazy

            b.Click += B_Click; //Adding a click event. Works the same way as xaml (press tab to auto-create)
            //     ^^^^ make sure you write += instead of just =

            stackpanel.Children.Add(b);
            //get "stackpanel" (which we can do because we set the StackPanel's x:Name)
            //get its "Children" (a list of the GUI elements it controls)
            //add the button we've created to that list
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            //The "sender" is the button that was clicked.
            //Just like integers, we can "cast" the sender to be a Button (because we know that's what it is)
            Button rb = (Button) sender;
            //          ^^^ casting the sender, which is of type "object" (from parenthesis above)

            MessageBox.Show(rb.Content.ToString());
        }
    }
}