namespace Toets_2_klassen
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMaakFactuur = new Button();
            lstKlanten = new ListBox();
            maskedTextBox1 = new MaskedTextBox();
            txtfactuurID = new TextBox();
            txtNaamKlant = new TextBox();
            txtKlantNummer = new TextBox();
            txtPrijs = new TextBox();
            txtAantal = new TextBox();
            txtProduct = new TextBox();
            lstFacturen = new ListBox();
            btnFactuurLijn = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblFactuurTotaal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Factuur ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 112);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Naam klant:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 151);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Klant nummer:";
            // 
            // btnMaakFactuur
            // 
            btnMaakFactuur.Location = new Point(90, 210);
            btnMaakFactuur.Name = "btnMaakFactuur";
            btnMaakFactuur.Size = new Size(201, 33);
            btnMaakFactuur.TabIndex = 3;
            btnMaakFactuur.Text = "Maak factuur aan";
            btnMaakFactuur.UseVisualStyleBackColor = true;
            btnMaakFactuur.Click += btnMaakFactuur_Click;
            // 
            // lstKlanten
            // 
            lstKlanten.FormattingEnabled = true;
            lstKlanten.Location = new Point(90, 263);
            lstKlanten.Name = "lstKlanten";
            lstKlanten.Size = new Size(286, 184);
            lstKlanten.TabIndex = 4;
            lstKlanten.SelectedIndexChanged += lstKlanten_SelectedIndexChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(778, 435);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(10, 27);
            maskedTextBox1.TabIndex = 5;
            // 
            // txtfactuurID
            // 
            txtfactuurID.Location = new Point(195, 68);
            txtfactuurID.Name = "txtfactuurID";
            txtfactuurID.Size = new Size(125, 27);
            txtfactuurID.TabIndex = 6;
            // 
            // txtNaamKlant
            // 
            txtNaamKlant.Location = new Point(195, 109);
            txtNaamKlant.Name = "txtNaamKlant";
            txtNaamKlant.Size = new Size(125, 27);
            txtNaamKlant.TabIndex = 7;
            // 
            // txtKlantNummer
            // 
            txtKlantNummer.Location = new Point(195, 148);
            txtKlantNummer.Name = "txtKlantNummer";
            txtKlantNummer.Size = new Size(125, 27);
            txtKlantNummer.TabIndex = 8;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(528, 148);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(125, 27);
            txtPrijs.TabIndex = 16;
            // 
            // txtAantal
            // 
            txtAantal.Location = new Point(528, 109);
            txtAantal.Name = "txtAantal";
            txtAantal.Size = new Size(125, 27);
            txtAantal.TabIndex = 15;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(528, 68);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(125, 27);
            txtProduct.TabIndex = 14;
            // 
            // lstFacturen
            // 
            lstFacturen.FormattingEnabled = true;
            lstFacturen.Location = new Point(452, 263);
            lstFacturen.Name = "lstFacturen";
            lstFacturen.Size = new Size(320, 184);
            lstFacturen.TabIndex = 13;
            lstFacturen.SelectedIndexChanged += lstFacturen_SelectedIndexChanged;
            // 
            // btnFactuurLijn
            // 
            btnFactuurLijn.Location = new Point(452, 210);
            btnFactuurLijn.Name = "btnFactuurLijn";
            btnFactuurLijn.Size = new Size(201, 33);
            btnFactuurLijn.TabIndex = 12;
            btnFactuurLijn.Text = "Maak factuurlijn aan";
            btnFactuurLijn.UseVisualStyleBackColor = true;
            btnFactuurLijn.Click += btnFactuurLijn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 151);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 11;
            label4.Text = "Prijs:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(452, 112);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 10;
            label5.Text = "Aantal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(452, 71);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 9;
            label6.Text = "Product:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 25);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 17;
            label7.Text = "Factuur";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(452, 25);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 18;
            label8.Text = "Factuurlijn";
            // 
            // lblFactuurTotaal
            // 
            lblFactuurTotaal.AutoSize = true;
            lblFactuurTotaal.Location = new Point(90, 469);
            lblFactuurTotaal.Name = "lblFactuurTotaal";
            lblFactuurTotaal.Size = new Size(109, 20);
            lblFactuurTotaal.TabIndex = 19;
            lblFactuurTotaal.Text = "Factuurtotaal =";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(lblFactuurTotaal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtPrijs);
            Controls.Add(txtAantal);
            Controls.Add(txtProduct);
            Controls.Add(lstFacturen);
            Controls.Add(btnFactuurLijn);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtKlantNummer);
            Controls.Add(txtNaamKlant);
            Controls.Add(txtfactuurID);
            Controls.Add(maskedTextBox1);
            Controls.Add(lstKlanten);
            Controls.Add(btnMaakFactuur);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMaakFactuur;
        private ListBox lstKlanten;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtfactuurID;
        private TextBox txtNaamKlant;
        private TextBox txtKlantNummer;
        private TextBox txtPrijs;
        private TextBox txtAantal;
        private TextBox txtProduct;
        private ListBox lstFacturen;
        private Button btnFactuurLijn;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblFactuurTotaal;
    }
}
