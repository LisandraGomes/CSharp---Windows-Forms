
namespace Calculadora_csharp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnmaismenos = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmultiplica = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndois = new System.Windows.Forms.Button();
            this.btnum = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnvirgula = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.lbresult = new System.Windows.Forms.Label();
            this.btnquadrado = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.93298F));
            this.tableLayoutPanel1.Controls.Add(this.btnmaismenos, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnigual, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnmais, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnmenos, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnmultiplica, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btndois, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnum, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btndividir, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnce, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnvirgula, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnzero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnquadrado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnmaismenos
            // 
            this.btnmaismenos.Location = new System.Drawing.Point(3, 295);
            this.btnmaismenos.Name = "btnmaismenos";
            this.btnmaismenos.Size = new System.Drawing.Size(87, 71);
            this.btnmaismenos.TabIndex = 18;
            this.btnmaismenos.Text = "+/-";
            this.btnmaismenos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmaismenos.UseVisualStyleBackColor = true;
            this.btnmaismenos.Click += new System.EventHandler(this.btnmaismenos_Click);
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(282, 295);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(88, 71);
            this.btnigual.TabIndex = 0;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btnmais
            // 
            this.btnmais.Location = new System.Drawing.Point(282, 222);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(88, 67);
            this.btnmais.TabIndex = 4;
            this.btnmais.Text = "+";
            this.btnmais.UseVisualStyleBackColor = true;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(282, 149);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(88, 67);
            this.btnmenos.TabIndex = 5;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnmultiplica
            // 
            this.btnmultiplica.Location = new System.Drawing.Point(282, 76);
            this.btnmultiplica.Name = "btnmultiplica";
            this.btnmultiplica.Size = new System.Drawing.Size(88, 67);
            this.btnmultiplica.TabIndex = 6;
            this.btnmultiplica.Text = "*";
            this.btnmultiplica.UseVisualStyleBackColor = true;
            this.btnmultiplica.Click += new System.EventHandler(this.btnmultiplica_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(3, 76);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(87, 67);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(96, 76);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(87, 67);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(189, 76);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(87, 67);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(3, 149);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(87, 67);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(96, 149);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(87, 67);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(189, 149);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(87, 67);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(3, 222);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(87, 67);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btndois
            // 
            this.btndois.Location = new System.Drawing.Point(96, 222);
            this.btndois.Name = "btndois";
            this.btndois.Size = new System.Drawing.Size(87, 67);
            this.btndois.TabIndex = 8;
            this.btndois.Text = "2";
            this.btndois.UseVisualStyleBackColor = true;
            this.btndois.Click += new System.EventHandler(this.btndois_Click);
            // 
            // btnum
            // 
            this.btnum.Location = new System.Drawing.Point(189, 222);
            this.btnum.Name = "btnum";
            this.btnum.Size = new System.Drawing.Size(87, 67);
            this.btnum.TabIndex = 3;
            this.btnum.Text = "1";
            this.btnum.UseVisualStyleBackColor = true;
            this.btnum.Click += new System.EventHandler(this.btnum_Click);
            // 
            // btndividir
            // 
            this.btndividir.Location = new System.Drawing.Point(282, 3);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(88, 67);
            this.btndividir.TabIndex = 7;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnc
            // 
            this.btnc.Location = new System.Drawing.Point(189, 3);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(87, 67);
            this.btnc.TabIndex = 16;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = true;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btnce
            // 
            this.btnce.Location = new System.Drawing.Point(96, 3);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(87, 67);
            this.btnce.TabIndex = 17;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = true;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnvirgula
            // 
            this.btnvirgula.Location = new System.Drawing.Point(189, 295);
            this.btnvirgula.Name = "btnvirgula";
            this.btnvirgula.Size = new System.Drawing.Size(87, 71);
            this.btnvirgula.TabIndex = 1;
            this.btnvirgula.Text = ",";
            this.btnvirgula.UseVisualStyleBackColor = true;
            this.btnvirgula.Click += new System.EventHandler(this.btnvirgula_Click);
            // 
            // btnzero
            // 
            this.btnzero.Location = new System.Drawing.Point(96, 295);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(87, 71);
            this.btnzero.TabIndex = 2;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.BackColor = System.Drawing.SystemColors.Window;
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb.Location = new System.Drawing.Point(15, 68);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(370, 102);
            this.tb.TabIndex = 1;
            this.tb.Text = "0";
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbresult
            // 
            this.lbresult.BackColor = System.Drawing.SystemColors.Window;
            this.lbresult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbresult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbresult.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbresult.Location = new System.Drawing.Point(15, 28);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(370, 37);
            this.lbresult.TabIndex = 3;
            this.lbresult.Text = "0";
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbresult.Click += new System.EventHandler(this.lbresult_Click);
            // 
            // btnquadrado
            // 
            this.btnquadrado.Location = new System.Drawing.Point(3, 3);
            this.btnquadrado.Name = "btnquadrado";
            this.btnquadrado.Size = new System.Drawing.Size(87, 67);
            this.btnquadrado.TabIndex = 19;
            this.btnquadrado.Text = "x(2)";
            this.btnquadrado.UseVisualStyleBackColor = true;
            this.btnquadrado.Click += new System.EventHandler(this.btnquadrado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora_csharp.Properties.Resources.fundo;
            this.ClientSize = new System.Drawing.Size(397, 557);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnvirgula;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmultiplica;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndois;
        private System.Windows.Forms.Button btnum;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnce;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Button btnmaismenos;
        private System.Windows.Forms.Button btnquadrado;
    }
}

