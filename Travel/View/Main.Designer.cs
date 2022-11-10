namespace TravelCore.View
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addTravelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTravelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryFilterComboBox = new System.Windows.Forms.ComboBox();
            this.travelsDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTravelMenuItem,
            this.listTravelsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addTravelMenuItem
            // 
            this.addTravelMenuItem.Name = "addTravelMenuItem";
            this.addTravelMenuItem.Size = new System.Drawing.Size(74, 20);
            this.addTravelMenuItem.Text = "Add Travel";
            this.addTravelMenuItem.Click += new System.EventHandler(this.addTravelMenuItem_Click);
            // 
            // listTravelsMenuItem
            // 
            this.listTravelsMenuItem.Name = "listTravelsMenuItem";
            this.listTravelsMenuItem.Size = new System.Drawing.Size(75, 20);
            this.listTravelsMenuItem.Text = "List Travels";
            this.listTravelsMenuItem.Click += new System.EventHandler(this.listTravelsMenuItem_Click);
            // 
            // categoryFilterComboBox
            // 
            this.categoryFilterComboBox.FormattingEnabled = true;
            this.categoryFilterComboBox.Location = new System.Drawing.Point(180, 33);
            this.categoryFilterComboBox.Name = "categoryFilterComboBox";
            this.categoryFilterComboBox.Size = new System.Drawing.Size(335, 23);
            this.categoryFilterComboBox.TabIndex = 1;
            // 
            // travelsDataGridView
            // 
            this.travelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelsDataGridView.Location = new System.Drawing.Point(12, 62);
            this.travelsDataGridView.Name = "travelsDataGridView";
            this.travelsDataGridView.RowTemplate.Height = 25;
            this.travelsDataGridView.Size = new System.Drawing.Size(673, 342);
            this.travelsDataGridView.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 415);
            this.Controls.Add(this.travelsDataGridView);
            this.Controls.Add(this.categoryFilterComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Travel App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addTravelMenuItem;
        private ToolStripMenuItem listTravelsMenuItem;
        private ComboBox categoryFilterComboBox;
        private DataGridView travelsDataGridView;
    }
}