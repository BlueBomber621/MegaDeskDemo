namespace MegaDeskDemo
{
    partial class AddQuote
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
            components = new System.ComponentModel.Container();
            mainMenuButton = new Button();
            label1 = new Label();
            label2 = new Label();
            dateLabel = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            widthInput = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            depthInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            drawerInput = new ComboBox();
            errorProvider2 = new ErrorProvider(components);
            materialInput = new ComboBox();
            label9 = new Label();
            shippingInput = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // mainMenuButton
            // 
            mainMenuButton.Location = new Point(12, 386);
            mainMenuButton.Name = "mainMenuButton";
            mainMenuButton.Size = new Size(198, 52);
            mainMenuButton.TabIndex = 0;
            mainMenuButton.Text = "Main Menu";
            mainMenuButton.UseVisualStyleBackColor = true;
            mainMenuButton.Click += GoBack;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 38);
            label1.TabIndex = 1;
            label1.Text = "MegaDesk";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Margin = new Padding(3, 28, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 24);
            label2.TabIndex = 2;
            label2.Text = "Today's Date:";
            // 
            // dateLabel
            // 
            dateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.Location = new Point(270, 75);
            dateLabel.Margin = new Padding(3, 28, 3, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(178, 24);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "0/0/0000";
            dateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(12, 112);
            label3.Margin = new Padding(3, 12, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(252, 24);
            label3.TabIndex = 4;
            label3.Text = "Enter your name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(270, 111);
            nameTextBox.Margin = new Padding(3, 12, 3, 3);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Enter Name...";
            nameTextBox.Size = new Size(178, 27);
            nameTextBox.TabIndex = 5;
            nameTextBox.Leave += nameTextBox_Leave;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(12, 148);
            label4.Margin = new Padding(3, 12, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(252, 24);
            label4.TabIndex = 6;
            label4.Text = "Desk Width:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 172);
            label5.Name = "label5";
            label5.Size = new Size(252, 24);
            label5.TabIndex = 8;
            label5.Text = "Must be between 24 and 96 inches";
            // 
            // widthInput
            // 
            widthInput.Location = new Point(270, 147);
            widthInput.Margin = new Padding(3, 12, 3, 3);
            widthInput.MaxLength = 2;
            widthInput.Name = "widthInput";
            widthInput.PlaceholderText = "Enter Number...";
            widthInput.Size = new Size(178, 27);
            widthInput.TabIndex = 9;
            widthInput.Leave += widthInputLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkRate = 0;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // depthInput
            // 
            depthInput.Location = new Point(270, 207);
            depthInput.Margin = new Padding(3, 12, 3, 3);
            depthInput.MaxLength = 2;
            depthInput.Name = "depthInput";
            depthInput.PlaceholderText = "Enter Number...";
            depthInput.Size = new Size(178, 27);
            depthInput.TabIndex = 12;
            depthInput.Leave += depthInput_Leave;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(252, 24);
            label6.TabIndex = 11;
            label6.Text = "Must be between 12 and 48 inches";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(12, 208);
            label7.Margin = new Padding(3, 12, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(252, 24);
            label7.TabIndex = 10;
            label7.Text = "Desk Depth:";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(12, 268);
            label8.Margin = new Padding(3, 12, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(252, 24);
            label8.TabIndex = 13;
            label8.Text = "Desk Drawer Amount:";
            // 
            // drawerInput
            // 
            drawerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            drawerInput.FormattingEnabled = true;
            drawerInput.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            drawerInput.Location = new Point(270, 264);
            drawerInput.Name = "drawerInput";
            drawerInput.Size = new Size(178, 28);
            drawerInput.TabIndex = 14;
            drawerInput.Leave += drawerInput_Leave;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // materialInput
            // 
            materialInput.DropDownStyle = ComboBoxStyle.DropDownList;
            materialInput.FormattingEnabled = true;
            materialInput.Items.AddRange(new object[] { "Pine", "Rosewood", "Laminite", "Oak", "Veneer" });
            materialInput.Location = new Point(270, 300);
            materialInput.Name = "materialInput";
            materialInput.Size = new Size(178, 28);
            materialInput.TabIndex = 16;
            materialInput.Leave += materialInput_Leave;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(12, 304);
            label9.Margin = new Padding(3, 12, 3, 0);
            label9.Name = "label9";
            label9.Size = new Size(252, 24);
            label9.TabIndex = 15;
            label9.Text = "Desk Material:";
            // 
            // shippingInput
            // 
            shippingInput.DropDownStyle = ComboBoxStyle.DropDownList;
            shippingInput.FormattingEnabled = true;
            shippingInput.Items.AddRange(new object[] { "3", "5", "7", "14" });
            shippingInput.Location = new Point(270, 336);
            shippingInput.Name = "shippingInput";
            shippingInput.Size = new Size(178, 28);
            shippingInput.TabIndex = 18;
            shippingInput.Leave += shippingInput_Leave;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(12, 340);
            label10.Margin = new Padding(3, 12, 3, 0);
            label10.Name = "label10";
            label10.Size = new Size(252, 24);
            label10.TabIndex = 17;
            label10.Text = "Shipping Timeframe:";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 364);
            label11.Name = "label11";
            label11.Size = new Size(252, 24);
            label11.TabIndex = 19;
            label11.Text = "Express 3 days to standard 7 days";
            // 
            // addButton
            // 
            addButton.Location = new Point(300, 386);
            addButton.Name = "addButton";
            addButton.Size = new Size(198, 52);
            addButton.TabIndex = 20;
            addButton.Text = "Add Quote";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(addButton);
            Controls.Add(label11);
            Controls.Add(shippingInput);
            Controls.Add(label10);
            Controls.Add(materialInput);
            Controls.Add(label9);
            Controls.Add(drawerInput);
            Controls.Add(label8);
            Controls.Add(depthInput);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(widthInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
            Controls.Add(dateLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mainMenuButton);
            Name = "AddQuote";
            Text = "Add Quote";
            Load += AddQuote_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button mainMenuButton;
        private Label label1;
        private Label label2;
        private Label dateLabel;
        private Label label3;
        private TextBox nameTextBox;
        private Label label4;
        private Label label5;
        private TextBox widthInput;
        private ErrorProvider errorProvider1;
        private TextBox depthInput;
        private Label label6;
        private Label label7;
        private ComboBox drawerInput;
        private Label label8;
        private ErrorProvider errorProvider2;
        private ComboBox materialInput;
        private Label label9;
        private Label label11;
        private ComboBox shippingInput;
        private Label label10;
        private Button addButton;
    }
}