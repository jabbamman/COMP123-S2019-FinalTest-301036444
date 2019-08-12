using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
