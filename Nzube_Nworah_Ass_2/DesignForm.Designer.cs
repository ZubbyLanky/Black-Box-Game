namespace Nzube_Nworah_Ass_2
{
    partial class DesignForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignForm));
            toolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            tsSave = new ToolStripMenuItem();
            tsClose = new ToolStripMenuItem();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tbColumn = new TextBox();
            tbRow = new TextBox();
            btnGenerate = new Button();
            displayPanel = new Panel();
            label3 = new Label();
            pbNone = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            pbWall = new PictureBox();
            panel6 = new Panel();
            label7 = new Label();
            pbRedDoor = new PictureBox();
            panel7 = new Panel();
            label8 = new Label();
            pbGreenDoor = new PictureBox();
            panel8 = new Panel();
            label9 = new Label();
            pbRedBox = new PictureBox();
            panel9 = new Panel();
            label10 = new Label();
            pbGreenBox = new PictureBox();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbNone).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWall).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedDoor).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGreenDoor).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedBox).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGreenBox).BeginInit();
            SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.CanOverflow = false;
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1317, 34);
            toolStrip.TabIndex = 0;
            toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { tsSave, tsClose });
            toolStripDropDownButton1.Image = Properties.Resources._7324086_ui_interface_save_bookmark_favorite_icon;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(80, 29);
            toolStripDropDownButton1.Text = "File";
            // 
            // tsSave
            // 
            tsSave.Image = Properties.Resources._8666542_save_icon;
            tsSave.Name = "tsSave";
            tsSave.Size = new Size(157, 34);
            tsSave.Text = "Save";
            tsSave.Click += tsSave_Click;
            // 
            // tsClose
            // 
            tsClose.Image = Properties.Resources._211651_close_round_icon;
            tsClose.Name = "tsClose";
            tsClose.Size = new Size(157, 34);
            tsClose.Text = "Close";
            tsClose.Click += tsClose_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbColumn);
            panel1.Controls.Add(tbRow);
            panel1.Controls.Add(btnGenerate);
            panel1.Location = new Point(0, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(1317, 58);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 4;
            label2.Text = "COLUMN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 3;
            label1.Text = "ROW";
            // 
            // tbColumn
            // 
            tbColumn.Location = new Point(615, 10);
            tbColumn.Name = "tbColumn";
            tbColumn.Size = new Size(150, 31);
            tbColumn.TabIndex = 2;
            // 
            // tbRow
            // 
            tbRow.Location = new Point(175, 12);
            tbRow.Name = "tbRow";
            tbRow.Size = new Size(150, 31);
            tbRow.TabIndex = 1;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(1092, 16);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(112, 34);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // displayPanel
            // 
            displayPanel.Location = new Point(376, 197);
            displayPanel.Name = "displayPanel";
            displayPanel.Size = new Size(830, 516);
            displayPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 130);
            label3.Name = "label3";
            label3.Size = new Size(121, 38);
            label3.TabIndex = 4;
            label3.Text = "ToolBox";
            // 
            // pbNone
            // 
            pbNone.Image = Properties.Resources.square_24;
            pbNone.Location = new Point(-1, -1);
            pbNone.Name = "pbNone";
            pbNone.Size = new Size(75, 55);
            pbNone.SizeMode = PictureBoxSizeMode.StretchImage;
            pbNone.TabIndex = 5;
            pbNone.TabStop = false;
            pbNone.Click += pbTool_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pbNone);
            panel3.Location = new Point(54, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 55);
            panel3.TabIndex = 6;
            panel3.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 16);
            label4.Name = "label4";
            label4.Size = new Size(55, 25);
            label4.TabIndex = 7;
            label4.Text = "None";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pbWall);
            panel5.Location = new Point(54, 291);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 55);
            panel5.TabIndex = 9;
            panel5.Tag = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 16);
            label6.Name = "label6";
            label6.Size = new Size(45, 25);
            label6.TabIndex = 7;
            label6.Text = "Wall";
            // 
            // pbWall
            // 
            pbWall.Image = Properties.Resources.wall_1024;
            pbWall.Location = new Point(-1, -1);
            pbWall.Name = "pbWall";
            pbWall.Size = new Size(75, 55);
            pbWall.SizeMode = PictureBoxSizeMode.StretchImage;
            pbWall.TabIndex = 5;
            pbWall.TabStop = false;
            pbWall.Click += pbTool_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(pbRedDoor);
            panel6.Location = new Point(54, 388);
            panel6.Name = "panel6";
            panel6.Size = new Size(160, 55);
            panel6.TabIndex = 10;
            panel6.Tag = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(83, 20);
            label7.Name = "label7";
            label7.Size = new Size(76, 21);
            label7.TabIndex = 7;
            label7.Text = "Red Door";
            // 
            // pbRedDoor
            // 
            pbRedDoor.Image = Properties.Resources.red_door_24;
            pbRedDoor.Location = new Point(-1, -1);
            pbRedDoor.Name = "pbRedDoor";
            pbRedDoor.Size = new Size(75, 55);
            pbRedDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedDoor.TabIndex = 5;
            pbRedDoor.TabStop = false;
            pbRedDoor.Click += pbTool_Click;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(pbGreenDoor);
            panel7.Location = new Point(54, 481);
            panel7.Name = "panel7";
            panel7.Size = new Size(160, 55);
            panel7.TabIndex = 9;
            panel7.Tag = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(73, 17);
            label8.Name = "label8";
            label8.Size = new Size(91, 21);
            label8.TabIndex = 7;
            label8.Text = "Green Door";
            // 
            // pbGreenDoor
            // 
            pbGreenDoor.Image = Properties.Resources.green_door_24;
            pbGreenDoor.Location = new Point(-1, -1);
            pbGreenDoor.Name = "pbGreenDoor";
            pbGreenDoor.Size = new Size(75, 55);
            pbGreenDoor.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGreenDoor.TabIndex = 5;
            pbGreenDoor.TabStop = false;
            pbGreenDoor.Click += pbTool_Click;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(label9);
            panel8.Controls.Add(pbRedBox);
            panel8.Location = new Point(54, 569);
            panel8.Name = "panel8";
            panel8.Size = new Size(160, 55);
            panel8.TabIndex = 9;
            panel8.Tag = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(80, 18);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 7;
            label9.Text = "Red Box";
            // 
            // pbRedBox
            // 
            pbRedBox.Image = Properties.Resources.red_block_24;
            pbRedBox.Location = new Point(-1, -1);
            pbRedBox.Name = "pbRedBox";
            pbRedBox.Size = new Size(63, 55);
            pbRedBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRedBox.TabIndex = 5;
            pbRedBox.TabStop = false;
            pbRedBox.Click += pbTool_Click;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label10);
            panel9.Controls.Add(pbGreenBox);
            panel9.Location = new Point(54, 658);
            panel9.Name = "panel9";
            panel9.Size = new Size(160, 55);
            panel9.TabIndex = 9;
            panel9.Tag = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(73, 15);
            label10.Name = "label10";
            label10.Size = new Size(92, 25);
            label10.TabIndex = 7;
            label10.Text = "Green Box";
            // 
            // pbGreenBox
            // 
            pbGreenBox.Image = Properties.Resources.green_block_24;
            pbGreenBox.Location = new Point(-1, -1);
            pbGreenBox.Name = "pbGreenBox";
            pbGreenBox.Size = new Size(75, 55);
            pbGreenBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGreenBox.TabIndex = 5;
            pbGreenBox.TabStop = false;
            pbGreenBox.Click += pbTool_Click;
            // 
            // DesignForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 763);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(displayPanel);
            Controls.Add(panel1);
            Controls.Add(toolStrip);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DesignForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Design Form";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbNone).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWall).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedDoor).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGreenDoor).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRedBox).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbGreenBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem tsSave;
        private ToolStripMenuItem tsClose;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox tbColumn;
        private TextBox tbRow;
        private Button btnGenerate;
        private Panel displayPanel;
        private Label label3;
        private PictureBox pbNone;
        private Panel panel3;
        private Label label4;
        private Panel panel5;
        private Label label6;
        private PictureBox pbWall;
        private Panel panel6;
        private Label label7;
        private PictureBox pbRedDoor;
        private Panel panel7;
        private Label label8;
        private PictureBox pbGreenDoor;
        private Panel panel8;
        private Label label9;
        private PictureBox pbRedBox;
        private Panel panel9;
        private Label label10;
        private PictureBox pbGreenBox;
    }
}