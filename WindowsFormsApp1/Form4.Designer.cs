
namespace WindowsFormsApp1
{
    partial class DataUpdateForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.TableCheckButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DataBaseView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SchoolIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.Location = new System.Drawing.Point(1104, 380);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 45);
            this.CloseButton.TabIndex = 46;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // TableCheckButton
            // 
            this.TableCheckButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.TableCheckButton.Location = new System.Drawing.Point(668, 99);
            this.TableCheckButton.Name = "TableCheckButton";
            this.TableCheckButton.Size = new System.Drawing.Size(154, 47);
            this.TableCheckButton.TabIndex = 45;
            this.TableCheckButton.Text = "テーブル確認";
            this.TableCheckButton.UseVisualStyleBackColor = true;
            this.TableCheckButton.Click += new System.EventHandler(this.TableCheckButtonClick);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IDTextBox.Location = new System.Drawing.Point(156, 144);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(131, 24);
            this.IDTextBox.TabIndex = 44;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextKeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(49, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "変更先ID";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpdateButton.Location = new System.Drawing.Point(491, 380);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(134, 45);
            this.UpdateButton.TabIndex = 42;
            this.UpdateButton.Text = "変更";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButtonClick);
            // 
            // DataBaseView
            // 
            this.DataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseView.Location = new System.Drawing.Point(668, 169);
            this.DataBaseView.Name = "DataBaseView";
            this.DataBaseView.RowHeadersWidth = 51;
            this.DataBaseView.RowTemplate.Height = 24;
            this.DataBaseView.Size = new System.Drawing.Size(556, 169);
            this.DataBaseView.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.label6.Location = new System.Drawing.Point(153, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "ハイフン無しで";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(347, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "名前";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NameTextBox.Location = new System.Drawing.Point(458, 196);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(131, 24);
            this.NameTextBox.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(49, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "姓";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(49, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "電話番号";
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.RenameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.RenameTextBox.Location = new System.Drawing.Point(156, 196);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(131, 24);
            this.RenameTextBox.TabIndex = 35;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.TelephoneTextBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TelephoneTextBox.Location = new System.Drawing.Point(156, 256);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(193, 24);
            this.TelephoneTextBox.TabIndex = 34;
            this.TelephoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextKeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(49, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "住所";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.AddressTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AddressTextBox.Location = new System.Drawing.Point(156, 314);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(433, 24);
            this.AddressTextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "登 録 情 報 の 変 更";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "変更する対象のIDと変更情報を記入してください。";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(347, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "学籍番号";
            // 
            // SchoolIDTextBox
            // 
            this.SchoolIDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.SchoolIDTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SchoolIDTextBox.Location = new System.Drawing.Point(458, 144);
            this.SchoolIDTextBox.Name = "SchoolIDTextBox";
            this.SchoolIDTextBox.Size = new System.Drawing.Size(131, 24);
            this.SchoolIDTextBox.TabIndex = 47;
            this.SchoolIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextKeyPress);
            // 
            // DataUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 447);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SchoolIDTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TableCheckButton);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DataBaseView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RenameTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "DataUpdateForm";
            this.Text = "登録情報変更";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button TableCheckButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView DataBaseView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SchoolIDTextBox;
    }
}