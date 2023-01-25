
namespace WindowsFormsApp1
{
    partial class NewRegistrationForm
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
            this.Label8 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.SchoolIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.Label8.Location = new System.Drawing.Point(208, 195);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(90, 15);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "ハイフン無しで";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Label2.Location = new System.Drawing.Point(35, 56);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(527, 25);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "登録するために必須な個人情報を記入してください。";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RegistrationButton.Location = new System.Drawing.Point(598, 323);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(134, 45);
            this.RegistrationButton.TabIndex = 19;
            this.RegistrationButton.Text = "登録";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButtonClick);
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label5.Location = new System.Drawing.Point(441, 160);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 20);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "名前";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NameTextBox.Location = new System.Drawing.Point(513, 159);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(131, 24);
            this.NameTextBox.TabIndex = 17;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label4.Location = new System.Drawing.Point(91, 159);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 20);
            this.Label4.TabIndex = 16;
            this.Label4.Text = "姓";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label6.Location = new System.Drawing.Point(91, 217);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(89, 20);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "電話番号";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RenameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.RenameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RenameTextBox.Location = new System.Drawing.Point(211, 159);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(131, 24);
            this.RenameTextBox.TabIndex = 14;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TelephoneTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.TelephoneTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TelephoneTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TelephoneTextBox.Location = new System.Drawing.Point(211, 213);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.ShortcutsEnabled = false;
            this.TelephoneTextBox.Size = new System.Drawing.Size(193, 24);
            this.TelephoneTextBox.TabIndex = 13;
            this.TelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label7.Location = new System.Drawing.Point(91, 274);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(49, 20);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "住所";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AddressTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddressTextBox.Location = new System.Drawing.Point(211, 270);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(433, 24);
            this.AddressTextBox.TabIndex = 11;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 19F);
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 33);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "新規登録";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label3.Location = new System.Drawing.Point(91, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 20);
            this.Label3.TabIndex = 36;
            this.Label3.Text = "学籍番号";
            // 
            // SchoolIDTextBox
            // 
            this.SchoolIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SchoolIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SchoolIDTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SchoolIDTextBox.Location = new System.Drawing.Point(211, 115);
            this.SchoolIDTextBox.Name = "SchoolIDTextBox";
            this.SchoolIDTextBox.Size = new System.Drawing.Size(131, 24);
            this.SchoolIDTextBox.TabIndex = 37;
            this.SchoolIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberKeyPress);
            // 
            // NewRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 395);
            this.Controls.Add(this.SchoolIDTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.AddressTextBox);
            this.Name = "NewRegistrationForm";
            this.Text = "新規登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox SchoolIDTextBox;
    }
}