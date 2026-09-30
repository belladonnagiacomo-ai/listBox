namespace listBox
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
            listBox1 = new ListBox();
            agg = new Button();
            rim = new Button();
            mod = new Button();
            txtAgg = new TextBox();
            aggEl = new Label();
            label1 = new Label();
            modEl = new Label();
            textBox1 = new TextBox();
            Salva = new Button();
            carica = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(45, 98);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 199);
            listBox1.TabIndex = 0;
            // 
            // agg
            // 
            agg.Location = new Point(390, 98);
            agg.Name = "agg";
            agg.Size = new Size(75, 23);
            agg.TabIndex = 1;
            agg.Text = "aggiungi";
            agg.UseVisualStyleBackColor = true;
            agg.Click += agg_Click;
            // 
            // rim
            // 
            rim.Location = new Point(258, 274);
            rim.Name = "rim";
            rim.Size = new Size(75, 23);
            rim.TabIndex = 2;
            rim.Text = "rimuovi";
            rim.UseVisualStyleBackColor = true;
            rim.Click += rim_Click;
            // 
            // mod
            // 
            mod.Location = new Point(390, 182);
            mod.Name = "mod";
            mod.Size = new Size(75, 23);
            mod.TabIndex = 3;
            mod.Text = "modifica";
            mod.UseVisualStyleBackColor = true;
            mod.Click += mod_Click;
            // 
            // txtAgg
            // 
            txtAgg.Location = new Point(258, 98);
            txtAgg.Name = "txtAgg";
            txtAgg.Size = new Size(126, 23);
            txtAgg.TabIndex = 4;
            txtAgg.TextChanged += textBox1_TextChanged;
            // 
            // aggEl
            // 
            aggEl.AutoSize = true;
            aggEl.Location = new Point(258, 80);
            aggEl.Name = "aggEl";
            aggEl.Size = new Size(126, 15);
            aggEl.TabIndex = 5;
            aggEl.Text = "Aggiungi un elemento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 80);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista elementi";
            // 
            // modEl
            // 
            modEl.AutoSize = true;
            modEl.Location = new Point(258, 164);
            modEl.Name = "modEl";
            modEl.Size = new Size(124, 15);
            modEl.TabIndex = 9;
            modEl.Text = "Modifica un elemento";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 8;
            // 
            // Salva
            // 
            Salva.Location = new Point(404, 274);
            Salva.Name = "Salva";
            Salva.Size = new Size(75, 23);
            Salva.TabIndex = 10;
            Salva.Text = "Salva";
            Salva.UseVisualStyleBackColor = true;
            Salva.Click += Salva_Click;
            // 
            // carica
            // 
            carica.Location = new Point(333, 245);
            carica.Name = "carica";
            carica.Size = new Size(75, 23);
            carica.TabIndex = 11;
            carica.Text = "Carica file";
            carica.UseVisualStyleBackColor = true;
            carica.Click += carica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 646);
            Controls.Add(carica);
            Controls.Add(Salva);
            Controls.Add(modEl);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(aggEl);
            Controls.Add(txtAgg);
            Controls.Add(mod);
            Controls.Add(rim);
            Controls.Add(agg);
            Controls.Add(listBox1);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button agg;
        private Button rim;
        private Button mod;
        private TextBox txtAgg;
        private Label aggEl;
        private Label label1;
        private Label modEl;
        private TextBox textBox1;
        private Button Salva;
        private Button carica;
    }
}
