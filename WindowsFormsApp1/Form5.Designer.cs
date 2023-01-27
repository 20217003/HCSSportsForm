
namespace WindowsFormsApp1
{
    partial class DataSearchForm
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
            this.DataSearchButton = new System.Windows.Forms.Button();
            this.DataBaseView = new System.Windows.Forms.DataGridView();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SchoolIDRadioButton = new System.Windows.Forms.RadioButton();
            this.IDRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.Location = new System.Drawing.Point(654, 393);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(134, 45);
            this.CloseButton.TabIndex = 39;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // DataSearchButton
            // 
            this.DataSearchButton.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DataSearchButton.Location = new System.Drawing.Point(410, 94);
            this.DataSearchButton.Name = "DataSearchButton";
            this.DataSearchButton.Size = new System.Drawing.Size(99, 73);
            this.DataSearchButton.TabIndex = 38;
            this.DataSearchButton.Text = "検索";
            this.DataSearchButton.UseVisualStyleBackColor = true;
            this.DataSearchButton.Click += new System.EventHandler(this.DataSearchButtonClick);
            // 
            // DataBaseView
            // 
            this.DataBaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBaseView.Location = new System.Drawing.Point(62, 198);
            this.DataBaseView.Name = "DataBaseView";
            this.DataBaseView.RowHeadersWidth = 51;
            this.DataBaseView.RowTemplate.Height = 24;
            this.DataBaseView.Size = new System.Drawing.Size(676, 169);
            this.DataBaseView.TabIndex = 37;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.NumberTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.NumberTextBox.Location = new System.Drawing.Point(261, 118);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(131, 24);
            this.NumberTextBox.TabIndex = 36;
            this.NumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTextKeyPress);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label3.Location = new System.Drawing.Point(16, 122);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(93, 20);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "検索指定";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 19F);
            this.Label1.Location = new System.Drawing.Point(12, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(207, 33);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "登録情報検索";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Label2.Location = new System.Drawing.Point(16, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(553, 20);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "特定の対象を検索したい場合IDか学籍番号を選んで入力してください";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SchoolIDRadioButton);
            this.groupBox1.Controls.Add(this.IDRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(120, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 85);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // SchoolIDRadioButton
            // 
            this.SchoolIDRadioButton.AutoSize = true;
            this.SchoolIDRadioButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SchoolIDRadioButton.Location = new System.Drawing.Point(4, 55);
            this.SchoolIDRadioButton.Name = "SchoolIDRadioButton";
            this.SchoolIDRadioButton.Size = new System.Drawing.Size(114, 24);
            this.SchoolIDRadioButton.TabIndex = 1;
            this.SchoolIDRadioButton.TabStop = true;
            this.SchoolIDRadioButton.Text = "学籍番号";
            this.SchoolIDRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDRadioButton
            // 
            this.IDRadioButton.AutoSize = true;
            this.IDRadioButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.IDRadioButton.Location = new System.Drawing.Point(4, 12);
            this.IDRadioButton.Name = "IDRadioButton";
            this.IDRadioButton.Size = new System.Drawing.Size(50, 24);
            this.IDRadioButton.TabIndex = 0;
            this.IDRadioButton.TabStop = true;
            this.IDRadioButton.Text = "ID";
            this.IDRadioButton.UseVisualStyleBackColor = true;
            // 
            // DataSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DataSearchButton);
            this.Controls.Add(this.DataBaseView);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Name = "DataSearchForm";
            this.Text = "登録情報検索";
            ((System.ComponentModel.ISupportInitialize)(this.DataBaseView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button DataSearchButton;
        private System.Windows.Forms.DataGridView DataBaseView;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SchoolIDRadioButton;
        private System.Windows.Forms.RadioButton IDRadioButton;
    }
}