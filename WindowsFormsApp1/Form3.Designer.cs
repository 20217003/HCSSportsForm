
namespace WindowsFormsApp1
{
    partial class DataDeletionForm
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DataBaseView = new System.Windows.Forms.DataGridView();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TableCheckButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 19F);
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(143, 33);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "登録削除";
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label2.Location = new System.Drawing.Point(26, 71);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(176, 20);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "登録情報を削除する";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.Location = new System.Drawing.Point(693, 392);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 45);
            this.CloseButton.TabIndex = 44;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.Font = new System.Drawing.Font("MS UI Gothic", 17F);
            this.DeleteButton.Location = new System.Drawing.Point(313, 144);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(99, 39);
            this.DeleteButton.TabIndex = 43;
            this.DeleteButton.Text = "削除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // DataBaseView
            // 
            this.DataBaseView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseView.Location = new System.Drawing.Point(163, 198);
            this.DataBaseView.Name = "DataBaseView";
            this.DataBaseView.RowHeadersWidth = 51;
            this.DataBaseView.RowTemplate.Height = 24;
            this.DataBaseView.Size = new System.Drawing.Size(556, 169);
            this.DataBaseView.TabIndex = 42;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.IDTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IDTextBox.Location = new System.Drawing.Point(163, 111);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(131, 29);
            this.IDTextBox.TabIndex = 41;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextKeyPress);
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label3.Location = new System.Drawing.Point(52, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(99, 20);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "削除するID";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label4.Location = new System.Drawing.Point(65, 155);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(86, 20);
            this.Label4.TabIndex = 45;
            this.Label4.Text = "パスワード";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PasswordTextBox.Location = new System.Drawing.Point(163, 151);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(131, 29);
            this.PasswordTextBox.TabIndex = 46;
            // 
            // TableCheckButton
            // 
            this.TableCheckButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableCheckButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.TableCheckButton.Location = new System.Drawing.Point(561, 130);
            this.TableCheckButton.Name = "TableCheckButton";
            this.TableCheckButton.Size = new System.Drawing.Size(158, 53);
            this.TableCheckButton.TabIndex = 47;
            this.TableCheckButton.Text = "テーブル確認";
            this.TableCheckButton.UseVisualStyleBackColor = true;
            this.TableCheckButton.Click += new System.EventHandler(this.TableCheckButtonClick);
            // 
            // DataDeletionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.TableCheckButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DataBaseView);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Name = "DataDeletionForm";
            this.Text = "登録削除";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView DataBaseView;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button TableCheckButton;
    }
}