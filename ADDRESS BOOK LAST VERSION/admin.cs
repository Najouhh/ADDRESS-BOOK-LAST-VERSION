using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ADDRESS_BOOK_LAST_VERSION
{
    public partial class admin : Form
    {
        string file = @"C:\Users\najah\OneDrive\Skrivbord\test\test.txt";
        public admin()
        {
            InitializeComponent();
            GetData();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            string namn = Namnbox.Text;
            string Gatu = Gatubox.Text;
            string post = nummerbox.Text;
            string ort = ortbox.Text;
            string telefon = telefonbox.Text;
            string epost = epostbox.Text;

            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(namn);
                writer.WriteLine(Gatu);
                writer.WriteLine(post);
                writer.WriteLine(ort);
                writer.WriteLine(telefon);
                writer.WriteLine(epost);

            }
            MessageBox.Show("sparad");
            ClearBoxes();
            ClearDataGrid();
            GetData();
        }
        public void GetData(string filter = null)
        {
            int counter = 0;
            string name = "";
            string gatuadress = "";
            string pnummer = "";
            string port = "";
            string telefon = "";
            string epost = "";

            comboBox1.Items.Clear();
            dataGridView1.Rows.Clear(); // Clear the DataGridView before populating it.

            // Create a HashSet to store unique addresses
            HashSet<string> uniqueAddresses = new HashSet<string>();

            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        name = line;
                    }
                    else if (counter == 1)
                    {
                        gatuadress = line;
                    }
                    else if (counter == 2)
                    {
                        pnummer = line;
                    }
                    else if (counter == 3)
                    {
                        port = line;
                    }
                    else if (counter == 4)
                    {
                        telefon = line;
                    }
                    else if (counter == 5)
                    {
                        epost = line;
                        // Check if the filter is null or if it matches the selected value in the ComboBox.
                        if (filter == null || filter == port)
                        {
                            dataGridView1.Rows.Add(name, gatuadress, pnummer, port, telefon, epost);
                        }
                        uniqueAddresses.Add(port);
                    }
                    counter++;
                    // Continue with the next person's data
                    if (counter > 5)
                    {
                        counter = 0;
                    }
                }
                comboBox1.Items.AddRange(uniqueAddresses.ToArray());
            }

        }
        public void ClearBoxes()
        {
            Namnbox.Clear();
            Gatubox.Clear();
            nummerbox.Clear();
            ortbox.Clear();
            telefonbox.Clear();
            epostbox.Clear();
        }
        public void ClearDataGrid()
        {
            dataGridView1.Rows.Clear();
        }
        public void SearchDataGrid(string Searchtext)
        {
            dataGridView1.ClearSelection();
            string searchtext = searchbox.Text;
            string searchLower = searchtext.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    if (cell != null && cell.Value != null)
                    {
                        string cellValue = cell.Value.ToString().ToLower();

                        if (cellValue.Contains(searchLower))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
            }
        }

        public void searchbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            string searchtext = searchbox.Text;
            string searchLower = searchtext.ToLower();

            if (!string.IsNullOrEmpty(searchtext))
            {
                SearchDataGrid(searchtext);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // få alla info fråna Data grid to text boxar
                Namnbox.Text = row.Cells[0].Value.ToString();
                Gatubox.Text = row.Cells[1].Value.ToString();
                nummerbox.Text = row.Cells[2].Value.ToString();
                ortbox.Text = row.Cells[3].Value.ToString();
                telefonbox.Text = row.Cells[4].Value.ToString();
                epostbox.Text = row.Cells[5].Value.ToString();
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0]; // ha selected row as variable
                string selectedName = selectedRow.Cells["Column1"].Value.ToString();
                string selectedAddress = selectedRow.Cells["Column2"].Value.ToString();

                // läsa hela texten i filen
                var lines = File.ReadAllLines(file).ToList();
                int startIndex = -1;// intialisera index

                // Find the starting index of the selected person's data
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i] == selectedName && lines[i + 1] == selectedAddress)
                    {
                        startIndex = i;
                        break;
                    }
                }
                if (startIndex != -1)
                {
                    // uppdatera texten 
                    lines[startIndex] = Namnbox.Text;
                    lines[startIndex + 1] = Gatubox.Text;
                    lines[startIndex + 2] = nummerbox.Text;
                    lines[startIndex + 3] = ortbox.Text;
                    lines[startIndex + 4] = telefonbox.Text;
                    lines[startIndex + 5] = epostbox.Text;
                }

                // Write the updated lines back to the file
                File.WriteAllLines(file, lines);
                MessageBox.Show("Updated");
            }
            ClearBoxes();
            ClearDataGrid();
            GetData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string selectedName = selectedRow.Cells["Column1"].Value.ToString();
                string selectedAddress = selectedRow.Cells["column2"].Value.ToString();
                // läsa genom text
                var allLines = File.ReadAllLines(file);
                //skapa en list för raderna som jag kommer behålla 
                var linesToKeep = new List<string>();

                for (int i = 0; i < allLines.Length; i += 6)
                {
                    // kolla med dem två om det är den person 
                    if (allLines[i] == selectedName && allLines[i + 1] == selectedAddress)
                    {
                        continue;
                    }
                    // behålla andra info
                    linesToKeep.AddRange(allLines.Skip(i).Take(6));
                }
                // skriv hela texten för utom den delen som matchade 
                File.WriteAllLines(file, linesToKeep);
                MessageBox.Show("deleted");
                ClearBoxes();
                ClearDataGrid();
                GetData();
            }


        }

        private void lo_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form2
            login login = new login();

            // Show Form2
            login.ShowDialog(); // Use Show() instead of ShowDialog() if you don't want it to be modal

            // When Form2 is closed, show Form1 again
            this.Show();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of Form2
            login login = new login();

            // Show Form2
            login.ShowDialog(); // Use Show() instead of ShowDialog() if you don't want it to be modal

            // When Form2 is closed, show Form1 again
            this.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = comboBox1.SelectedItem as string;
            if (selectedValue != null)
            {
                ClearDataGrid();
                GetData(selectedValue);
            }

        }



    }
}
