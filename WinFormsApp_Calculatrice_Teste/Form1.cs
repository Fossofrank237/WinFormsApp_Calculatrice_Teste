using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace WinFormsApp_Calculatrice_Teste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Méthode utilitaire pour convertir les entrées
        private bool TryGetValues(out double nb1, out double nb2)
        {
            nb1 = nb2 = 0;

            bool valid1 = double.TryParse(txtNb1.Text.Trim(), out nb1);
            bool valid2 = double.TryParse(txtNb2.Text.Trim(), out nb2);

            if (!valid1 || !valid2)
            {
                MessageBox.Show("Veuillez entrer deux nombres valides (ex : 2.5, -4, etc.).", "Erreur de saisie",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double nb1, out double nb2))
            {
                txtResult.Text = (nb1 + nb2).ToString();
            }
        }

        private void btnMoins_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double nb1, out double nb2))
            {
                txtResult.Text = (nb1 - nb2).ToString();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double nb1, out double nb2))
            {
                txtResult.Text = (nb1 * nb2).ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double nb1, out double nb2))
            {
                if (nb2 == 0)
                {
                    MessageBox.Show("Division par zéro impossible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtResult.Text = (nb1 / nb2).ToString();
            }
        }

        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            txtNb1.Text = "";
            txtNb2.Text = "";
            txtResult.Text = "";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (TryGetValues(out double nb1, out double nb2))
            {
                txtResult.Text = Math.Pow(nb1, nb2).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNb1.Text.Trim(), out double nb1))
            {
                if (nb1 < 0)
                {
                    MessageBox.Show("Impossible de calculer la racine carre d'un nombre negatif", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txtResult.Text = Math.Sqrt(nb1).ToString();
            }

            else
            {
                MessageBox.Show("Veuiller entrer un nombre valide dans le champ nombre 1", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEvaluer_Click(object sender, EventArgs e)
        {
            string expression = txtExpression.Text;

            try
            {
                var result = new DataTable().Compute(expression, null);
                txtResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Expression invalide : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
