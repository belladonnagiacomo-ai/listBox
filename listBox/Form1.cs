namespace listBox
{
    public partial class Form1 : Form
    {
        List<string> origineD = new List<string>();
        string nomeFile;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void agg_Click(object sender, EventArgs e)
        {
            if (controlloStringa(txtAgg.Text) == false)
            {
                MessageBox.Show("La textBox è vuota");
            }
            else
            {
                string elemento = txtAgg.Text;
                elemento = elemento.Trim();
                elemento = elemento.ToLower();
                listBox1.Items.Add(elemento);
                origineD.Add(elemento);
                aggiorna();
            }
        }

        private void rim_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Non hai selezionato nessun elemento");
            }
            else
            {
                origineD.RemoveAt(indice);
                aggiorna();
            }

        }

        private void aggiorna()
        {
            listBox1.Items.Clear();
            foreach (string s in origineD)
            {
                listBox1.Items.Add(s);
            }
        }

        private bool controlloStringa(string x)
        {
            if (string.IsNullOrEmpty(x))
            {
                return false;
            }

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ' ')
                {
                    return true;
                }
            }
            return false;
        }

        private void caricaDati(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Il file non esiste");
            }
            else
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string riga = sr.ReadLine();
                        if (controlloStringa(riga) == true)
                        {
                            riga = riga.Trim();
                            riga = riga.ToLower();
                            origineD.Add(riga);
                        }
                    }
                }
            }

        }
        private void mod_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            if (indice == -1 || textBox1.Text == null)
            {
                MessageBox.Show("Non hai selezionato niente");
            }
            else
            {
                origineD[indice] = textBox1.Text;
                aggiorna();
            }
        }

        private void Salva_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(nomeFile, false))
            {
                foreach (string i in origineD)
                {
                    sw.WriteLine(i);
                }
            }
        }

        private void carica_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                nomeFile = ofd.FileName;
                caricaDati(nomeFile);
                aggiorna();
            }
            else
            {
                MessageBox.Show("Nessun file selezionato");
            }
        }
    }
}
