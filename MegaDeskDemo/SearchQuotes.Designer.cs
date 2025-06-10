namespace MegaDeskDemo
{
    partial class SearchQuotes
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
            mainMenuButton = new Button();
            SuspendLayout();
            // 
            // mainMenuButton
            // 
            mainMenuButton.Location = new Point(12, 386);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(198, 52);
            mainMenuButton.TabIndex = 1;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += GoBack;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainMenuButton);
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            ResumeLayout(false);
        }

        #endregion

        private Button mainMenuButton;
    }
}