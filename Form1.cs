using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            string txt1Value = txt1.Text;
            string txt2Value = txt2.Text;

            if (txt1Value == txt2Value)
            {
                // Revisar si ambas cajas de texto cumplen
                if (IsValidPassword(txt1Value))
                {
                    MessageBox.Show("Contraseñas iguales y válidas", "Validación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Las contraseñas no son válidas.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidPassword(string password)
        {
            // REGEX para corroborar contraseña
            var regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\w\d\s]).+$");
            return regex.IsMatch(password);
        }

    }
}
