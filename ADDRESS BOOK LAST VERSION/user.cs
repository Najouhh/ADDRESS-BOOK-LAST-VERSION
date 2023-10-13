using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDRESS_BOOK_LAST_VERSION
{
    public partial class user : Form
    {
        string file = @"C:\Users\najah\OneDrive\Skrivbord\test\test.txt";
        public user()
        {
            InitializeComponent();
            GetData();


        }

        private void user_Load(object sender, EventArgs e)
        {

        }
        public void GetData()
        {
            int counter = 0;
            string name = "";
            string gatuadress = "";
            string pnummer = "";
            string port = "";
            string telefon = "";
            string epost = "";

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
                        dataGridView1.Rows.Add(name, gatuadress, pnummer, port, telefon, epost);
                    }
                    counter++;
                    // försätt med andra persons data 
                    if (counter > 5)
                    {
                        counter = 0;
                    }
                }

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            string searchtext = searchbox.Text;
            string searchLower = searchtext.ToLower();

            if (!string.IsNullOrEmpty(searchtext))
            {
                SearchDataGrid(searchtext);
            }
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
    }

}

