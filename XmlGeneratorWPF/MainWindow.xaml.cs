﻿using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
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

            xmlButton.Visibility = Visibility.Visible;
            sqlButton.Visibility = Visibility.Visible;

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

            xmlButton.Visibility = Visibility.Visible;
            sqlButton.Visibility = Visibility.Visible;

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

            xmlButton.Visibility = Visibility.Visible;
            sqlButton.Visibility = Visibility.Visible;

            securityRecordingButton.IsEnabled = false;

            fromTextBox.Focus();
        }

        private void AddressGeneratorButton_Click(object sender, RoutedEventArgs e)
        {
            turnAllInvisible();

            fromTextBox.Visibility = Visibility.Visible;
            fromTextBlock.Visibility = Visibility.Visible;
            toTextBox.Visibility = Visibility.Visible;
            toTextBlock.Visibility = Visibility.Visible;

            xmlButton.Visibility = Visibility.Visible;
            sqlButton.Visibility = Visibility.Collapsed;

            addressGeneratorButton.IsEnabled = false;
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
            addressGeneratorButton.IsEnabled = true;
        }

        // Output the xml
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // If operation is chosen
            if (!operationButton.IsEnabled)
            {
                // Check if all boxes are filled
                if (floorsTextBox.Text.Equals(string.Empty) || groupsTextBox.Text.Equals(string.Empty) || groupsTypeComboBox.SelectedIndex == -1 ||
                    behavioursTextBox.Text.Equals(string.Empty) || behavioursTypeComboBox.SelectedIndex == -1 || behaviourEndDatePicker.Text.Equals(string.Empty) ||
                    behaviourTimeTextBox.Text.Equals(string.Empty) || fromTextBox.Text.Equals(string.Empty) || toTextBox.Text.Equals(string.Empty) ||
                    cameraTextBox.Text.Equals(string.Empty) || spaceTextBox.Text.Equals(string.Empty) || displayfromTextBox.Text.Equals(string.Empty) ||
                    displaytoTextBox.Text.Equals(string.Empty) || displayTypeComboBox.SelectedIndex == -1 || zoneTextBox.Text.Equals(string.Empty) ||
                    zoneTypeComboBox.SelectedIndex == -1 || zoneMemberTextBox.Text.Equals(string.Empty) || shaTextBox.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Please fill all the boxes");
                    return;
                }

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

                string tobehashed = string.Empty;
                Topology tpl = new Topology();

                // Create Floors
                int numOfFloors = Int32.Parse(floorsTextBox.Text);
                tpl.Floors = new List<TopologyFloor>();

                for (int i = 1; i <= numOfFloors; i++)
                {
                    tpl.Floors.Add(new TopologyFloor
                    {
                        Order = (byte)i,
                        Name = "Kat" + i,
                        MapPath = "C:\\Program Files\\Parkonom\\Shared\\Runtime\\Floor Maps\\Kat" + i + ".jpg"
                    });

                    tobehashed += i + i + "C:\\Program Files\\Parkonom\\Shared\\Runtime\\Floor Maps\\Kat" + i + ".jpg";
                }

                // Create Groups
                int numOfGroups = Int32.Parse(groupsTextBox.Text);
                tpl.Groups = new List<TopologyGroup>();
                    
                for (int i = 1; i <= numOfGroups; i++)
                {
                    tpl.Groups.Add(new TopologyGroup
                    {
                        Id = (byte)i,
                        Name = "G " + i,
                        Type = (byte)(groupsTypeComboBox.SelectedIndex + 1)
                    });

                    tobehashed += i + "G " + i + (groupsTypeComboBox.SelectedIndex + 1);
                }

                // Create Dataserver
                // This is always fixed
                tpl.Dataservers = new TopologyDataservers
                {
                    Dataserver = new TopologyDataserversDataserver
                    {
                        Id = (byte)1,
                        Ip = "127.0.0.1",
                        Name = "D 1"
                    }
                };

                tobehashed += "1" + "127.0.0.1" + "D 1";

                // Create Behaviours
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

                int numOfBehaviours = Int32.Parse(behavioursTextBox.Text);
                tpl.Behaviours = new List<TopologyBehaviour>();

                for (int i = 1; i <= numOfBehaviours; i++)
                {
                    tpl.Behaviours.Add(new TopologyBehaviour
                    {
                        Id = (byte)i,
                        Name = "B " + i,
                        Type = (byte)behavioursTypeComboBox.SelectedIndex,
                        StartDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"),
                        EndDate = DateTime.Parse(behaviourEndDatePicker.Text),
                        DailyActivity = (byte)DailyActivity,
                        TimeRows = new TopologyBehaviourTimeRows
                        {
                            TimeRow = new TopologyBehaviourTimeRowsTimeRow
                            {
                                Order = 1,
                                Time = DateTime.Parse(behaviourTimeTextBox.Text),
                                Status = (timeStatusComboBox.IsChecked == true ? true : false)
                            }
                        }
                    });

                    tobehashed += i + "B " + i + behavioursTypeComboBox.SelectedIndex + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") +
                        DateTime.Parse(behaviourEndDatePicker.Text).ToString("yyyy-MM-ddTHH:mm:ss") + DailyActivity + "1" +
                        DateTime.Parse(behaviourTimeTextBox.Text).ToString("yyyy-MM-ddTHH:mm:ss") + (timeStatusComboBox.IsChecked == true ? "true" : "false");
                }

                // Create Controllers
                // TODO: Too lazy to calculate ctoIP - cfromIP
                // will just create a list and turn it into array later
                List<TopologyController> tplcont = new List<TopologyController>();

                int numOfCameras = Int32.Parse(cameraTextBox.Text);
                int numOfSpaces = Int32.Parse(spaceTextBox.Text);

                // For tracking controller id
                int cid = 1;
                for (string ip = fromTextBox.Text; IPAddressToLong(ip) <= ctoIP; ip = incrementIP(ip), cid++)
                {
                    tplcont.Add(new TopologyController
                    {
                        Id = (byte)cid,
                        Ip = ip,
                        Name = "Kontrolör " + cid,
                        DataserverId = 1,
                        GroupId = 1,
                        FloorOrder = 1,
                        Cameras = new List<TopologyControllerCamera>(),
                    }
                    );

                    tobehashed += cid + ip + "Kontrolör " + cid + "111";

                    for (int i = 1; i <= numOfCameras; i++)
                    {
                        tplcont.ElementAt(cid - 1).Cameras.Add(new TopologyControllerCamera
                        {
                            Order = (byte)i,
                            Name = "Kamera " + i,
                            Axle = "",
                            Spaces = new List<TopologyControllerCameraSpace>()
                        });

                        tobehashed += i + "Kamera " + i;

                        for (int j = 1; j <= numOfSpaces; j++)
                        {
                            tplcont.ElementAt(cid - 1).Cameras.ElementAt(i - 1).Spaces.Add(new TopologyControllerCameraSpace
                            {
                                Order = (byte)j,
                                Name = "Park Alanı " + j,
                                MapLocation = new TopologyControllerCameraSpaceMapLocation
                                {
                                    X = 1,
                                    Y = 1,
                                    Angle = 0,
                                    ZoomLevel = 1
                                },
                                BehaviourId = 1
                            });

                            tobehashed += j + "Park Alanı " + j + "11011";
                        }
                    }
                }

                tpl.Controllers = tplcont;

                // Creating Displays
                // TODO: Too lazy to calculate ctoIP - cfromIP
                // will just create a list and turn it into array later
                List<TopologyDisplay> tpldisp = new List<TopologyDisplay>();

                int numOfZones = Int32.Parse(zoneTextBox.Text);
                int numOfZoneMembers = Int32.Parse(zoneMemberTextBox.Text);
                // Check typevalue

                int did = 1;
                for (string ip = displayfromTextBox.Text; IPAddressToLong(ip) <= dtoIP; ip = incrementIP(ip), did++)
                {
                    tpldisp.Add(new TopologyDisplay
                    {
                        Id = (byte)did,
                        Ip = ip,
                        Name = "Gösterme Ünitesi " + did,
                        Type = (byte)(displayTypeComboBox.SelectedIndex + 1),
                        TypeValue = 0,
                        MapLocation = new TopologyDisplayMapLocation
                        {
                            X = 1,
                            Y = 1,
                            Angle = 0,
                            ZoomLevel = 1
                        },
                        FloorOrder = 1,
                        GroupId = 1,
                        Zones = new List<TopologyDisplayZone>()
                    }
                    );

                    tobehashed += did + ip + "Gösterme Ünitesi " + did + (displayTypeComboBox.SelectedIndex + 1) + "0110111";

                    for (int i = 1; i <= numOfZones; i++)
                    {
                        tpldisp.ElementAt(did - 1).Zones.Add(new TopologyDisplayZone
                        {
                                Type = (byte)i,
                                ZoneMembers = new List<TopologyDisplayZoneZoneMember>()
                        });

                        tobehashed += i;

                        for (int j = 1; j <= numOfZoneMembers; j++)
                        {
                            tpldisp.ElementAt(did - 1).Zones.ElementAt(i - 1).ZoneMembers.Add(new TopologyDisplayZoneZoneMember
                            {
                                ControllerId = 1
                            });

                            tobehashed += "1";
                        }
                    }
                }

                tpl.Displays = tpldisp;

                tobehashed += shaTextBox.Text;

                using (SHA256 sha256Hash = SHA256.Create())
                {
                    // ComputeHash - returns byte array  
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(tobehashed.ToCharArray()));

                    // Convert byte array to a string   
                    string str = string.Empty;
                    for (int i = 0; i < bytes.Length - 1; i++)
                    {
                        str += bytes[i].ToString() + "-";
                    }
                    str += bytes[bytes.Length - 1];

                    tpl.FileInfo = new TopologyFileInfo
                    {
                        Hash = str,
                        ModifyTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss")
                    };

                    if (xmlButton.IsFocused)
                    {
                        writeInterface.writeXml wrt = new writeInterface.writeXml();
                        wrt.Write(tpl);
                    }
                    else if (sqlButton.IsFocused)
                    {
                        writeInterface.writeSql wrt = new writeInterface.writeSql();
                        wrt.Write(tpl);
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

                // Create a file to write to.   

                plate.ConfigP plt = new plate.ConfigP();

                // TODO: too lazy to figure out number of onjects inside at this point
                List<plate.ConfigControllerP> pltcont = new List<plate.ConfigControllerP>();

                for (string i = fromTextBox.Text; IPAddressToLong(i) <= toIP; i = incrementIP(i)) {

                    pltcont.Add(new plate.ConfigControllerP
                    {
                        IP = i,
                        DestinationPath = dPathTextBox.Text + (dPathTextBox.Text[dPathTextBox.Text.Length - 1] == '\\' ? "" : "\\") + i
                    }
                    );
                }

                plt.ControllerList = pltcont;

                if (xmlButton.IsFocused)
                {
                    writeInterface.writeXml wrt = new writeInterface.writeXml();
                    wrt.Write(plt);
                }
                else if (sqlButton.IsFocused)
                {
                    writeInterface.writeSql wrt = new writeInterface.writeSql();
                    wrt.Write(plt);
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
                
                security.Config sec = new security.Config();

                List<security.ConfigController> li = new List<security.ConfigController>();

                for (string i = fromTextBox.Text; IPAddressToLong(i) <= toIP; i = incrementIP(i))
                {
                    li.Add(new security.ConfigController
                    {
                        SourcePath = "\\\\" + i + "\\ram\\pmc\\finished",
                        DestinationPath = dPathTextBox.Text + (dPathTextBox.Text[dPathTextBox.Text.Length - 1] == '\\' ? "" : "\\") + i
                    }
                    );
                }

                sec.ControllerList = li;

                if (xmlButton.IsFocused)
                {
                    writeInterface.writeXml wrt = new writeInterface.writeXml();
                    wrt.Write(sec);
                }
                else if (sqlButton.IsFocused)
                {
                    writeInterface.writeSql wrt = new writeInterface.writeSql();
                    wrt.Write(sec);
                }

            }
            // If genereate addresses is chosen
            else if (!addressGeneratorButton.IsEnabled)
            {
                if (fromTextBox.Text.Equals(string.Empty) || toTextBox.Text.Equals(string.Empty))
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

                Addresses adr = new Addresses();

                for (string i = fromTextBox.Text; IPAddressToLong(i) <= toIP; i = incrementIP(i))
                {
                    adr.AddressList.Add(new AddressesAddress
                    {
                        Name = i,
                        IP = i
                    }
                    );
                }

                if (xmlButton.IsFocused)
                {
                    writeInterface.writeXml wrt = new writeInterface.writeXml();
                    wrt.Write(adr);
                }

            }

            if (xmlButton.IsFocused)
                MessageBox.Show("XML is generated");
            if (sqlButton.IsFocused)
                MessageBox.Show("Data has been created");
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
