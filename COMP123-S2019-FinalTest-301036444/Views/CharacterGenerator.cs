using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * Student Name: Mohamed A. Ali 
 * Student ID: 301036444
 * Description: this is the character generator form for the main form 
 * 
 */


namespace COMP123_S2019_FinalTest_301036444.Views
{
    public partial class CharacterGenerator : MasterForm
    {
        public CharacterGenerator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler for back button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
             }
        }

        /// <summary>
        /// this is the event handler for next button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex < MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        private void CharacterGenerator_Load(object sender, EventArgs e)
        {


           











//            // A array of authors  
//            string[] FirstName = { "Mahesh Chand", "Jeff Prosise", "Dave McCarter", "Allen O'neill",
//"Monica Rathbun", "Henry He", "Raj Kumar", "Mark Prime",
//"Rose Tracey", "Mike Crown" };

           
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
           // GeneratingTheFirstName();
            GeneratingTheLastName();

        }

        private void GeneratingTheLastName()
        {
            try
            {

                // Default folder  

                //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
                string textFile1 = @"..\..\Data\lastNames.txt";


                if (File.Exists(textFile1))
                {
                    // Read entire text file content in one string  
                    string text1 = File.ReadAllText(textFile1);

                }

                if (File.Exists(textFile1))
                {
                    // Read a text file line by line.
                    string[] lines1 = File.ReadAllLines(textFile1);
                    foreach (string line1 in lines1)
                        Console.WriteLine(line1);

                    // Create a Random object  
                    Random rand1 = new Random();
                    // Generate a random index less than the size of the array.  
                    int index1 = rand1.Next(lines1.Length);

                    // Display the result of the firstName.  
                    LastNameDataLabel.Text = lines1[index1];
                }


            }

            catch (IOException exception)
            {
                // Message box showing the error if the previouse code failed to retrieve the file
                MessageBox.Show("Error:" + exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeneratingTheFirstName()
        {
            try
            {

                // Default folder  

                //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
                string textFile = @"..\..\Data\firstNames.txt";


                if (File.Exists(textFile))
                {
                    // Read entire text file content in one string  
                    string text = File.ReadAllText(textFile);

                }

                if (File.Exists(textFile))
                {
                    // Read a text file line by line.
                    string[] lines = File.ReadAllLines(textFile);
                    //foreach (string line in lines)
                    //    Console.WriteLine(line);

                    // Create a Random object  
                    Random rand = new Random();
                    // Generate a random index less than the size of the array.  
                    int index = rand.Next(lines.Length);

                    // Display the result of the firstName.  
                    FirstNameDataLabel.Text = lines[index];
                }


            }

            catch (IOException exception)
            {
                // Message box showing the error if the previouse code failed to retrieve the file
                MessageBox.Show("Error:" + exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {

            // Creating random numbers for abilities from 3-18

            Random rnd = new Random();
            int Strength = rnd.Next(3, 18);  
            int Dexterity = rnd.Next(3, 18);   
            int Constitution = rnd.Next(3, 18);     
            int Intelligence = rnd.Next(3, 18);  
            int Wisdom = rnd.Next(3, 18);   
            int Charisma = rnd.Next(3, 18);

            StrengthDataLabel.Text = Strength.ToString();
            DexterityDataLabel.Text = Dexterity.ToString();
            ConstitutionDataLabel.Text = Constitution.ToString();
            IntelligenceDataLabel.Text = Intelligence.ToString();
            WisdomDataLabel.Text = Wisdom.ToString();
            CharismaDataLabel.Text = Charisma.ToString();

            Program.character.Strength = StrengthDataLabel.Text;
            Program.character.Desxterity = DexterityDataLabel.Text;
            Program.character.Constitution = ConstitutionDataLabel.Text;
            Program.character.Intelligence=IntelligenceDataLabel.Text;
            Program.character.Wisdom=WisdomDataLabel.Text;
            Program.character.Charisma = CharismaDataLabel.Text;


        }

        private void InventoryPage_Click(object sender, EventArgs e)
        {
            try
            {

                // Default folder  

                //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE 
                string textFile = @"..\..\Data\inventory.txt";
                if (File.Exists(textFile))
                {
                    // Read a text file line by line.
                    List <string> inventory = new List<string>();

                    inventory.Add() = File.ReadAllLines(textFile);
                    //foreach (string line in lines)
                    //    Console.WriteLine(line);

                    // Create a Random object  
                    Random rand = new Random();
                    // Generate a random index less than the size of the array.  
                    int index = rand.Next(lines.Length);

                    // Display the result of the firstName.  
                    FirstNameDataLabel.Text = lines[index];
                }


            }

            catch (IOException exception)
            {
                // Message box showing the error if the previouse code failed to retrieve the file
                MessageBox.Show("Error:" + exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // configure the ProductSaveFile Dialogue
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            // Open the file Dialogue
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open the stream for writing 
                using (StreamWriter outputStream = new StreamWriter(File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write content - string type - to the file 
                    outputStream.WriteLine(Program.product.productID.ToString());
                    outputStream.WriteLine(Program.product.cost.ToString());
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_type);
                    outputStream.WriteLine(Program.product.RAM_size);

                    outputStream.WriteLine(Program.product.displaytype);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.resolution);
                    outputStream.WriteLine(Program.product.CPU_Class);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_type);

                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.HDD_size);

                    outputStream.WriteLine(Program.product.HDD_speed);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.optical_drive);
                    outputStream.WriteLine(Program.product.Audio_type);
                    outputStream.WriteLine(Program.product.LAN);
                    outputStream.WriteLine(Program.product.WIFI);

                    outputStream.WriteLine(Program.product.width);
                    outputStream.WriteLine(Program.product.height);
                    outputStream.WriteLine(Program.product.depth);
                    outputStream.WriteLine(Program.product.weight);
                    outputStream.WriteLine(Program.product.moust_type);
                    outputStream.WriteLine(Program.product.power);

                    outputStream.WriteLine(Program.product.webcam);

                    // Message to inform user saves successfully 
                    MessageBox.Show("Saved Completed Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // clean up 
                    outputStream.Close();
                    outputStream.Dispose();
                }
    }
}

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.aboutBox.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }