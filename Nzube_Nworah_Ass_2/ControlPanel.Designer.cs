namespace Nzube_Nworah_Ass_2
{
    partial class ControlPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            btnDesgin = new Button();
            btnPlay = new Button();
            btnExist = new Button();
            SuspendLayout();
            // 
            // btnDesgin
            // 
            btnDesgin.Location = new Point(60, 50);
            btnDesgin.Name = "btnDesgin";
            btnDesgin.Size = new Size(130, 60);
            btnDesgin.TabIndex = 0;
            btnDesgin.Text = "Design";
            btnDesgin.UseVisualStyleBackColor = true;
            btnDesgin.Click += btnDesgin_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(258, 53);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(130, 60);
            btnPlay.TabIndex = 1;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += this.btnPlay_Click;
            // 
            // btnExist
            // 
            btnExist.Location = new Point(157, 151);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(130, 60);
            btnExist.TabIndex = 2;
            btnExist.Text = "Exist";
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += this.btnExist_Click;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 244);
            Controls.Add(btnExist);
            Controls.Add(btnPlay);
            Controls.Add(btnDesgin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControlPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QGame Control Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDesgin;
        private Button btnPlay;
        private Button btnExist;
    }
}
