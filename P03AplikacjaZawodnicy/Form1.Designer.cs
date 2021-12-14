
namespace P03AplikacjaZawodnicy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnStrona = new System.Windows.Forms.Button();
            this.chartZawodnicy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnWygenerujPodsumowanie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartZawodnicy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(22, 50);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(241, 225);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(22, 21);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(188, 21);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 23);
            this.btnPDF.TabIndex = 2;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(286, 50);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(237, 225);
            this.webBrowser1.TabIndex = 3;
            // 
            // btnStrona
            // 
            this.btnStrona.Location = new System.Drawing.Point(286, 21);
            this.btnStrona.Name = "btnStrona";
            this.btnStrona.Size = new System.Drawing.Size(237, 23);
            this.btnStrona.TabIndex = 4;
            this.btnStrona.Text = "Uruchom strone";
            this.btnStrona.UseVisualStyleBackColor = true;
            this.btnStrona.Click += new System.EventHandler(this.btnStrona_Click);
            // 
            // chartZawodnicy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartZawodnicy.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartZawodnicy.Legends.Add(legend1);
            this.chartZawodnicy.Location = new System.Drawing.Point(542, 50);
            this.chartZawodnicy.Name = "chartZawodnicy";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartZawodnicy.Series.Add(series1);
            this.chartZawodnicy.Size = new System.Drawing.Size(361, 225);
            this.chartZawodnicy.TabIndex = 5;
            this.chartZawodnicy.Text = "chart1";
            // 
            // btnWygenerujPodsumowanie
            // 
            this.btnWygenerujPodsumowanie.Location = new System.Drawing.Point(542, 21);
            this.btnWygenerujPodsumowanie.Name = "btnWygenerujPodsumowanie";
            this.btnWygenerujPodsumowanie.Size = new System.Drawing.Size(148, 23);
            this.btnWygenerujPodsumowanie.TabIndex = 6;
            this.btnWygenerujPodsumowanie.Text = "Wygeneruj wykres";
            this.btnWygenerujPodsumowanie.UseVisualStyleBackColor = true;
            this.btnWygenerujPodsumowanie.Click += new System.EventHandler(this.btnWygenerujPodsumowanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 298);
            this.Controls.Add(this.btnWygenerujPodsumowanie);
            this.Controls.Add(this.chartZawodnicy);
            this.Controls.Add(this.btnStrona);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartZawodnicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnStrona;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZawodnicy;
        private System.Windows.Forms.Button btnWygenerujPodsumowanie;
    }
}

