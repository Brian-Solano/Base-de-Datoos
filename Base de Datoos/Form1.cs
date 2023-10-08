using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base_de_Datoos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using System;
            using System.Windows.Forms;

public partial class LoginForm : Form
        {
            public LoginForm()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Aquí es donde verificarías las credenciales del usuario.
                // Por ejemplo, podrías tener una base de datos de usuarios y contraseñas a la que accederías aquí.
                // Como este es solo un ejemplo, vamos a suponer que el nombre de usuario es "admin" y la contraseña es "password".

                if (username == "admin" && password == "password")
                {
                    MessageBox.Show("Inicio de sesión exitoso!");
                    // Aquí es donde manejarías un inicio de sesión exitoso, como abrir una nueva ventana.
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos!");
                    // Aquí es donde manejarías un inicio de sesión fallido, como limpiar las cajas de texto.
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
    }
}
