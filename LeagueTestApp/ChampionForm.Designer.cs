namespace LeagueTestApp
{
    partial class ChampionForm
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
            this.championDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.championDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // championDataGridView
            // 
            this.championDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.championDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.championDataGridView.Location = new System.Drawing.Point(0, 0);
            this.championDataGridView.Name = "championDataGridView";
            this.championDataGridView.ReadOnly = true;
            this.championDataGridView.Size = new System.Drawing.Size(564, 244);
            this.championDataGridView.TabIndex = 0;
            this.championDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.championDataGridView_CellContentClick);
            // 
            // ChampionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 244);
            this.Controls.Add(this.championDataGridView);
            this.Name = "ChampionForm";
            this.Text = "ChampionForm";
            this.Load += new System.EventHandler(this.ChampionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.championDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView championDataGridView;
    }
}