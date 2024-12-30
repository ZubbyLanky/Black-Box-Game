using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nzube_Nworah_Ass_2
{
    public partial class DesignForm : Form
    {
        private List<List<PictureBox>> pictureBoxGrid; //this is the list where all the pictures goes to.
        private Image selectedToolImage; //this is used to store seletced images, as it an image data type
        private int selectedToolId; //each image seleted has an ID making it unquie and the system know which image was selected
        public DesignForm() //this is also a constructor
        {
            InitializeComponent();

            pbNone.Tag = 1; // None
            pbWall.Tag = 2; // Wall
            pbRedDoor.Tag = 3; // Red Box
            pbGreenDoor.Tag = 4; // Green Box
            pbRedBox.Tag = 5; // Red Door
            pbGreenBox.Tag = 6; // Green Box


            pbNone.Click += new EventHandler(pbTool_Click);
            pbWall.Click += new EventHandler(pbTool_Click);
            pbRedDoor.Click += new EventHandler(pbTool_Click);
            pbGreenDoor.Click += new EventHandler(pbTool_Click);
            pbRedBox.Click += new EventHandler(pbTool_Click);
            pbGreenBox.Click += new EventHandler(pbTool_Click);
        }

             

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            bool hasImages = pictureBoxGrid != null && pictureBoxGrid.Any(row => row.Any(pb => pb.Image != null));

            // If there are images, show a confirmation dialog
            if (hasImages)
            {
                var result = MessageBox.Show("Changing the grid size will discard any unsaved data. Do you want to continue?",
                                               "Confirm Grid Size Change",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Warning);

                // If the user chooses 'No', exit the method
                if (result == DialogResult.No)
                {
                    return;
                }
            }

            int rows, cols;

            if (!int.TryParse(tbRow.Text, out rows) || !int.TryParse(tbColumn.Text, out cols))
            {
                MessageBox.Show("Please enter valid integers for rows and columns.");
                return;
            }
            if (rows <= 0 || cols <= 0)
            {
                MessageBox.Show("Rows and columns must be greater than zero.");
                return;
            }


            displayPanel.Controls.Clear();
            displayPanel.AutoScroll = true;


            displayPanel.Width = Math.Min(cols * 600, displayPanel.Parent.Width);
            displayPanel.Height = Math.Min(rows * 600, displayPanel.Parent.Height);

            pictureBoxGrid = new List<List<PictureBox>>();

            int pictureBoxSize = 100;
            int spacing = 4;


            for (int row = 0; row < rows; row++)
            {
                var pictureBoxRow = new List<PictureBox>();
                for (int col = 0; col < cols; col++)
                {
                    PictureBox pb = new PictureBox
                    {
                        Width = pictureBoxSize,
                        Height = pictureBoxSize,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(col * (pictureBoxSize + spacing), row * (pictureBoxSize + spacing)),
                        Tag = null,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    pb.Click += new EventHandler(PictureBox_Click); //this line of code is used to add an event dynamiclly to each of the picture box created when the user types inn the number or row and column they want to be created 
                    pictureBoxRow.Add(pb);
                    displayPanel.Controls.Add(pb);

                }
                pictureBoxGrid.Add(pictureBoxRow);
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (selectedToolId == 1) // If 'None' is selected
            {
                pb.Image = null; // Clear the image
                pb.Tag = null;   // Reset the tag to null as there's no tool
            }
            else if (selectedToolImage != null)
            {
                pb.Image = selectedToolImage;
                pb.Tag = selectedToolId;
            }
            else
            {
                MessageBox.Show("Please select a tool first.");
            }
        }


        private void pbTool_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            selectedToolImage = pb.Image; //Set the selcted images
            selectedToolId = (int)pb.Tag;
            //if pbTool None is seleted then, the picture box should be null
            if (selectedToolId == 1)
            {
                selectedToolImage = null; // No image to select
            }
        }


        private void tsSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.Title = "Save the level";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    int rows = pictureBoxGrid.Count;
                    int cols = pictureBoxGrid[0].Count;

                    sw.WriteLine(rows);
                    sw.WriteLine(cols);

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            PictureBox pb = pictureBoxGrid[row][col];
                            int content = (pb.Tag != null) ? (int)pb.Tag : 0;
                            sw.WriteLine($"{row},{col},{content}");
                        }
                    }
                }

                //Count the number of tools placed on the grid
                int wallCount = CountTool(2);
                int redBoxCount = CountTool(3);
                int greenBoxCount = CountTool(4);
                int redDoorCount = CountTool(5);
                int greenDoorCount = CountTool(6);


                StringBuilder message = new StringBuilder("The following items were saved:\n");
                if (wallCount > 0) message.AppendLine($"Walls: {wallCount}");
                if (redBoxCount > 0) message.AppendLine($"Total Red Boxes: {redBoxCount}");
                if (greenBoxCount > 0) message.AppendLine($"Total Green Boxes: {greenBoxCount}");
                if (redDoorCount > 0) message.AppendLine($"Total Red Doors: {redDoorCount}");
                if (greenDoorCount > 0) message.AppendLine($"Total Green Doors: {greenDoorCount}");

                // Show message only if any tools were placed, otherwise state nothing was selected
                if (message.ToString().Trim().Length > 0)
                {
                    MessageBox.Show(message.ToString(), "Save Successful");
                }
                else
                {
                    MessageBox.Show("No tools were selected or placed on the grid.", "Save Information");
                }

            }
        }

        private int CountTool(int toolId)
        {
            int count = 0;
            foreach (var row in pictureBoxGrid)
            {
                foreach (var pb in row)
                {
                    if (pb.Tag != null && (int)pb.Tag == toolId)
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        private void tsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
