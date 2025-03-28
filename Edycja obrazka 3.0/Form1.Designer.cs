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
            btnRotate = new Button();
            rdo90 = new RadioButton();
            rdo180 = new RadioButton();
            rdo270 = new RadioButton();
            btnInvert = new Button();
            btnUpsideDown = new Button();
            btnOnlyGreen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();

            // pictureBox
            pictureBox.Location = new Point(242, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(297, 357);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;

            // btnLoad
            btnLoad.Location = new Point(84, 363);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;

            // btnRotate
            btnRotate.BackColor = Color.IndianRed;
            btnRotate.Location = new Point(84, 152);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(112, 34);
            btnRotate.TabIndex = 2;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = false;
            btnRotate.Click += btnRotate_Click;

            // rdo90
            rdo90.AutoSize = true;
            rdo90.BackColor = Color.IndianRed;
            rdo90.Location = new Point(106, 24);
            rdo90.Name = "rdo90";
            rdo90.Size = new Size(76, 29);
            rdo90.TabIndex = 3;
            rdo90.TabStop = true;
            rdo90.Text = "90 st";
            rdo90.UseVisualStyleBackColor = false;

            // rdo180
            rdo180.AutoSize = true;
            rdo180.BackColor = Color.IndianRed;
            rdo180.Location = new Point(106, 59);
            rdo180.Name = "rdo180";
            rdo180.Size = new Size(86, 29);
            rdo180.TabIndex = 4;
            rdo180.TabStop = true;
            rdo180.Text = "180 st";
            rdo180.UseVisualStyleBackColor = false;

            // rdo270
            rdo270.AutoSize = true;
            rdo270.BackColor = Color.IndianRed;
            rdo270.Location = new Point(106, 94);
            rdo270.Name = "rdo270";
            rdo270.Size = new Size(86, 29);
            rdo270.TabIndex = 5;
            rdo270.TabStop = true;
            rdo270.Text = "270 st";
            rdo270.UseVisualStyleBackColor = false;

            // btnInvert
            btnInvert.BackColor = SystemColors.ActiveCaption;
            btnInvert.Location = new Point(84, 204);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(125, 36);
            btnInvert.TabIndex = 6;
            btnInvert.Text = "Invert Colors";
            btnInvert.UseVisualStyleBackColor = false;
            btnInvert.Click += btnInvert_Click;

            // btnUpsideDown
            btnUpsideDown.BackColor = SystemColors.ActiveCaption;
            btnUpsideDown.Location = new Point(84, 256);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(127, 37);
            btnUpsideDown.TabIndex = 7;
            btnUpsideDown.Text = "Upside Down";
            btnUpsideDown.UseVisualStyleBackColor = false;
            btnUpsideDown.Click += btnUpsideDown_Click;

            // btnOnlyGreen
            btnOnlyGreen.BackColor = Color.LimeGreen;
            btnOnlyGreen.Location = new Point(84, 299);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(112, 34);
            btnOnlyGreen.TabIndex = 8;
            btnOnlyGreen.Text = "Only Green";
            btnOnlyGreen.UseVisualStyleBackColor = false;
            btnOnlyGreen.Click += btnOnlyGreen_Click;

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(btnRotate);
            Controls.Add(rdo270);
            Controls.Add(rdo180);
            Controls.Add(rdo90);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Button btnLoad;
        private Button btnRotate;
        private RadioButton rdo90;
        private RadioButton rdo180;
        private RadioButton rdo270;
        private Button btnInvert;
        private Button btnUpsideDown;
        private Button btnOnlyGreen;
    }
}
