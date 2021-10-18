
namespace Vehiculos
{
    partial class frmVehiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabNewVehiculo = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.TextBoxTypeCard = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxColorCar = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxYearCar = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxModelCar = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxBrandCar = new MetroFramework.Controls.MetroTextBox();
            this.TextBoxIdCar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelTypeCar = new MetroFramework.Controls.MetroLabel();
            this.metroLabelColorCar = new MetroFramework.Controls.MetroLabel();
            this.metroLabelYearCar = new MetroFramework.Controls.MetroLabel();
            this.metroLabelModelCar = new MetroFramework.Controls.MetroLabel();
            this.metroLabelBrandCar = new MetroFramework.Controls.MetroLabel();
            this.metroLabelIdCar = new MetroFramework.Controls.MetroLabel();
            this.tabRegistrosVehiculos = new MetroFramework.Controls.MetroTabPage();
            this.dataGridViewRegistrosVehiculos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLinkNuevoVehiculo = new MetroFramework.Controls.MetroLink();
            this.metroTabControl.SuspendLayout();
            this.tabNewVehiculo.SuspendLayout();
            this.tabRegistrosVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.tabNewVehiculo);
            this.metroTabControl.Controls.Add(this.tabRegistrosVehiculos);
            this.metroTabControl.Location = new System.Drawing.Point(23, 86);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(754, 552);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            // 
            // tabNewVehiculo
            // 
            this.tabNewVehiculo.Controls.Add(this.label1);
            this.tabNewVehiculo.Controls.Add(this.btnCancelar);
            this.tabNewVehiculo.Controls.Add(this.btnRegistrar);
            this.tabNewVehiculo.Controls.Add(this.TextBoxTypeCard);
            this.tabNewVehiculo.Controls.Add(this.TextBoxColorCar);
            this.tabNewVehiculo.Controls.Add(this.TextBoxYearCar);
            this.tabNewVehiculo.Controls.Add(this.TextBoxModelCar);
            this.tabNewVehiculo.Controls.Add(this.TextBoxBrandCar);
            this.tabNewVehiculo.Controls.Add(this.TextBoxIdCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelTypeCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelColorCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelYearCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelModelCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelBrandCar);
            this.tabNewVehiculo.Controls.Add(this.metroLabelIdCar);
            this.tabNewVehiculo.HorizontalScrollbarBarColor = true;
            this.tabNewVehiculo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabNewVehiculo.HorizontalScrollbarSize = 10;
            this.tabNewVehiculo.Location = new System.Drawing.Point(4, 38);
            this.tabNewVehiculo.Name = "tabNewVehiculo";
            this.tabNewVehiculo.Size = new System.Drawing.Size(746, 510);
            this.tabNewVehiculo.TabIndex = 0;
            this.tabNewVehiculo.Text = "Nuevo Vehiculo";
            this.tabNewVehiculo.VerticalScrollbarBarColor = true;
            this.tabNewVehiculo.VerticalScrollbarHighlightOnWheel = false;
            this.tabNewVehiculo.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Garaje de César Martinez";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(608, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 47);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseCustomBackColor = true;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrar.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnRegistrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(608, 197);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 47);
            this.btnRegistrar.Style = MetroFramework.MetroColorStyle.White;
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCustomBackColor = true;
            this.btnRegistrar.UseSelectable = true;
            this.btnRegistrar.UseStyleColors = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // TextBoxTypeCard
            // 
            // 
            // 
            // 
            this.TextBoxTypeCard.CustomButton.Image = null;
            this.TextBoxTypeCard.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.TextBoxTypeCard.CustomButton.Name = "";
            this.TextBoxTypeCard.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxTypeCard.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxTypeCard.CustomButton.TabIndex = 1;
            this.TextBoxTypeCard.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxTypeCard.CustomButton.UseSelectable = true;
            this.TextBoxTypeCard.CustomButton.Visible = false;
            this.TextBoxTypeCard.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxTypeCard.Lines = new string[0];
            this.TextBoxTypeCard.Location = new System.Drawing.Point(199, 442);
            this.TextBoxTypeCard.MaxLength = 32767;
            this.TextBoxTypeCard.Name = "TextBoxTypeCard";
            this.TextBoxTypeCard.PasswordChar = '\0';
            this.TextBoxTypeCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxTypeCard.SelectedText = "";
            this.TextBoxTypeCard.SelectionLength = 0;
            this.TextBoxTypeCard.SelectionStart = 0;
            this.TextBoxTypeCard.ShortcutsEnabled = true;
            this.TextBoxTypeCard.Size = new System.Drawing.Size(280, 23);
            this.TextBoxTypeCard.TabIndex = 13;
            this.TextBoxTypeCard.UseSelectable = true;
            this.TextBoxTypeCard.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxTypeCard.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxColorCar
            // 
            // 
            // 
            // 
            this.TextBoxColorCar.CustomButton.Image = null;
            this.TextBoxColorCar.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.TextBoxColorCar.CustomButton.Name = "";
            this.TextBoxColorCar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxColorCar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxColorCar.CustomButton.TabIndex = 1;
            this.TextBoxColorCar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxColorCar.CustomButton.UseSelectable = true;
            this.TextBoxColorCar.CustomButton.Visible = false;
            this.TextBoxColorCar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxColorCar.Lines = new string[0];
            this.TextBoxColorCar.Location = new System.Drawing.Point(199, 375);
            this.TextBoxColorCar.MaxLength = 32767;
            this.TextBoxColorCar.Name = "TextBoxColorCar";
            this.TextBoxColorCar.PasswordChar = '\0';
            this.TextBoxColorCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxColorCar.SelectedText = "";
            this.TextBoxColorCar.SelectionLength = 0;
            this.TextBoxColorCar.SelectionStart = 0;
            this.TextBoxColorCar.ShortcutsEnabled = true;
            this.TextBoxColorCar.Size = new System.Drawing.Size(280, 23);
            this.TextBoxColorCar.TabIndex = 12;
            this.TextBoxColorCar.UseSelectable = true;
            this.TextBoxColorCar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxColorCar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxYearCar
            // 
            // 
            // 
            // 
            this.TextBoxYearCar.CustomButton.Image = null;
            this.TextBoxYearCar.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.TextBoxYearCar.CustomButton.Name = "";
            this.TextBoxYearCar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxYearCar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxYearCar.CustomButton.TabIndex = 1;
            this.TextBoxYearCar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxYearCar.CustomButton.UseSelectable = true;
            this.TextBoxYearCar.CustomButton.Visible = false;
            this.TextBoxYearCar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxYearCar.Lines = new string[0];
            this.TextBoxYearCar.Location = new System.Drawing.Point(199, 307);
            this.TextBoxYearCar.MaxLength = 32767;
            this.TextBoxYearCar.Name = "TextBoxYearCar";
            this.TextBoxYearCar.PasswordChar = '\0';
            this.TextBoxYearCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxYearCar.SelectedText = "";
            this.TextBoxYearCar.SelectionLength = 0;
            this.TextBoxYearCar.SelectionStart = 0;
            this.TextBoxYearCar.ShortcutsEnabled = true;
            this.TextBoxYearCar.Size = new System.Drawing.Size(140, 23);
            this.TextBoxYearCar.TabIndex = 11;
            this.TextBoxYearCar.UseSelectable = true;
            this.TextBoxYearCar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxYearCar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxModelCar
            // 
            // 
            // 
            // 
            this.TextBoxModelCar.CustomButton.Image = null;
            this.TextBoxModelCar.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.TextBoxModelCar.CustomButton.Name = "";
            this.TextBoxModelCar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxModelCar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxModelCar.CustomButton.TabIndex = 1;
            this.TextBoxModelCar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxModelCar.CustomButton.UseSelectable = true;
            this.TextBoxModelCar.CustomButton.Visible = false;
            this.TextBoxModelCar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxModelCar.Lines = new string[0];
            this.TextBoxModelCar.Location = new System.Drawing.Point(199, 244);
            this.TextBoxModelCar.MaxLength = 32767;
            this.TextBoxModelCar.Name = "TextBoxModelCar";
            this.TextBoxModelCar.PasswordChar = '\0';
            this.TextBoxModelCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxModelCar.SelectedText = "";
            this.TextBoxModelCar.SelectionLength = 0;
            this.TextBoxModelCar.SelectionStart = 0;
            this.TextBoxModelCar.ShortcutsEnabled = true;
            this.TextBoxModelCar.Size = new System.Drawing.Size(280, 23);
            this.TextBoxModelCar.TabIndex = 10;
            this.TextBoxModelCar.UseSelectable = true;
            this.TextBoxModelCar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxModelCar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxBrandCar
            // 
            // 
            // 
            // 
            this.TextBoxBrandCar.CustomButton.Image = null;
            this.TextBoxBrandCar.CustomButton.Location = new System.Drawing.Point(258, 1);
            this.TextBoxBrandCar.CustomButton.Name = "";
            this.TextBoxBrandCar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxBrandCar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxBrandCar.CustomButton.TabIndex = 1;
            this.TextBoxBrandCar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxBrandCar.CustomButton.UseSelectable = true;
            this.TextBoxBrandCar.CustomButton.Visible = false;
            this.TextBoxBrandCar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxBrandCar.Lines = new string[0];
            this.TextBoxBrandCar.Location = new System.Drawing.Point(199, 177);
            this.TextBoxBrandCar.MaxLength = 32767;
            this.TextBoxBrandCar.Name = "TextBoxBrandCar";
            this.TextBoxBrandCar.PasswordChar = '\0';
            this.TextBoxBrandCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxBrandCar.SelectedText = "";
            this.TextBoxBrandCar.SelectionLength = 0;
            this.TextBoxBrandCar.SelectionStart = 0;
            this.TextBoxBrandCar.ShortcutsEnabled = true;
            this.TextBoxBrandCar.Size = new System.Drawing.Size(280, 23);
            this.TextBoxBrandCar.TabIndex = 9;
            this.TextBoxBrandCar.UseSelectable = true;
            this.TextBoxBrandCar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxBrandCar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBoxIdCar
            // 
            // 
            // 
            // 
            this.TextBoxIdCar.CustomButton.Image = null;
            this.TextBoxIdCar.CustomButton.Location = new System.Drawing.Point(118, 1);
            this.TextBoxIdCar.CustomButton.Name = "";
            this.TextBoxIdCar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBoxIdCar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBoxIdCar.CustomButton.TabIndex = 1;
            this.TextBoxIdCar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBoxIdCar.CustomButton.UseSelectable = true;
            this.TextBoxIdCar.CustomButton.Visible = false;
            this.TextBoxIdCar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBoxIdCar.Lines = new string[0];
            this.TextBoxIdCar.Location = new System.Drawing.Point(199, 108);
            this.TextBoxIdCar.MaxLength = 32767;
            this.TextBoxIdCar.Name = "TextBoxIdCar";
            this.TextBoxIdCar.PasswordChar = '\0';
            this.TextBoxIdCar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBoxIdCar.SelectedText = "";
            this.TextBoxIdCar.SelectionLength = 0;
            this.TextBoxIdCar.SelectionStart = 0;
            this.TextBoxIdCar.ShortcutsEnabled = true;
            this.TextBoxIdCar.Size = new System.Drawing.Size(140, 23);
            this.TextBoxIdCar.TabIndex = 8;
            this.TextBoxIdCar.UseSelectable = true;
            this.TextBoxIdCar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBoxIdCar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabelTypeCar
            // 
            this.metroLabelTypeCar.AutoSize = true;
            this.metroLabelTypeCar.Location = new System.Drawing.Point(59, 442);
            this.metroLabelTypeCar.Name = "metroLabelTypeCar";
            this.metroLabelTypeCar.Size = new System.Drawing.Size(39, 20);
            this.metroLabelTypeCar.TabIndex = 7;
            this.metroLabelTypeCar.Text = "Tipo:";
            // 
            // metroLabelColorCar
            // 
            this.metroLabelColorCar.AutoSize = true;
            this.metroLabelColorCar.Location = new System.Drawing.Point(59, 375);
            this.metroLabelColorCar.Name = "metroLabelColorCar";
            this.metroLabelColorCar.Size = new System.Drawing.Size(46, 20);
            this.metroLabelColorCar.TabIndex = 6;
            this.metroLabelColorCar.Text = "Color:";
            // 
            // metroLabelYearCar
            // 
            this.metroLabelYearCar.AutoSize = true;
            this.metroLabelYearCar.Location = new System.Drawing.Point(59, 307);
            this.metroLabelYearCar.Name = "metroLabelYearCar";
            this.metroLabelYearCar.Size = new System.Drawing.Size(37, 20);
            this.metroLabelYearCar.TabIndex = 5;
            this.metroLabelYearCar.Text = "Año:";
            // 
            // metroLabelModelCar
            // 
            this.metroLabelModelCar.AutoSize = true;
            this.metroLabelModelCar.Location = new System.Drawing.Point(59, 244);
            this.metroLabelModelCar.Name = "metroLabelModelCar";
            this.metroLabelModelCar.Size = new System.Drawing.Size(59, 20);
            this.metroLabelModelCar.TabIndex = 4;
            this.metroLabelModelCar.Text = "Modelo:";
            // 
            // metroLabelBrandCar
            // 
            this.metroLabelBrandCar.AutoSize = true;
            this.metroLabelBrandCar.Location = new System.Drawing.Point(59, 180);
            this.metroLabelBrandCar.Name = "metroLabelBrandCar";
            this.metroLabelBrandCar.Size = new System.Drawing.Size(50, 20);
            this.metroLabelBrandCar.TabIndex = 3;
            this.metroLabelBrandCar.Text = "Marca:";
            // 
            // metroLabelIdCar
            // 
            this.metroLabelIdCar.AutoSize = true;
            this.metroLabelIdCar.Location = new System.Drawing.Point(59, 111);
            this.metroLabelIdCar.Name = "metroLabelIdCar";
            this.metroLabelIdCar.Size = new System.Drawing.Size(83, 20);
            this.metroLabelIdCar.TabIndex = 2;
            this.metroLabelIdCar.Text = "N. Vehiculo:";
            // 
            // tabRegistrosVehiculos
            // 
            this.tabRegistrosVehiculos.Controls.Add(this.dataGridViewRegistrosVehiculos);
            this.tabRegistrosVehiculos.HorizontalScrollbarBarColor = true;
            this.tabRegistrosVehiculos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabRegistrosVehiculos.HorizontalScrollbarSize = 10;
            this.tabRegistrosVehiculos.Location = new System.Drawing.Point(4, 38);
            this.tabRegistrosVehiculos.Name = "tabRegistrosVehiculos";
            this.tabRegistrosVehiculos.Size = new System.Drawing.Size(746, 510);
            this.tabRegistrosVehiculos.TabIndex = 1;
            this.tabRegistrosVehiculos.Text = "Lista de Vehiculos";
            this.tabRegistrosVehiculos.VerticalScrollbarBarColor = true;
            this.tabRegistrosVehiculos.VerticalScrollbarHighlightOnWheel = false;
            this.tabRegistrosVehiculos.VerticalScrollbarSize = 10;
            // 
            // dataGridViewRegistrosVehiculos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistrosVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRegistrosVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRegistrosVehiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRegistrosVehiculos.Location = new System.Drawing.Point(29, 18);
            this.dataGridViewRegistrosVehiculos.Name = "dataGridViewRegistrosVehiculos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRegistrosVehiculos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRegistrosVehiculos.RowHeadersWidth = 51;
            this.dataGridViewRegistrosVehiculos.RowTemplate.Height = 24;
            this.dataGridViewRegistrosVehiculos.Size = new System.Drawing.Size(686, 457);
            this.dataGridViewRegistrosVehiculos.TabIndex = 2;
            this.dataGridViewRegistrosVehiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistrosVehiculos_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Crimson;
            this.btnSalir.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSalir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(638, 653);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 47);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.White;
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // metroLinkNuevoVehiculo
            // 
            this.metroLinkNuevoVehiculo.Location = new System.Drawing.Point(226, 26);
            this.metroLinkNuevoVehiculo.Name = "metroLinkNuevoVehiculo";
            this.metroLinkNuevoVehiculo.Size = new System.Drawing.Size(120, 23);
            this.metroLinkNuevoVehiculo.TabIndex = 16;
            this.metroLinkNuevoVehiculo.Text = "Nuevo Vehiculo";
            this.metroLinkNuevoVehiculo.UseSelectable = true;
            this.metroLinkNuevoVehiculo.Click += new System.EventHandler(this.metroLinkNuevoVehiculo_Click);
            // 
            // frmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 735);
            this.Controls.Add(this.metroLinkNuevoVehiculo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.metroTabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmVehiculo";
            this.Text = "Garaje Vehiculos";
            this.Load += new System.EventHandler(this.frmVehiculo_Load);
            this.metroTabControl.ResumeLayout(false);
            this.tabNewVehiculo.ResumeLayout(false);
            this.tabNewVehiculo.PerformLayout();
            this.tabRegistrosVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrosVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage tabNewVehiculo;
        private MetroFramework.Controls.MetroTabPage tabRegistrosVehiculos;
        private MetroFramework.Controls.MetroLabel metroLabelModelCar;
        private MetroFramework.Controls.MetroLabel metroLabelBrandCar;
        private MetroFramework.Controls.MetroLabel metroLabelIdCar;
        private MetroFramework.Controls.MetroTextBox TextBoxTypeCard;
        private MetroFramework.Controls.MetroTextBox TextBoxColorCar;
        private MetroFramework.Controls.MetroTextBox TextBoxYearCar;
        private MetroFramework.Controls.MetroTextBox TextBoxModelCar;
        private MetroFramework.Controls.MetroTextBox TextBoxBrandCar;
        private MetroFramework.Controls.MetroTextBox TextBoxIdCar;
        private MetroFramework.Controls.MetroLabel metroLabelTypeCar;
        private MetroFramework.Controls.MetroLabel metroLabelColorCar;
        private MetroFramework.Controls.MetroLabel metroLabelYearCar;
        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewRegistrosVehiculos;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink metroLinkNuevoVehiculo;
    }
}