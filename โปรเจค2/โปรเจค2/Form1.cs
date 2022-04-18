namespace โปรเจค2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Menu.SelectedItem.ToString() == "Latte")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (Menu.SelectedItem.ToString() == "Mocha")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
            if (Menu.SelectedItem.ToString() == "Capuccino")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 40).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 45).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quanitycombo.Text) * 35).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idtext.Text = " ";
            Menu.Text = " ";
            typecombo.Text = " ";
            quanitycombo.Text = " ";
            paytext.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(idtext.Text, Menu.Text, typecombo.Text, quanitycombo.Text, paytext.Text);
            bill.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                loadProductFromFile(file);
            }
        }

        private void loadProductFromFile(string Npath)
        {
            string[] lines = System.IO.File.ReadAllLines(Npath);
            if (lines.Length > 0)
            {
                string MLine = lines[0];
                string[] Ladels = MLine.Split(',');
                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                Name.HeaderText = Ladels[0];
                DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                Price.HeaderText = Ladels[1];
                DataGridViewCheckBoxColumn Select = new DataGridViewCheckBoxColumn();
                Select.HeaderText = Ladels[2];
                DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();
                Amount.HeaderText = "Amount";
                dataGridView1.Columns.Add(Name);
                dataGridView1.Columns.Add(Price);
                dataGridView1.Columns.Add(Select);
                dataGridView1.Columns.Add(Amount);

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2]);
                }
            }
        }
    } 
}