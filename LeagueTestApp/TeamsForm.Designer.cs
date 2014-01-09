namespace LeagueTestApp
{
    partial class TeamsForm
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
            this.teamsInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.regionLabel = new System.Windows.Forms.Label();
            this.regionComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teamsInfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsInfoDataGrid
            // 
            this.teamsInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsInfoDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.teamsInfoDataGrid.Location = new System.Drawing.Point(0, 32);
            this.teamsInfoDataGrid.Name = "teamsInfoDataGrid";
            this.teamsInfoDataGrid.Size = new System.Drawing.Size(530, 269);
            this.teamsInfoDataGrid.TabIndex = 0;
            this.teamsInfoDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamsInfoDataGrid_CellContentClick);
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
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 301);
            this.Controls.Add(this.regionComboBox);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.teamsInfoDataGrid);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.Load += new System.EventHandler(this.TeamsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamsInfoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        void teamsInfoDataGrid_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.DataGridView teamsInfoDataGrid;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.ComboBox regionComboBox;
    }
}