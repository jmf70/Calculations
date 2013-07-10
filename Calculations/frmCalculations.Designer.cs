namespace Calculations
{
    partial class frmCalculations
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFactorial1 = new System.Windows.Forms.Label();
            this.lblFactorial2 = new System.Windows.Forms.Label();
            this.lblAddTwo = new System.Windows.Forms.Label();
            this.lblRunLoops = new System.Windows.Forms.Label();
            this.lblTotalCalculations = new System.Windows.Forms.Label();
            this.btnFactorial1 = new System.Windows.Forms.Button();
            this.btnFactorial2 = new System.Windows.Forms.Button();
            this.btnAddTwo = new System.Windows.Forms.Button();
            this.btnRunLoops = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFactorial1
            // 
            this.lblFactorial1.AutoSize = true;
            this.lblFactorial1.Location = new System.Drawing.Point(27, 36);
            this.lblFactorial1.Name = "lblFactorial1";
            this.lblFactorial1.Size = new System.Drawing.Size(0, 13);
            this.lblFactorial1.TabIndex = 0;
            // 
            // lblFactorial2
            // 
            this.lblFactorial2.AutoSize = true;
            this.lblFactorial2.Location = new System.Drawing.Point(27, 66);
            this.lblFactorial2.Name = "lblFactorial2";
            this.lblFactorial2.Size = new System.Drawing.Size(0, 13);
            this.lblFactorial2.TabIndex = 1;
            // 
            // lblAddTwo
            // 
            this.lblAddTwo.AutoSize = true;
            this.lblAddTwo.Location = new System.Drawing.Point(27, 96);
            this.lblAddTwo.Name = "lblAddTwo";
            this.lblAddTwo.Size = new System.Drawing.Size(0, 13);
            this.lblAddTwo.TabIndex = 2;
            // 
            // lblRunLoops
            // 
            this.lblRunLoops.AutoSize = true;
            this.lblRunLoops.Location = new System.Drawing.Point(27, 126);
            this.lblRunLoops.Name = "lblRunLoops";
            this.lblRunLoops.Size = new System.Drawing.Size(0, 13);
            this.lblRunLoops.TabIndex = 3;
            // 
            // lblTotalCalculations
            // 
            this.lblTotalCalculations.AutoSize = true;
            this.lblTotalCalculations.Location = new System.Drawing.Point(27, 156);
            this.lblTotalCalculations.Name = "lblTotalCalculations";
            this.lblTotalCalculations.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCalculations.TabIndex = 4;
            // 
            // btnFactorial1
            // 
            this.btnFactorial1.Location = new System.Drawing.Point(182, 31);
            this.btnFactorial1.Name = "btnFactorial1";
            this.btnFactorial1.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial1.TabIndex = 5;
            this.btnFactorial1.Text = "Factorial";
            this.btnFactorial1.UseVisualStyleBackColor = true;
            this.btnFactorial1.Click += new System.EventHandler(this.btnFactorial1_Click);
            // 
            // btnFactorial2
            // 
            this.btnFactorial2.Location = new System.Drawing.Point(182, 61);
            this.btnFactorial2.Name = "btnFactorial2";
            this.btnFactorial2.Size = new System.Drawing.Size(75, 23);
            this.btnFactorial2.TabIndex = 6;
            this.btnFactorial2.Text = "Factorial -1";
            this.btnFactorial2.UseVisualStyleBackColor = true;
            this.btnFactorial2.Click += new System.EventHandler(this.btnFactorial2_Click);
            // 
            // btnAddTwo
            // 
            this.btnAddTwo.Location = new System.Drawing.Point(182, 91);
            this.btnAddTwo.Name = "btnAddTwo";
            this.btnAddTwo.Size = new System.Drawing.Size(75, 23);
            this.btnAddTwo.TabIndex = 7;
            this.btnAddTwo.Text = "Add Two";
            this.btnAddTwo.UseVisualStyleBackColor = true;
            this.btnAddTwo.Click += new System.EventHandler(this.btnAddTwo_Click);
            // 
            // btnRunLoops
            // 
            this.btnRunLoops.Location = new System.Drawing.Point(182, 121);
            this.btnRunLoops.Name = "btnRunLoops";
            this.btnRunLoops.Size = new System.Drawing.Size(75, 23);
            this.btnRunLoops.TabIndex = 8;
            this.btnRunLoops.Text = "Run a Loop";
            this.btnRunLoops.UseVisualStyleBackColor = true;
            this.btnRunLoops.Click += new System.EventHandler(this.btnRunLoops_Click);
            // 
            // txtValue
            // 
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Location = new System.Drawing.Point(30, 171);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 9;
            // 
            // frmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 231);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnRunLoops);
            this.Controls.Add(this.btnAddTwo);
            this.Controls.Add(this.btnFactorial2);
            this.Controls.Add(this.btnFactorial1);
            this.Controls.Add(this.lblTotalCalculations);
            this.Controls.Add(this.lblRunLoops);
            this.Controls.Add(this.lblAddTwo);
            this.Controls.Add(this.lblFactorial2);
            this.Controls.Add(this.lblFactorial1);
            this.Name = "frmCalculations";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFactorial1;
        private System.Windows.Forms.Label lblFactorial2;
        private System.Windows.Forms.Label lblAddTwo;
        private System.Windows.Forms.Label lblRunLoops;
        private System.Windows.Forms.Label lblTotalCalculations;
        private System.Windows.Forms.Button btnFactorial1;
        private System.Windows.Forms.Button btnFactorial2;
        private System.Windows.Forms.Button btnAddTwo;
        private System.Windows.Forms.Button btnRunLoops;
        private System.Windows.Forms.TextBox txtValue;
    }
}

