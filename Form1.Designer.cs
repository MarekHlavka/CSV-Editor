namespace CSV_Editor_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_load = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_item_new,
            this.menu_item_load,
            this.menu_item_save,
            this.menu_item_exit});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // menu_item_new
            // 
            this.menu_item_new.Name = "menu_item_new";
            this.menu_item_new.Size = new System.Drawing.Size(100, 22);
            this.menu_item_new.Text = "New";
            // 
            // menu_item_load
            // 
            this.menu_item_load.Name = "menu_item_load";
            this.menu_item_load.Size = new System.Drawing.Size(100, 22);
            this.menu_item_load.Text = "Load";
            this.menu_item_load.Click += new System.EventHandler(this.menu_item_load_Click);
            // 
            // menu_item_save
            // 
            this.menu_item_save.Name = "menu_item_save";
            this.menu_item_save.Size = new System.Drawing.Size(100, 22);
            this.menu_item_save.Text = "Save";
            this.menu_item_save.Click += new System.EventHandler(this.menu_item_save_Click);
            // 
            // menu_item_exit
            // 
            this.menu_item_exit.Name = "menu_item_exit";
            this.menu_item_exit.Size = new System.Drawing.Size(100, 22);
            this.menu_item_exit.Text = "Exit";
            // 
            // data_grid
            // 
            this.data_grid.AllowDrop = true;
            this.data_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Location = new System.Drawing.Point(9, 127);
            this.data_grid.Name = "data_grid";
            this.data_grid.RowTemplate.Height = 25;
            this.data_grid.Size = new System.Drawing.Size(923, 477);
            this.data_grid.TabIndex = 1;
            this.data_grid.DragDrop += new System.Windows.Forms.DragEventHandler(this.data_grid_DragDrop);
            this.data_grid.DragOver += new System.Windows.Forms.DragEventHandler(this.data_grid_DragOver);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(424, 62);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(38, 15);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 616);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.data_grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CSV Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem menu_item_new;
        private ToolStripMenuItem menu_item_load;
        private ToolStripMenuItem menu_item_save;
        private ToolStripMenuItem menu_item_exit;
        private DataGridView data_grid;
        private Label lbl;
    }
}