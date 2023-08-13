namespace Torres_de_Hanoi
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarDiscos = new System.Windows.Forms.TrackBar();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.groupBoxTorre1 = new System.Windows.Forms.GroupBox();
            this.groupBoxTorre2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTorre3 = new System.Windows.Forms.GroupBox();
            this.labelNumeroDeDiscos = new System.Windows.Forms.Label();
            this.labelMovimientos = new System.Windows.Forms.Label();
            this.labelMejor = new System.Windows.Forms.Label();
            this.labelGanador = new System.Windows.Forms.Label();
            this.buttonResolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarDiscos
            // 
            this.trackBarDiscos.Location = new System.Drawing.Point(140, 17);
            this.trackBarDiscos.Margin = new System.Windows.Forms.Padding(4);
            this.trackBarDiscos.Maximum = 13;
            this.trackBarDiscos.Minimum = 2;
            this.trackBarDiscos.Name = "trackBarDiscos";
            this.trackBarDiscos.Size = new System.Drawing.Size(378, 45);
            this.trackBarDiscos.TabIndex = 1;
            this.trackBarDiscos.Value = 2;
            this.trackBarDiscos.Scroll += new System.EventHandler(this.trackBarDiscos_Scroll);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReiniciar.Location = new System.Drawing.Point(18, 17);
            this.buttonReiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(112, 32);
            this.buttonReiniciar.TabIndex = 2;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // groupBoxTorre1
            // 
            this.groupBoxTorre1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTorre1.BackgroundImage = global::Torres_de_Hanoi.Properties.Resources.Recurso_1_2x;
            this.groupBoxTorre1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxTorre1.Location = new System.Drawing.Point(18, 144);
            this.groupBoxTorre1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre1.Name = "groupBoxTorre1";
            this.groupBoxTorre1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre1.Size = new System.Drawing.Size(375, 500);
            this.groupBoxTorre1.TabIndex = 3;
            this.groupBoxTorre1.TabStop = false;
            // 
            // groupBoxTorre2
            // 
            this.groupBoxTorre2.BackgroundImage = global::Torres_de_Hanoi.Properties.Resources.Recurso_1_2x;
            this.groupBoxTorre2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxTorre2.Location = new System.Drawing.Point(402, 144);
            this.groupBoxTorre2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre2.Name = "groupBoxTorre2";
            this.groupBoxTorre2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre2.Size = new System.Drawing.Size(375, 500);
            this.groupBoxTorre2.TabIndex = 4;
            this.groupBoxTorre2.TabStop = false;
            // 
            // groupBoxTorre3
            // 
            this.groupBoxTorre3.BackgroundImage = global::Torres_de_Hanoi.Properties.Resources.Recurso_1_2x;
            this.groupBoxTorre3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxTorre3.Location = new System.Drawing.Point(786, 144);
            this.groupBoxTorre3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre3.Name = "groupBoxTorre3";
            this.groupBoxTorre3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxTorre3.Size = new System.Drawing.Size(375, 500);
            this.groupBoxTorre3.TabIndex = 4;
            this.groupBoxTorre3.TabStop = false;
            // 
            // labelNumeroDeDiscos
            // 
            this.labelNumeroDeDiscos.AutoSize = true;
            this.labelNumeroDeDiscos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeDiscos.Location = new System.Drawing.Point(526, 17);
            this.labelNumeroDeDiscos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumeroDeDiscos.Name = "labelNumeroDeDiscos";
            this.labelNumeroDeDiscos.Size = new System.Drawing.Size(29, 32);
            this.labelNumeroDeDiscos.TabIndex = 5;
            this.labelNumeroDeDiscos.Text = "2";
            // 
            // labelMovimientos
            // 
            this.labelMovimientos.AutoSize = true;
            this.labelMovimientos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovimientos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMovimientos.Location = new System.Drawing.Point(749, 17);
            this.labelMovimientos.Name = "labelMovimientos";
            this.labelMovimientos.Size = new System.Drawing.Size(200, 32);
            this.labelMovimientos.TabIndex = 6;
            this.labelMovimientos.Text = "Movimientos: ";
            // 
            // labelMejor
            // 
            this.labelMejor.AutoSize = true;
            this.labelMejor.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMejor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelMejor.Location = new System.Drawing.Point(749, 58);
            this.labelMejor.Name = "labelMejor";
            this.labelMejor.Size = new System.Drawing.Size(104, 32);
            this.labelMejor.TabIndex = 7;
            this.labelMejor.Text = "Mejor: ";
            // 
            // labelGanador
            // 
            this.labelGanador.AutoSize = true;
            this.labelGanador.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGanador.ForeColor = System.Drawing.Color.Red;
            this.labelGanador.Location = new System.Drawing.Point(12, 108);
            this.labelGanador.Name = "labelGanador";
            this.labelGanador.Size = new System.Drawing.Size(127, 32);
            this.labelGanador.TabIndex = 8;
            this.labelGanador.Text = "Ganador";
            // 
            // buttonResolver
            // 
            this.buttonResolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResolver.Location = new System.Drawing.Point(18, 71);
            this.buttonResolver.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResolver.Name = "buttonResolver";
            this.buttonResolver.Size = new System.Drawing.Size(112, 32);
            this.buttonResolver.TabIndex = 9;
            this.buttonResolver.Text = "Resolver";
            this.buttonResolver.UseVisualStyleBackColor = true;
            this.buttonResolver.Visible = false;
            this.buttonResolver.Click += new System.EventHandler(this.buttonResolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.buttonResolver);
            this.Controls.Add(this.labelGanador);
            this.Controls.Add(this.labelMejor);
            this.Controls.Add(this.labelMovimientos);
            this.Controls.Add(this.labelNumeroDeDiscos);
            this.Controls.Add(this.groupBoxTorre3);
            this.Controls.Add(this.groupBoxTorre2);
            this.Controls.Add(this.groupBoxTorre1);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.trackBarDiscos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torres de Hanoi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarDiscos;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.GroupBox groupBoxTorre1;
        private System.Windows.Forms.GroupBox groupBoxTorre2;
        private System.Windows.Forms.GroupBox groupBoxTorre3;
        private System.Windows.Forms.Label labelNumeroDeDiscos;
        private System.Windows.Forms.Label labelMovimientos;
        private System.Windows.Forms.Label labelMejor;
        private System.Windows.Forms.Label labelGanador;
        private System.Windows.Forms.Button buttonResolver;
    }
}

