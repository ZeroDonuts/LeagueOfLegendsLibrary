namespace LeagueTestApp
{
    partial class Runes
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
            this.RuneDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RuneDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RuneDataGridView
            // 
            this.RuneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RuneDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RuneDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RuneDataGridView.Name = "RuneDataGridView";
            this.RuneDataGridView.Size = new System.Drawing.Size(284, 262);
            this.RuneDataGridView.TabIndex = 0;
            // 
            // Runes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.RuneDataGridView);
            this.Name = "Runes";
            this.Text = "Runes";
            ((System.ComponentModel.ISupportInitialize)(this.RuneDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RuneDataGridView;
    }
}