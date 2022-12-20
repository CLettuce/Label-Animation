namespace LabelMove
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
            this.moveL1 = new LabelMove.MoveL();
            this.SuspendLayout();
            // 
            // moveL1
            // 
            this.moveL1.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveL1.Location = new System.Drawing.Point(12, 165);
            this.moveL1.Name = "moveL1";
            this.moveL1.Size = new System.Drawing.Size(790, 113);
            this.moveL1.TabIndex = 0;
            this.moveL1.Text = "Movimiento de letra";
            this.moveL1.UseCompatibleTextRendering = true;
            this.moveL1.Velocidad_Text = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MoveL moveL1;
    }
}

