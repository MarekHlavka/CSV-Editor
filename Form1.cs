using System.Data;

namespace CSV_Editor_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void open_file(string path)
        {
            StreamReader reader = new StreamReader(path);

            // Loading data from file
            string[] data = new string[File.ReadAllLines(path).Length];
            data = reader.ReadLine().Split(',');
            int nof_cols = data.Length;

            // Column header handle
            DataTable dataTable = new DataTable();
            for (int i = 0; i < nof_cols; i++)
            {
                dataTable.Columns.Add(data[i]);
            }

            while (!reader.EndOfStream)
            {
                data = reader.ReadLine().Split(',');
                dataTable.Rows.Add(data);
            }
            data_grid.DataSource = dataTable;
        }

        private void menu_item_load_Click(object sender, EventArgs e)
        {
            // Load file via button
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CSF files | *.csv";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String path = dialog.FileName;
                open_file(path);
                
            }
        }

        private void menu_item_save_Click(object sender, EventArgs e)
        {
            string csv = string.Empty;

            foreach (DataGridViewRow row in data_grid.Rows)
            {
                foreach (DataGridViewTextBoxCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        csv += cell.Value.ToString() + ',';
                    }

                }
                csv = csv.Remove(csv.Length - 1, 1);
                csv += "\r\n";

            }

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;
                StreamWriter writer = new StreamWriter(path);

                writer.WriteLine(csv);
                writer.Close();
            }
        }

        private void data_grid_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);

                if(filenames.Length > 1)
                {
                    MessageBox.Show("Can open only one file!");
                }
                else
                {
                    open_file(filenames[0]);
                }
            }
        }

        private void data_grid_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}