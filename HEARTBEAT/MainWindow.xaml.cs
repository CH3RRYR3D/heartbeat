
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;

namespace HEARTBEAT
{




  




    public partial class MainWindow : Window
    {
       


        FileSystemWatcher watcher = new FileSystemWatcher();


        public MainWindow()
        {



            // Loaded 
            this.Loaded += delegate (object s, RoutedEventArgs e)
            {
                // Start Up
                RefreshBox();
                UpdateSyntax();
               

                
               

                // Update detector
               

               





            };


            // Refresh Box Trigger
          

            

        }


        // Minimize
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        
        // Inject
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
        }

       

        // Syntax
        private void UpdateSyntax()
        {
           

           
        }


        // Drag
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove(); 
        }

        // Close
        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1200);
            Environment.Exit(0);
        }

        // Open Discord
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        // Clear Texteditor
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textEditor.Clear();
        }

        // Execute
        private void executie_Copy_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // Upload file
        private void uploadfil_Copy_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == true)
            {
                var s = dialog.OpenFile();
                using (StreamReader sr = new StreamReader(s))
                {
                    textEditor.Text = sr.ReadToEnd();
                }
            }
        }

        // save file
        private void save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, textEditor.Text);
            }
        }

        // Add selction to texteditor
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (liss.SelectedIndex != -1)
            {
                textEditor.Text = File.ReadAllText("scripts\\" + liss.SelectedItem.ToString());
            }
        }

        // Refresh Script Box
        private void RefreshBox()
        {
            this.Dispatcher.Invoke(() =>
            {
                liss.Items.Clear();
                DirectoryInfo dinfo = new DirectoryInfo("./Scripts");
                FileInfo[] Files = dinfo.GetFiles("*.txt");
                FileInfo[] Files2 = dinfo.GetFiles("*.lua");
                foreach (FileInfo file in Files)
                {
                    liss.Items.Add(file.Name);
                }
                foreach (FileInfo file in Files2)
                {
                    liss.Items.Add(file.Name);
                }
            });
        }

        // Load Ace
        private void loadaceeditor()
        {



        }

      
      

        private void executie_Copy_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }
    }

}


