
namespace WindowsFormsApp1
{
    partial class TableManagementForm
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
            this.CreateATableButton = new System.Windows.Forms.Button();
            this.DeleteTableButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateATableButton
            // 
            this.CreateATableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateATableButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.CreateATableButton.Location = new System.Drawing.Point(115, 286);
            this.CreateATableButton.Name = "CreateATableButton";
            this.CreateATableButton.Size = new System.Drawing.Size(166, 83);
            this.CreateATableButton.TabIndex = 32;
            this.CreateATableButton.Text = "テーブル作成";
            this.CreateATableButton.UseVisualStyleBackColor = true;
            this.CreateATableButton.Click += new System.EventHandler(this.CreateATableButtonClick);
            // 
            // DeleteTableButton
            // 
            this.DeleteTableButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteTableButton.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.DeleteTableButton.Location = new System.Drawing.Point(515, 286);
            this.DeleteTableButton.Name = "DeleteTableButton";
            this.DeleteTableButton.Size = new System.Drawing.Size(166, 83);
            this.DeleteTableButton.TabIndex = 31;
            this.DeleteTableButton.Text = "テーブル削除";
            this.DeleteTableButton.UseVisualStyleBackColor = true;
            this.DeleteTableButton.Click += new System.EventHandler(this.DeleteTablebButtonClick);
            // 
            // Label
            // 
            this.Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("ＭＳ ゴシック", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label.Location = new System.Drawing.Point(265, 134);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(255, 45);
            this.Label.TabIndex = 30;
            this.Label.Text = "パスワード";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(241, 193);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(297, 36);
            this.PasswordTextBox.TabIndex = 29;
            // 
            // TableManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateATableButton);
            this.Controls.Add(this.DeleteTableButton);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.PasswordTextBox);
            this.Name = "TableManagementForm";
            this.Text = "テーブル管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateATableButton;
        private System.Windows.Forms.Button DeleteTableButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}