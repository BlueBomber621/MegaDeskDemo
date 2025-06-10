namespace MegaDeskDemo
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addQuoteButton = new Button();
            viewQuoteButton = new Button();
            searchQuoteButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // addQuoteButton
            // 
            addQuoteButton.Location = new Point(12, 7);
            addQuoteButton.Name = "addQuoteButton";
            addQuoteButton.Size = new Size(198, 52);
            addQuoteButton.TabIndex = 0;
            addQuoteButton.Text = "Add New Quote";
            addQuoteButton.UseVisualStyleBackColor = true;
            addQuoteButton.Click += addQuoteButton_Click;
            // 
            // viewQuoteButton
            // 
            viewQuoteButton.Location = new Point(12, 65);
            viewQuoteButton.Name = "viewQuoteButton";
            viewQuoteButton.Size = new Size(198, 52);
            viewQuoteButton.TabIndex = 1;
            viewQuoteButton.Text = "View Quotes";
            viewQuoteButton.UseVisualStyleBackColor = true;
            // 
            // searchQuoteButton
            // 
            searchQuoteButton.Location = new Point(12, 123);
            searchQuoteButton.Name = "searchQuoteButton";
            searchQuoteButton.Size = new Size(198, 52);
            searchQuoteButton.TabIndex = 2;
            searchQuoteButton.Text = "Search Quotes";
            searchQuoteButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 181);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(198, 52);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(216, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 190);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 239);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(searchQuoteButton);
            Controls.Add(viewQuoteButton);
            Controls.Add(addQuoteButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainMenu";
            Text = "MegaDesk (Demo)";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addQuoteButton;
        private Button viewQuoteButton;
        private Button searchQuoteButton;
        private Button exitButton;
        private PictureBox pictureBox1;
    }
}
