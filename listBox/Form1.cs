namespace listBox
{
    public partial class Form1 : Form
    {
        List<string> origineD = new List<string>();
        public Form1()
        {
            InitializeComponent();
            origineD.Add("cane");
            origineD.Add("lupo");
            origineD.Add("gatto");
            origineD.Add("leone");
            origineD.Add("gallina");
            origineD.Add("giraffa");
            origineD.Add("coniglio");
            origineD.Add("pollo");
            origineD.Add("piccione");
            origineD.Add("lumaca");
            aggiorna();
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
            listBox1.Items.Clear();
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


        private void mod_Click(object sender, EventArgs e)
        {

        }
    }
}
