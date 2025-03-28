namespace Edycja_obrazka_3._0
{
    partial class Form1
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
            pictureBox = new PictureBox();
            btnLoad = new Button();
            btnOnlyGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(242, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(297, 357);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(84, 363);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.BackColor = Color.LimeGreen;
            btnOnlyGreen.Location = new Point(84, 299);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(112, 34);
            btnOnlyGreen.TabIndex = 2;
            btnOnlyGreen.Text = "OnlyGreen";
            btnOnlyGreen.UseVisualStyleBackColor = false;
            btnOnlyGreen.Click += btnOnlyGreen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnLoad;
        private Button btnOnlyGreen;
    }
}
