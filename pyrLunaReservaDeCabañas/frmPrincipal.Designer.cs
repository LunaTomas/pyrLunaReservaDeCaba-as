namespace pyrLunaReservaDeCabañas
{
    partial class frmPrincipal
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
            grpTipoDeCabaña = new GroupBox();
            mskDias = new MaskedTextBox();
            cmbPersonas = new ComboBox();
            cmbTipo = new ComboBox();
            lblDias = new Label();
            lblPersonas = new Label();
            lblTipo = new Label();
            grpAdicionales = new GroupBox();
            chkAdicionales = new CheckedListBox();
            grpFormaDePago = new GroupBox();
            cmbTarjetas = new ComboBox();
            lblTarjetas = new Label();
            rdbTarjeta = new RadioButton();
            rdbEfectivo = new RadioButton();
            grpTitularDeLaReserva = new GroupBox();
            mskTelefonos = new MaskedTextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            btnAceptar = new Button();
            grpTipoDeCabaña.SuspendLayout();
            grpAdicionales.SuspendLayout();
            grpFormaDePago.SuspendLayout();
            grpTitularDeLaReserva.SuspendLayout();
            SuspendLayout();
            // 
            // grpTipoDeCabaña
            // 
            grpTipoDeCabaña.Controls.Add(mskDias);
            grpTipoDeCabaña.Controls.Add(cmbPersonas);
            grpTipoDeCabaña.Controls.Add(cmbTipo);
            grpTipoDeCabaña.Controls.Add(lblDias);
            grpTipoDeCabaña.Controls.Add(lblPersonas);
            grpTipoDeCabaña.Controls.Add(lblTipo);
            grpTipoDeCabaña.Font = new Font("Segoe UI", 14.25F);
            grpTipoDeCabaña.Location = new Point(18, 15);
            grpTipoDeCabaña.Name = "grpTipoDeCabaña";
            grpTipoDeCabaña.Size = new Size(599, 100);
            grpTipoDeCabaña.TabIndex = 0;
            grpTipoDeCabaña.TabStop = false;
            grpTipoDeCabaña.Text = "Tipo de Cabaña";
            // 
            // mskDias
            // 
            mskDias.Location = new Point(540, 28);
            mskDias.Mask = "99999";
            mskDias.Name = "mskDias";
            mskDias.PromptChar = ' ';
            mskDias.Size = new Size(53, 33);
            mskDias.TabIndex = 2;
            mskDias.ValidatingType = typeof(int);
            mskDias.TextChanged += mskDias_TextChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersonas.FormattingEnabled = true;
            cmbPersonas.Location = new Point(359, 28);
            cmbPersonas.Name = "cmbPersonas";
            cmbPersonas.Size = new Size(121, 33);
            cmbPersonas.TabIndex = 1;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(65, 28);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(195, 33);
            cmbTipo.TabIndex = 0;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(486, 31);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(48, 25);
            lblDias.TabIndex = 5;
            lblDias.Text = "Días";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(266, 31);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(87, 25);
            lblPersonas.TabIndex = 4;
            lblPersonas.Text = "Personas";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(6, 31);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(49, 25);
            lblTipo.TabIndex = 3;
            lblTipo.Text = "Tipo";
            // 
            // grpAdicionales
            // 
            grpAdicionales.Controls.Add(chkAdicionales);
            grpAdicionales.Font = new Font("Segoe UI", 14.25F);
            grpAdicionales.Location = new Point(18, 121);
            grpAdicionales.Name = "grpAdicionales";
            grpAdicionales.Size = new Size(301, 139);
            grpAdicionales.TabIndex = 1;
            grpAdicionales.TabStop = false;
            grpAdicionales.Text = "Adicionales";
            // 
            // chkAdicionales
            // 
            chkAdicionales.FormattingEnabled = true;
            chkAdicionales.Items.AddRange(new object[] { "Cocina", "Heladera", "Televisor" });
            chkAdicionales.Location = new Point(6, 34);
            chkAdicionales.Name = "chkAdicionales";
            chkAdicionales.Size = new Size(120, 88);
            chkAdicionales.TabIndex = 0;
            // 
            // grpFormaDePago
            // 
            grpFormaDePago.Controls.Add(cmbTarjetas);
            grpFormaDePago.Controls.Add(lblTarjetas);
            grpFormaDePago.Controls.Add(rdbTarjeta);
            grpFormaDePago.Controls.Add(rdbEfectivo);
            grpFormaDePago.Font = new Font("Segoe UI", 14.25F);
            grpFormaDePago.Location = new Point(326, 121);
            grpFormaDePago.Name = "grpFormaDePago";
            grpFormaDePago.Size = new Size(291, 139);
            grpFormaDePago.TabIndex = 2;
            grpFormaDePago.TabStop = false;
            grpFormaDePago.Text = "Forma de Pago";
            // 
            // cmbTarjetas
            // 
            cmbTarjetas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarjetas.Font = new Font("Segoe UI", 15.75F);
            cmbTarjetas.FormattingEnabled = true;
            cmbTarjetas.Location = new Point(112, 95);
            cmbTarjetas.Name = "cmbTarjetas";
            cmbTarjetas.Size = new Size(173, 38);
            cmbTarjetas.TabIndex = 2;
            // 
            // lblTarjetas
            // 
            lblTarjetas.AutoSize = true;
            lblTarjetas.Location = new Point(112, 67);
            lblTarjetas.Name = "lblTarjetas";
            lblTarjetas.Size = new Size(76, 25);
            lblTarjetas.TabIndex = 3;
            lblTarjetas.Text = "Tarjetas";
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(6, 63);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(86, 29);
            rdbTarjeta.TabIndex = 1;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            rdbTarjeta.CheckedChanged += rdbTarjeta_CheckedChanged;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(6, 32);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(96, 29);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // grpTitularDeLaReserva
            // 
            grpTitularDeLaReserva.Controls.Add(mskTelefonos);
            grpTitularDeLaReserva.Controls.Add(txtNombre);
            grpTitularDeLaReserva.Controls.Add(lblTelefono);
            grpTitularDeLaReserva.Controls.Add(lblNombre);
            grpTitularDeLaReserva.Font = new Font("Segoe UI", 14.25F);
            grpTitularDeLaReserva.Location = new Point(18, 266);
            grpTitularDeLaReserva.Name = "grpTitularDeLaReserva";
            grpTitularDeLaReserva.Size = new Size(599, 108);
            grpTitularDeLaReserva.TabIndex = 3;
            grpTitularDeLaReserva.TabStop = false;
            grpTitularDeLaReserva.Text = "Titular de la Reserva";
            // 
            // mskTelefonos
            // 
            mskTelefonos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefonos.Location = new Point(104, 65);
            mskTelefonos.Mask = "(999)000-0000";
            mskTelefonos.Name = "mskTelefonos";
            mskTelefonos.PromptChar = ' ';
            mskTelefonos.Size = new Size(477, 33);
            mskTelefonos.TabIndex = 1;
            mskTelefonos.MaskInputRejected += mskTelefonos_MaskInputRejected_1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(477, 33);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(6, 68);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(84, 25);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14.25F);
            btnAceptar.Location = new Point(496, 380);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(121, 38);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 433);
            Controls.Add(btnAceptar);
            Controls.Add(grpTitularDeLaReserva);
            Controls.Add(grpFormaDePago);
            Controls.Add(grpAdicionales);
            Controls.Add(grpTipoDeCabaña);
            Name = "frmPrincipal";
            Text = "Reservas de Cabañas";
            Load += frmPrincipal_Load;
            grpTipoDeCabaña.ResumeLayout(false);
            grpTipoDeCabaña.PerformLayout();
            grpAdicionales.ResumeLayout(false);
            grpFormaDePago.ResumeLayout(false);
            grpFormaDePago.PerformLayout();
            grpTitularDeLaReserva.ResumeLayout(false);
            grpTitularDeLaReserva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpTipoDeCabaña;
        private GroupBox grpAdicionales;
        private GroupBox grpFormaDePago;
        private GroupBox grpTitularDeLaReserva;
        private MaskedTextBox mskDias;
        private ComboBox cmbPersonas;
        private ComboBox cmbTipo;
        private Label lblDias;
        private Label lblPersonas;
        private Label lblTipo;
        private CheckedListBox chkAdicionales;
        private ComboBox cmbTarjetas;
        private Label lblTarjetas;
        private RadioButton rdbTarjeta;
        private RadioButton rdbEfectivo;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblNombre;
        private Button btnAceptar;
        private MaskedTextBox mskTelefonos;
    }
}
