
namespace Vehiculos
{
    partial class frmTest
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
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.AutoSize = true;
            this.btnTest.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnTest.Location = new System.Drawing.Point(138, 72);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(159, 63);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 213);
            this.Controls.Add(this.btnTest);
            this.Name = "frmTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test de BD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTest;
    }
}