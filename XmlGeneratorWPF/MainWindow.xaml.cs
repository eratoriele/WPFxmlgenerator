using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
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
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace XmlGeneratorWPF
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

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();
            // Set required fields to visible
            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;

            floorsTextBlock.Visibility = Visibility.Visible;
            floorsTextBox.Visibility = Visibility.Visible;
            groupsTextBlock.Visibility = Visibility.Visible;
            groupsTextBox.Visibility = Visibility.Visible;
            groupsTypeTextBlock.Visibility = Visibility.Visible;
            groupsTypeComboBox.Visibility = Visibility.Visible;
            behavioursTextBlock.Visibility = Visibility.Visible;
            behavioursTextBox.Visibility = Visibility.Visible;
            behavioursTypeTextBlock.Visibility = Visibility.Visible;
            behavioursTypeComboBox.Visibility = Visibility.Visible;
            behaviourEndTextBlock.Visibility = Visibility.Visible;
            behaviourEndDatePicker.Visibility = Visibility.Visible;
            behaviourDaysTextBlock.Visibility = Visibility.Visible;
            behaviourDaysMoComboBox.Visibility = Visibility.Visible;
            behaviourDaysTuComboBox.Visibility = Visibility.Visible;
            behaviourDaysWeComboBox.Visibility = Visibility.Visible;
            behaviourDaysThComboBox.Visibility = Visibility.Visible;
            behaviourDaysFrComboBox.Visibility = Visibility.Visible;
            behaviourDaysStComboBox.Visibility = Visibility.Visible;
            behaviourDaysSuComboBox.Visibility = Visibility.Visible;
            behaviourTimeTextBlock.Visibility = Visibility.Visible;
            behaviourTimeTextBox.Visibility = Visibility.Visible;
            timeStatusTextBlock.Visibility = Visibility.Visible;
            timeStatusComboBox.Visibility = Visibility.Visible;
            camerasTextBlock.Visibility = Visibility.Visible;
            cameraTextBox.Visibility = Visibility.Visible;
            spaceTextBlock.Visibility = Visibility.Visible;
            spaceTextBox.Visibility = Visibility.Visible;
            displayfromTextBlock.Visibility = Visibility.Visible;
            displayfromTextBox.Visibility = Visibility.Visible;
            displaytoTextBlock.Visibility = Visibility.Visible;
            displaytoTextBox.Visibility = Visibility.Visible;
            displayTypeTextBlock.Visibility = Visibility.Visible;
            displayTypeComboBox.Visibility = Visibility.Visible;
            zoneTextBlock.Visibility = Visibility.Visible;
            zoneTextBox.Visibility = Visibility.Visible;
            zoneTypeTextBlock.Visibility = Visibility.Visible;
            zoneTypeComboBox.Visibility = Visibility.Visible;
            zoneMemberTextBlock.Visibility = Visibility.Visible;
            zoneMemberTextBox.Visibility = Visibility.Visible;
            shaTextBlock.Visibility = Visibility.Visible;
            shaTextBox.Visibility = Visibility.Visible;

            submitButton.Visibility = Visibility.Visible;

            fromTextBlock.Text = "Controller from IP:";
            toTextBlock.Text = "Controller to IP:";

            behaviourEndDatePicker.SelectedDate = DateTime.Now;

            operationButton.IsEnabled = false;

            floorsTextBox.Focus();
        }

        private void PlateRecognitionButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();
            // Set required fields to visible
            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;
            dPathTextBlock.Visibility = Visibility.Visible;
            dPathTextBox.Visibility = Visibility.Visible;

            submitButton.Visibility = Visibility.Visible;

            plateRecognitionButton.IsEnabled = false;

            fromTextBox.Focus();
        }

        private void SecurityRecordingButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();
            // Set required fields to visible
            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;
            dPathTextBlock.Visibility = Visibility.Visible;
            dPathTextBox.Visibility = Visibility.Visible;

            submitButton.Visibility = Visibility.Visible;

            securityRecordingButton.IsEnabled = false;

            fromTextBox.Focus();
        }

        private void intTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void timeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9:]+").IsMatch(e.Text);
        }

        // Turns every button except for 3 main buttons to invisible, so that when a new one is selected,
        // Only the relevant ones are shown
        private void turnAllInvisible()
        {
            fromTextBox.Visibility = Visibility.Collapsed;
            fromTextBlock.Visibility = Visibility.Collapsed;
            toTextBox.Visibility = Visibility.Collapsed;
            toTextBlock.Visibility = Visibility.Collapsed;
            dPathTextBlock.Visibility = Visibility.Collapsed;
            dPathTextBox.Visibility = Visibility.Collapsed;
            floorsTextBlock.Visibility = Visibility.Collapsed;
            floorsTextBox.Visibility = Visibility.Collapsed;
            groupsTextBlock.Visibility = Visibility.Collapsed;
            groupsTextBox.Visibility = Visibility.Collapsed;
            groupsTypeTextBlock.Visibility = Visibility.Collapsed;
            groupsTypeComboBox.Visibility = Visibility.Collapsed;
            behavioursTextBlock.Visibility = Visibility.Collapsed;
            behavioursTextBox.Visibility = Visibility.Collapsed;
            behavioursTypeTextBlock.Visibility = Visibility.Collapsed;
            behavioursTypeComboBox.Visibility = Visibility.Collapsed;
            behaviourEndTextBlock.Visibility = Visibility.Collapsed;
            behaviourEndDatePicker.Visibility = Visibility.Collapsed;
            behaviourDaysTextBlock.Visibility = Visibility.Collapsed;
            behaviourDaysMoComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysTuComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysWeComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysThComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysFrComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysStComboBox.Visibility = Visibility.Collapsed;
            behaviourDaysSuComboBox.Visibility = Visibility.Collapsed;
            behaviourTimeTextBlock.Visibility = Visibility.Collapsed;
            behaviourTimeTextBox.Visibility = Visibility.Collapsed;
            timeStatusTextBlock.Visibility = Visibility.Collapsed;
            timeStatusComboBox.Visibility = Visibility.Collapsed;
            camerasTextBlock.Visibility = Visibility.Collapsed;
            cameraTextBox.Visibility = Visibility.Collapsed;
            spaceTextBlock.Visibility = Visibility.Collapsed;
            spaceTextBox.Visibility = Visibility.Collapsed;
            displayfromTextBlock.Visibility = Visibility.Collapsed;
            displayfromTextBox.Visibility = Visibility.Collapsed;
            displaytoTextBlock.Visibility = Visibility.Collapsed;
            displaytoTextBox.Visibility = Visibility.Collapsed;
            displayTypeTextBlock.Visibility = Visibility.Collapsed;
            displayTypeComboBox.Visibility = Visibility.Collapsed;
            zoneTextBlock.Visibility = Visibility.Collapsed;
            zoneTextBox.Visibility = Visibility.Collapsed;
            zoneTypeTextBlock.Visibility = Visibility.Collapsed;
            zoneTypeComboBox.Visibility = Visibility.Collapsed;
            zoneMemberTextBlock.Visibility = Visibility.Collapsed;
            zoneMemberTextBox.Visibility = Visibility.Collapsed;
            shaTextBlock.Visibility = Visibility.Collapsed;
            shaTextBox.Visibility = Visibility.Collapsed;

            fromTextBlock.Text = "From address:";
            toTextBlock.Text = "To address:";

            operationButton.IsEnabled = true;
            plateRecognitionButton.IsEnabled = true;
            securityRecordingButton.IsEnabled = true;
        }

        // Output the xml
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Create the path
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);


            // If operation is chosen
            if (!operationButton.IsEnabled)
            {
                // convert to long in case there is any zero padding in
                // the strings
                uint cfromIP = IPAddressToLong(fromTextBox.Text);
                uint ctoIP = IPAddressToLong(toTextBox.Text);
                uint dfromIP = IPAddressToLong(displayfromTextBox.Text);
                uint dtoIP = IPAddressToLong(displaytoTextBox.Text);

                if (cfromIP > ctoIP)
                {
                    MessageBox.Show("Controller From address should be less than To Address");
                    return;
                }
                if (dfromIP > dtoIP)
                {
                    MessageBox.Show("Display From address should be less than To Address");
                    return;
                }

                string filepath = path + "\\topology.xml";

                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" +
                                "<Topology xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\n" +
                                "  <Floors>\n");

                    // Print floors
                    for (int i = 1; i <= Int32.Parse(floorsTextBox.Text); i++)
                    {
                        sw.WriteLine("      <Floor Order=\"" + i + "\">\n" +
                                     "          <Name>Kat" + i + "</Name>\n" +
                                     "          <MapPath>C:\\Program Files\\Parkonom\\Shared\\Runtime\\Floor Maps\\Kat" + i + ".jpg</MapPath>\n" +
                                     "      </Floor>\n");
                    }

                    sw.WriteLine("  </Floors>\n" +
                                 "  <Groups>\n");

                    // Print groups
                    for (int i = 1; i <= Int32.Parse(groupsTextBox.Text); i++)
                    {
                        sw.WriteLine("      <Group Id=\"" + i + "\">\n" +
                                     "          <Name>G " + i + "</Name>\n" +
                                     "          <Type>" + (groupsTypeComboBox.SelectedIndex + 1) + "</Type>\n" +
                                     "      </Group>\n");
                    }

                    sw.WriteLine("  </Groups>\n" +
                                 "  <Dataservers>\n" +
                                 "      <Dataserver Id=\"1\">\n" +
                                 "        <p>127.0.0.1</Ip>\n"+
                                 "        <Name>D 1</Name>\n" +
                                 "      </Dataserver>\n" +
                                 "    </Dataservers>\n" +
                                 "  <Behaviours>\n");


                    // Calculating daily activity
                    double DailyActivity = 0;
                    if ((bool)behaviourDaysMoComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 0);
                    if ((bool)behaviourDaysTuComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 1);
                    if ((bool)behaviourDaysWeComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 2);
                    if ((bool)behaviourDaysThComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 3);
                    if ((bool)behaviourDaysFrComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 4);
                    if ((bool)behaviourDaysStComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 5);
                    if ((bool)behaviourDaysSuComboBox.IsChecked)
                        DailyActivity += Math.Pow(2, 6);

                    // This is declared so it is easier to write in below for loop
                    DateTime date = DateTime.Parse(behaviourEndDatePicker.Text);

                    // Print behaviours
                    // Check if every behaviour only has 1 timerow
                    for (int i = 1; i <= Int32.Parse(behavioursTextBox.Text); i++)
                    {
                        sw.WriteLine("      <Behaviour Id=\"" + i + "\">\n" +
                                     "          <Name>B " + i + "</Name>\n" +
                                     "          <Type>" + behavioursTypeComboBox.SelectedIndex + "</Type>\n" +
                                     "          <StartDate>" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "</StartDate>\n" +
                                     "          <EndDate>" + date.Year + "-" + date.Month + "-" + date.Day + "T00:00:00</EndDate>\n" +
                                     "          <DailyActivity>" + DailyActivity + "</DailyActivity>\n" + 
                                     "          <TimeRows>\n" +
                                     "              <TimeRow Order=\"1\">\n" +
                                     "                  <Time>" + behaviourTimeTextBox.Text + "</Time>\n" +
                                     "                  <Status>" + timeStatusComboBox.IsChecked + "</Status>\n" +
                                     "              </TimeRow>\n" +
                                     "          </TimeRows>\n" + 
                                     "      </Behaviour>\n");
                    }

                    sw.WriteLine("  </Behaviours>\n" +
                                 "  <Controllers>\n");

                    // Print controllers
                    // Check Axle
                    // cid is for controller id
                    int cid = 1;  
                    for (string ip = fromTextBox.Text; IPAddressToLong(ip) <= ctoIP; ip = incrementIP(ip), cid++ )
                    {
                        sw.WriteLine("      <Controller Id=\"" + cid + "\">\n" +
                                     "          <IP>" + ip + "</Ip>\n" +
                                     "          <Name>Kontrolör " + cid + "</Name>\n" +
                                     "          <DataserverId>1</DataserverId>\n" +
                                     "          <GroupId>1</GroupId>\n" +
                                     "          <FloorOrder>1</FloorOrder>\n"+
                                     "          <Cameras>\n");

                        for (int i = 1; i <= Int32.Parse(cameraTextBox.Text); i++)
                        {
                            sw.WriteLine("              <Camera Order=\"" + i + "\">\n" +
                                         "                  <Name>Kamera " + i + "</Name>\n" +
                                         "                  <Axle />\n" +
                                         "                  <Spaces>\n");

                            for (int j = 1; j <= Int32.Parse(spaceTextBox.Text); j++)
                            {
                                sw.WriteLine("                      <Space Order=\"" + j + "\">\n" +
                                             "                          <Name>Park Alanı " + j + "</Name>\n" +
                                             "                          <MapLocation>\n" +
                                             "                          <X>-1</X>\n" +
                                             "                          <Y>-1</Y>\n" +
                                             "                          <Angle>0</Angle>\n" +
                                             "                          <ZoomLevel>1</ZoomLevel>\n" +
                                             "                        </MapLocation>\n" +
                                             "                        <BehaviourId>1</BehaviourId>\n" +
                                             "                      </Space>\n");
                            }

                            sw.WriteLine("                  </Spaces>\n" + 
                                         "              </Camera>\n");
                        }

                        sw.WriteLine("          </Cameras>\n" +
                                     "      </Controller>\n");
                    }

                    sw.WriteLine("  </Controllers>\n" +
                                 "  <Displays>\n");

                    // Print for Displays
                    // did is for displayer id
                    int did = 1;
                    for (string ip = displayfromTextBox.Text; IPAddressToLong(ip) <= dtoIP; ip = incrementIP(ip), did++)
                    {
                        sw.WriteLine("      <Display Id=\"" + did + "\">\n" +
                                     "          <Ip>" + ip + "</Ip>\n" +
                                     "          <Name>Gösterme Ünitesi " + did + "</Name>\n" +
                                     "          <Type>" + (displayTypeComboBox.SelectedIndex + 1) + "</Type>\n" + 
                                     "          <TypeValue>0</TypeValue>\n" +
                                     "          <MapLocation>\n" +
                                     "              <X>-1</X>\n" +
                                     "              <Y>-1</Y>\n" +
                                     "              <Angle>0</Angle>\n" +
                                     "              <ZoomLevel>1</ZoomLevel>\n" +
                                     "          </MapLocation>\n" +
                                     "          <FloorOrder>1</FloorOrder>\n" +
                                     "          <GroupId>2</GroupId>\n" +
                                     "          <Zones>\n");

                        for (int i = 1; i <= Int32.Parse(zoneTextBox.Text); i++)
                        {
                            sw.WriteLine("              <Zones>\n" +
                                         "                  <Type>" + (zoneTypeComboBox.SelectedIndex + 1) + "</Type>\n" +
                                         "                  <ZoneMembers>\n");

                            for (int j = 1; j <= Int32.Parse(zoneMemberTextBox.Text); j++)
                            {
                                sw.WriteLine("                      <ZoneMember>\n" +
                                             "                          <ControllerId>1</ControllerId>\n" +
                                             "                      </ZoneMember>\n");
                            }

                            sw.WriteLine("                  </ZoneMembers>\n" +
                                         "              </Zones>\n");
                        }

                        sw.WriteLine("      </Display>\n");
                    }

                    
                    using (SHA256 sha256Hash = SHA256.Create())
                    {
                        string tobehashed = shaTextBox.Text + floorsTextBox.Text + groupsTextBox.Text + (groupsTypeComboBox.SelectedIndex + 1) +
                                            behavioursTextBox.Text + behavioursTypeComboBox.SelectedIndex + behaviourEndDatePicker.Text +
                                            cameraTextBox.Text + spaceTextBox.Text;

                        // ComputeHash - returns byte array  
                        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(tobehashed.ToCharArray()));

                        // Convert byte array to a string   
                        string str = string.Empty;
                        for (int i = 0; i < bytes.Length - 1; i++)
                        {
                            str += bytes[i].ToString() + "-";
                        }
                        str += bytes[bytes.Length - 1];

                        sw.WriteLine("  </Displays>\n" +
                                     "  <FileInfo>\n" +
                                     "      <Hash>" + str + "</Hash>\n" +
                                     "      <ModifyTime>" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "T" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "</ModifyTime>\n" +
                                     "  </FileInfo>\n +" +
                                     "<Topology>");

                    }

                }

            }
            // if plate recognition is chosen
            else if (!plateRecognitionButton.IsEnabled)
            {
                if (fromTextBox.Text.Equals(string.Empty) || toTextBox.Text.Equals(string.Empty) || dPathTextBox.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Fill all the text boxes");
                    return;
                }

                // convert to long in case there is any zero padding in
                // the strings
                uint fromIP = IPAddressToLong(fromTextBox.Text);
                uint toIP = IPAddressToLong(toTextBox.Text);

                if (fromIP > toIP)
                {
                    MessageBox.Show("From address should be less than To Address");
                    return;
                }

                string filepath = path + "\\config.xml";

                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" +
                                "<Config>\n" +
                                "   <ControllerList>\n");

                    for (string i = fromTextBox.Text; IPAddressToLong(i) <= toIP; i = incrementIP(i))
                    {
                        sw.WriteLine("      <Controller>\n" +
                                     "          <IP>" + i + "</IP>\n" +
                                     "          <DestinationPath>" + dPathTextBox.Text + (dPathTextBox.Text[dPathTextBox.Text.Length-1] == '\\' ? "" : "\\") + i + "</DestinationPath>\n" +
                                     "      </Controller>\n");
                                                                                          // If \ is given in the destination path, don't write another \
                    }

                    sw.WriteLine("  </ControllerList>\n" +
                                 "</Config>");
                }
                
            }
            // if security Recording is chosen
            else if (!securityRecordingButton.IsEnabled)
            {
                if (fromTextBox.Text.Equals(string.Empty) || toTextBox.Text.Equals(string.Empty) || dPathTextBox.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Fill all the text boxes");
                    return;
                }

                // convert to long in case there is any zero padding in
                // the strings
                uint fromIP = IPAddressToLong(fromTextBox.Text);
                uint toIP = IPAddressToLong(toTextBox.Text);

                if (fromIP > toIP)
                {
                    MessageBox.Show("From address should be less than To Address");
                    return;
                }

                string filepath = path + "\\config.xml";

                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" +
                                "<Config>\n" +
                                "   <ControllerList>\n");

                    for (string i = fromTextBox.Text; IPAddressToLong(i) <= toIP; i = incrementIP(i))
                    {
                        sw.WriteLine("      <Controller>\n" +
                                     "          <SourcePath>\\\\" + i + "\\ram\\pmc\\finished</SourcePath>\n" +
                                     "          <DestinationPath>" + dPathTextBox.Text + (dPathTextBox.Text[dPathTextBox.Text.Length-1] == '\\' ? "" : "\\") + i + "</DestinationPath>\n" +
                                     "      </Controller>\n");
                                                                                          // If \ is given in the destination path, don't write another \
                    }

                    sw.WriteLine("  </ControllerList>\n" +
                                 "</Config>");
                }
            }

        }

        // Used for comparing ip addresses
        private uint IPAddressToLong(string addr)
        {
            IPAddress oIP = IPAddress.Parse(addr);
            byte[] byteIP = oIP.GetAddressBytes();


            uint ip = (uint)byteIP[0] << 24;
            ip += (uint)byteIP[1] << 16;
            ip += (uint)byteIP[2] << 8;
            ip += (uint)byteIP[3];

            return ip;
        }

        private string incrementIP(string addr)
        {
            byte[] addressBytes = IPAddress.Parse(addr).GetAddressBytes().Reverse().ToArray();
            uint ipAsUint = BitConverter.ToUInt32(addressBytes, 0);
            var nextAddress = BitConverter.GetBytes(ipAsUint + 1);

            return String.Join(".", nextAddress.Reverse());
        }

    }
}
