using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenamePictures
{
    public partial class uxMainForm : Form
    {
        public uxMainForm()
        {
            InitializeComponent();
        }

        private void uxSelectSource_Click(object sender, EventArgs e)
        {

            if(uxSourceFolderDialog.ShowDialog() == DialogResult.OK)
            {
                uxSource.Text = uxSourceFolderDialog.SelectedPath;

            }
            
        }

        private void uxSelectDestination_Click(object sender, EventArgs e)
        {
            if (uxDestinationFolderDialog.ShowDialog() == DialogResult.OK)
            {
                uxDestination.Text = uxDestinationFolderDialog.SelectedPath;

            }
            
        }

        private void uxStart_Click(object sender, EventArgs e)
        {
            //check if directories exist
                //if destination has files in it pop up message box in error then stop everything
                //else create directories (Name from user, and Action Required)
                    //read file in current directory
                    //if picture has a date taken
                        //get date picture was taken and concatenate it to front as in: TakenMMDDYYYY<Original Name Here>
                        //copy picture to new folder with new name
                    //else copy picture w/o date taken to folder in destination labled: Action Required
                    //when done pop up message box saying: Done!

        }
    }
}
