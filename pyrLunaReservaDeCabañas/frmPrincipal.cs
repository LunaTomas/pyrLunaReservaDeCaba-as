namespace pyrLunaReservaDeCabañas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()

        {
            InitializeComponent();
        }
        private void ActualizarPersonas(string tipo)// actualiza las opciones de personas según el tipo de cabaña
        {
            cmbPersonas.Items.Clear(); // limpia las opciones

            int max = (tipo == "A") ? 4 : 8; // si es A 4, sino 8

            for (int i = 1; i <= max; i++)
                cmbPersonas.Items.Add(i);

            cmbPersonas.SelectedIndex = 0; // selecciona el primero (1)
        }
        private void ValidarAceptar() // habilita o deshabilita el botón Aceptar
        {
            int dias;
            bool diasValidos = int.TryParse(mskDias.Text, out dias) && dias > 0;

            bool nombreValido = !string.IsNullOrWhiteSpace(txtNombre.Text);
            bool telValido = !string.IsNullOrWhiteSpace(mskTelefonos.Text);

            btnAceptar.Enabled = diasValidos && nombreValido && telValido;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            {
                mskDias.Focus();
                // Tipo de cabaña por defecto
                cmbTipo.Items.AddRange(new string[] { "Tipo A (4 max)", "Tipo B (8 max)" });
                cmbTipo.SelectedIndex = 0;
                ActualizarPersonas("A");

                // Personas por defecto (tipo A)
                cmbPersonas.SelectedIndex = 0;

                // Días inicial
                mskDias.Text = "1";

                // Adicionales vacíos
                chkAdicionales.Items.AddRange(new string[] { "Cocina", "Heladera", "Televisión" });
                for (int i = 0; i < chkAdicionales.Items.Count; i++)
                    chkAdicionales.SetItemChecked(i, false);

                // Forma de pago
                rdbEfectivo.Checked = true;
                rdbTarjeta.Checked = false;

                cmbTarjetas.Items.AddRange(new string[] { "Card Red", "Card Green", "Card Blue" });
                cmbTarjetas.Enabled = false;
                cmbTarjetas.SelectedIndex = -1;

                // Datos del titular
                txtNombre.Text = "";
                mskTelefonos.Text = "";

                // Botón aceptar deshabilitado
                btnAceptar.Enabled = false;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem.ToString();
            ActualizarPersonas(tipo);
        }

        private void rdbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTarjeta.Checked)
            {
                cmbTarjetas.Enabled = true;
                cmbTarjetas.SelectedIndex = 0; // Card Red por defecto
            }
            else
            {
                cmbTarjetas.Enabled = false;
                cmbTarjetas.SelectedIndex = -1;
            }
        }

        private void mskDias_TextChanged(object sender, EventArgs e)
        {
            ValidarAceptar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarAceptar();
        }

        private void mskTelefonos_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            ValidarAceptar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Obtener datos de la reserva
            string tipo = cmbTipo.SelectedItem.ToString();
            int personas = int.Parse(cmbPersonas.SelectedItem.ToString());
            int dias = int.Parse(mskDias.Text);

            //Calcular precio base + personas
            double precioBase = (tipo == "Tipo A (4 max)") ? 20 : 34;
            double costoDiario = precioBase + personas; // +1 por persona

            //Sumar adicionales
            foreach (var item in chkAdicionales.CheckedItems)
            {
                if (item.ToString() == "Cocina") costoDiario += 1;
                if (item.ToString() == "Heladera") costoDiario += 1.5;
                if (item.ToString() == "Televisión") costoDiario += 2;
            }

            //Calcular total por días
            double total = costoDiario * dias;

            //Aplicar recargo si es tarjeta
            if (rdbTarjeta.Checked && cmbTarjetas.SelectedIndex != -1)
            {
                string tarjeta = cmbTarjetas.SelectedItem.ToString();
                if (tarjeta == "Card Red")
                    total *= 1.10; // +10%
                else
                    total *= 1.20; // +20%
            }

            //Mostrar resultado en cuadro de diálogo
            MessageBox.Show($"Costo total de la reserva: US$ {total:F2}", "Reserva confirmada");

            //Volver al estado inicial
            frmPrincipal_Load(sender, e);
        }
    }
}
