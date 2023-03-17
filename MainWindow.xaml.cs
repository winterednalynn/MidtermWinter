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

namespace MidtermWinter
{
    //EDNA LYNN LAXA 
    // WINTER MIDTERM 
    // MARCH 14, 2023 
    //CSI 122 - PROGRAMMING II 


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<UNITS> homes = new List<UNITS>();
        UNITS currentUnit = null;

        public MainWindow()
        {
            InitializeComponent();
            Preload();
            DisplayInformation();

        }
        void Preload()
        {
            Random rand = new Random();
            int end = 10;

            for (int i = 0; i < end; i++)
            {
                string home = "S" + i;

                if (rand.Next(0, 10) != 0)
                {

                    homes.Add(new UNITS(home));
                }
                else
                {
                    homes.Add(new UNITS(home, false));
                }
            }
        }

        public void DisplayInformation()
        {
            lbUnits.Items.Clear(); // CODE STRUCTRUE TO CLEAR ITEMS IN LISTBOX 

            for (int i = 0; i < homes.Count; i++)
            {
                lbUnits.Items.Add(homes[i]); // USING A FOR LOOP TO GO THROUGH MY HOME LIST. 
            }
        }
        public string runDisplayInformation(UNITS homes) // FOCAL POINT : Richbox input 
        {
            // WHEN A SELECTED UNIT IS HIGHLIGHTED ONTO THE LIST BOX , THIS MESSAGE WILL BE PROMPT 
            // ONTO THE RTB. 

            string formattedinfo = $"Unit Number: {homes.ApartmentNumber}";
            //GIVING VALUE TO "FORMATTED INFO" 

            if (homes.IsOccupied) // USING IF FOR , IF home is vacant this message will prompt 
            {
                formattedinfo += $"This is available";
            }
            else
            {
                formattedinfo += $"Unavailable"; // THE ELSE section for OCCUPIED UNITS. 
            }

            return formattedinfo;
        }


        public void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // THIS METHOD GENERATED BECAUSE I DOUBLE CLICKED THE LIST BOX: HERE IS THE ACTION: 

            // IN THE PREVIOUS METHOD (runDisplayInformation) I mentioned when a unit is highlighted
            // the information is placed on to the RTB: this is the structure that initiates that 
            //process. lbUnits.SelectedIndex is when a unit is selected & then when it is clicked
            // the message will display, hence the previous method being called. 

            int selectedunit = lbUnits.SelectedIndex;
            currentUnit = homes[selectedunit];

            runDisplay.Text = runDisplayInformation(currentUnit);


        }

        public void btnAddUpdate_Click(object sender, RoutedEventArgs e)
        {
            // This click event correlates to the ADD/UPDATE Tenant. My main focal point was to 
            //update information for new residents who will occupy the space that are vacant. 

            int selectedhome = lbUnits.SelectedIndex; // Choosing the index for unit that is vacant 

            for (int i = 0; i < homes.Count; i++) // Using for loop to go through the unit list. 
            {
                if (selectedhome == i) // if choosing vacant unit, this message will prompt to RTB. 
                {
                    runDisplay.Text = "";

                    runDisplay.Text += txtFirstName.Text + "\n";
                    runDisplay.Text += txtLastName.Text + "\n";
                    runDisplay.Text += txtMontlhlyPayment.Text + "\n";
                    runDisplay.Text += txtNumofBedrooms.Text + "\n";




                }
                else
                {

                }

            }
        }

        public void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // FOR THE BUTTON REMOVE , it will remove any data in the RTB . 

            runDisplay.Text = "";
        }

        public void DisplayUpdatedInfomation()
        {
            // I made a seperate method for the formatted of the updated information. 

            int selectedhome = lbUnits.SelectedIndex;

            for (int i = 0; i < homes.Count; i++)
            {
                if (selectedhome == i)
                {
                    runDisplay.Text = "";

                    runDisplay.Text += txtFirstName.Text + "\n";
                    runDisplay.Text += txtLastName.Text + "\n";
                    runDisplay.Text += txtMontlhlyPayment.Text + "\n";
                    runDisplay.Text += txtNumofBedrooms.Text + "\n";




                }
                else
                {

                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // For the pay full button; my focus was to prompt a message to those who paid in full 
            // I deemed anything over $1000 to be paid full. 

            int payment = 0;

            if (payment >= 1000)
            {
                txtPayment.Text = $"You paid your rent";
            }
            else
            {
                txtPayment.Text = $"Transaction invalid";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //PARTIALLY PAID 

            // The coding structure shows that anything that's paid below 800 or 800 , a message will 
            // show stating Please pay the rest in 2 weeks. 
            int payment = 0;

            if (payment <= 800)
            {
                txtPayment.Text = $"Transaction Approved, Please pay the rest in 2 weeks";
            }
            else
            {
                txtPayment.Text = $"Please pay 800 or under";
            }
        }
    }
}
