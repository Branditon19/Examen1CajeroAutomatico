namespace Examen1CajeroAutomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Para cambiar el color segun el saldo 

        private void limpiar()
        {
            txtUsuario.Text = " "; // cadena de texto vacia para que se limpie cuando se hace click en el boton limpiar
            txtmonto.Text = " ";
            lblSaldoActual.Text = "50000";
            lstHistorial.Items.Clear();
            lblError.Text = "";
            lblSaldoActual.BackColor = Color.White;
        }
        private void ColorEtiquetaSaldoActual()
        {
            double SaldoActual = double.Parse(lblSaldoActual.Text);

            if (SaldoActual >= 30000)
            {
                lblSaldoActual.BackColor = Color.Green;
            }

            else if (SaldoActual >= 10000 && SaldoActual <= 30000)
            {
                lblSaldoActual.BackColor = Color.Yellow;
            }
            else
            {
                lblSaldoActual.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double Saldo_actual = 50000;  //definir el saldo inicial
            lblSaldoActual.Text = Saldo_actual.ToString();  //convertir a cadena de texto
            ColorEtiquetaSaldoActual();
        }




        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string depositar_monto = txtmonto.Text; // Guarda el texto ingresado en txtMonto dentro de la variable depositar_monto.
            double depositar;

            if (double.TryParse(depositar_monto, out depositar))  //Verificar si el valor ingresado es un número válido
            {
                double Saldo_actual = double.Parse(lblSaldoActual.Text); //convierte el texto en un numero decimal
                Saldo_actual += depositar; //suma el valor de depositar a saldo actual

                lblSaldoActual.Text = Saldo_actual.ToString(); // convierte el # almacenado en un texto y asigna ese texto al lbl para que se muestre en la interfaz

                lstHistorial.Items.Add($"Deposito {depositar} \n -Saldo Actual {Saldo_actual}"); // se agregan comentario al list box.

                ColorEtiquetaSaldoActual();
            }
            else
            {
                lblError.Text = "Error! Ingrese un monto valido"; // etiqueta con error si no se cumple el if
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // se le asigna cerrar la app

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            double saldo_actual = double.Parse(lblSaldoActual.Text); //obtener el saldo actual desde la etiqueta
            lstHistorial.Items.Add(txtUsuario.Text + $" Su Saldo actual es  {saldo_actual}");
        }

        private void limpiarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lstHistorial.Items.Clear();
            

        }

        private void lblSaldoActual_Click(object sender, EventArgs e)
        {
            double etiqueta_color = double.Parse(lblSaldoActual.Text);

            if (etiqueta_color < 30000) ;

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {

            string monto_retirar = txtmonto.Text;  // Obtiene el texto ingresado por el usuario en la caja de texto txtmonto

            double retirar;// Declara una variable para almacenar el valor numérico del monto a retirar

            if (double.TryParse(monto_retirar, out retirar)) // Intenta convertir el texto ingresado a un número (double)
            {
                double saldo_actual = double.Parse(lblSaldoActual.Text); // Convierte el saldo actual mostrado en la etiqueta lblSaldoActual a un número

                if (retirar > 0 && retirar <= saldo_actual)// Verifica que el monto a retirar sea mayor que 0 y que no exceda el saldo actual
                {
                    saldo_actual -= retirar;// Resta el monto retirado al saldo actual

                    lblSaldoActual.Text = saldo_actual.ToString(); // Actualiza la etiqueta del saldo con el nuevo saldo
                    lstHistorial.Items.Add($"Retiro {retirar} \n -Saldo Actual {saldo_actual}");  // Agrega el retiro al historial de transacciones
                    lblError.Text = "";// Limpia cualquier mensaje de error anterior

                    ColorEtiquetaSaldoActual();
                }
                else
                {

                    lblError.Text = "Error: Monto insuficiente o inválido para retirar."; // Si el monto es mayor que el saldo o es inválido (negativo o cero), muestra un error
                }
            }
            else
            {

                lblError.Text = "Error: Ingrese un monto válido para retirar."; // Si el texto ingresado no es un número válido, muestra un mensaje de error
            }


        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK) ;
            {
                this.BackColor = colorDialog.Color;

            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // se cierra desde el menuStrip

        }

       
        

        }
    }

