
namespace kalkulator_graf
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.liczba_1 = new System.Windows.Forms.TextBox();
            this.liczba_2 = new System.Windows.Forms.TextBox();
            this.wynik = new System.Windows.Forms.TextBox();
            this.dodawanie = new System.Windows.Forms.Button();
            this.odejmowanie = new System.Windows.Forms.Button();
            this.mnozenie = new System.Windows.Forms.Button();
            this.dzielenie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liczba_1
            // 
            this.liczba_1.Location = new System.Drawing.Point(68, 102);
            this.liczba_1.Name = "liczba_1";
            this.liczba_1.Size = new System.Drawing.Size(100, 20);
            this.liczba_1.TabIndex = 0;
            this.liczba_1.TextChanged += new System.EventHandler(this.liczba_1_TextChanged);
            // 
            // liczba_2
            // 
            this.liczba_2.Location = new System.Drawing.Point(215, 102);
            this.liczba_2.Name = "liczba_2";
            this.liczba_2.Size = new System.Drawing.Size(100, 20);
            this.liczba_2.TabIndex = 1;
            this.liczba_2.TextChanged += new System.EventHandler(this.liczba_2_TextChanged);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(346, 102);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(100, 20);
            this.wynik.TabIndex = 2;
            this.wynik.TextChanged += new System.EventHandler(this.wynik_TextChanged);
            // 
            // dodawanie
            // 
            this.dodawanie.Location = new System.Drawing.Point(149, 128);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(75, 23);
            this.dodawanie.TabIndex = 3;
            this.dodawanie.Text = "+";
            this.dodawanie.UseVisualStyleBackColor = true;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // odejmowanie
            // 
            this.odejmowanie.Location = new System.Drawing.Point(149, 157);
            this.odejmowanie.Name = "odejmowanie";
            this.odejmowanie.Size = new System.Drawing.Size(75, 23);
            this.odejmowanie.TabIndex = 4;
            this.odejmowanie.Text = "-";
            this.odejmowanie.UseVisualStyleBackColor = true;
            this.odejmowanie.Click += new System.EventHandler(this.odejmowanie_Click);
            // 
            // mnozenie
            // 
            this.mnozenie.Location = new System.Drawing.Point(149, 186);
            this.mnozenie.Name = "mnozenie";
            this.mnozenie.Size = new System.Drawing.Size(75, 23);
            this.mnozenie.TabIndex = 5;
            this.mnozenie.Text = "*";
            this.mnozenie.UseVisualStyleBackColor = true;
            this.mnozenie.Click += new System.EventHandler(this.button3_Click);
            // 
            // dzielenie
            // 
            this.dzielenie.Location = new System.Drawing.Point(149, 215);
            this.dzielenie.Name = "dzielenie";
            this.dzielenie.Size = new System.Drawing.Size(75, 23);
            this.dzielenie.TabIndex = 6;
            this.dzielenie.Text = "/";
            this.dzielenie.UseVisualStyleBackColor = true;
            this.dzielenie.Click += new System.EventHandler(this.dzielenie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dzielenie);
            this.Controls.Add(this.mnozenie);
            this.Controls.Add(this.odejmowanie);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.liczba_2);
            this.Controls.Add(this.liczba_1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox liczba_1;
        private System.Windows.Forms.TextBox liczba_2;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.Button odejmowanie;
        private System.Windows.Forms.Button mnozenie;
        private System.Windows.Forms.Button dzielenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

