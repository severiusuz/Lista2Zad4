namespace Zad4
{
    partial class Form1
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
            this.personListBox = new System.Windows.Forms.ListBox();
            this.stworzButton = new System.Windows.Forms.Button();
            this.szczyscButton = new System.Windows.Forms.Button();
            this.skasujButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.spreparujButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.Location = new System.Drawing.Point(12, 12);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(142, 173);
            this.personListBox.TabIndex = 0;
            this.personListBox.SelectedIndexChanged += new System.EventHandler(this.personListBox_SelectedIndexChanged);
            // 
            // stworzButton
            // 
            this.stworzButton.Location = new System.Drawing.Point(407, 188);
            this.stworzButton.Name = "stworzButton";
            this.stworzButton.Size = new System.Drawing.Size(75, 23);
            this.stworzButton.TabIndex = 1;
            this.stworzButton.Text = "Stwórz";
            this.stworzButton.UseVisualStyleBackColor = true;
            this.stworzButton.Click += new System.EventHandler(this.stworzButton_Click);
            // 
            // szczyscButton
            // 
            this.szczyscButton.Location = new System.Drawing.Point(326, 188);
            this.szczyscButton.Name = "szczyscButton";
            this.szczyscButton.Size = new System.Drawing.Size(75, 23);
            this.szczyscButton.TabIndex = 2;
            this.szczyscButton.Text = "Szczyść";
            this.szczyscButton.UseVisualStyleBackColor = true;
            this.szczyscButton.Click += new System.EventHandler(this.szczyscButton_Click);
            // 
            // skasujButton
            // 
            this.skasujButton.Location = new System.Drawing.Point(245, 188);
            this.skasujButton.Name = "skasujButton";
            this.skasujButton.Size = new System.Drawing.Size(75, 23);
            this.skasujButton.TabIndex = 3;
            this.skasujButton.Text = "Skasuj";
            this.skasujButton.UseVisualStyleBackColor = true;
            this.skasujButton.Click += new System.EventHandler(this.skasujButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(320, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(160, 147);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(320, 20);
            this.phoneNumberTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(160, 108);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(321, 20);
            this.addressTextBox.TabIndex = 7;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(160, 69);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(320, 20);
            this.surnameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(160, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(26, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Imie";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(160, 53);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(53, 13);
            this.surnameLabel.TabIndex = 10;
            this.surnameLabel.Text = "Nazwisko";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(160, 131);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(79, 13);
            this.phoneNumberLabel.TabIndex = 11;
            this.phoneNumberLabel.Text = "Numer telefonu";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(160, 92);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(34, 13);
            this.addressLabel.TabIndex = 12;
            this.addressLabel.Text = "Adres";
            // 
            // spreparujButton
            // 
            this.spreparujButton.Location = new System.Drawing.Point(164, 188);
            this.spreparujButton.Name = "spreparujButton";
            this.spreparujButton.Size = new System.Drawing.Size(75, 23);
            this.spreparujButton.TabIndex = 4;
            this.spreparujButton.Text = "Spreparuj";
            this.spreparujButton.UseVisualStyleBackColor = true;
            this.spreparujButton.Click += new System.EventHandler(this.spreparujButton_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 188);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(70, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(84, 188);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(70, 23);
            this.Load.TabIndex = 14;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Load_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 226);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.spreparujButton);
            this.Controls.Add(this.skasujButton);
            this.Controls.Add(this.szczyscButton);
            this.Controls.Add(this.stworzButton);
            this.Controls.Add(this.personListBox);
            this.Name = "Form1";
            this.Text = "Szczyszczona Baza danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.Button stworzButton;
        private System.Windows.Forms.Button szczyscButton;
        private System.Windows.Forms.Button skasujButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button spreparujButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}

