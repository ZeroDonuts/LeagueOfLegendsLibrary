namespace LeagueTestApp
{
    partial class SummonerForm
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
            this.summonerInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            this.runeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.summonerInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // summonerInfoDataGrid
            // 
            this.summonerInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.summonerInfoDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.summonerInfoDataGrid.Location = new System.Drawing.Point(0, 32);
            this.summonerInfoDataGrid.Name = "summonerInfoDataGrid";
            this.summonerInfoDataGrid.Size = new System.Drawing.Size(530, 269);
            this.summonerInfoDataGrid.TabIndex = 0;
            this.summonerInfoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.summonerInfoDataGrid_CellContentClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(44, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(453, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Location = new System.Drawing.Point(273, 6);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(44, 13);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Region:";
            // 
            // regionComboBox
            // 
            this.regionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionComboBox.FormattingEnabled = true;
            this.regionComboBox.Items.AddRange(new object[] {
            "na",
            "euw",
            "eune"});
            this.regionComboBox.Location = new System.Drawing.Point(323, 3);
            this.regionComboBox.Name = "regionComboBox";
            this.regionComboBox.Size = new System.Drawing.Size(121, 21);
            this.regionComboBox.TabIndex = 6;
            // 
            // runeButton
            // 
            this.runeButton.Location = new System.Drawing.Point(223, 1);
            this.runeButton.Name = "runeButton";
            this.runeButton.Size = new System.Drawing.Size(52, 23);
            this.runeButton.TabIndex = 7;
            this.runeButton.Text = "Runes";
            this.runeButton.UseVisualStyleBackColor = true;
            this.runeButton.Click += new System.EventHandler(this.runeButton_Click);
            // 
            // SummonerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 301);
            this.Controls.Add(this.runeButton);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.summonerInfoDataGrid);
            this.Name = "SummonerForm";
            this.Text = "SummonerForm";
            this.Load += new System.EventHandler(this.SummonerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.summonerInfoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView summonerInfoDataGrid;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionComboBox;
        private System.Windows.Forms.Button runeButton;
    }
}