using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RisxPert
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows) { row.Cells[2].Value = textBox1.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            Analisis datos = new Analisis();

            foreach (DataGridViewRow row in dataGridView1.Rows) { row.Cells[2].Value = textBox1.Text; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Analisis R1 = new Analisis();
                analisisList.Add(R1);
                DataGridViewRow Fase1Rows = dataGridView1.Rows[i];
                analisisList[i].Analista = textBox1.Text;
                analisisList[i].Activo = Fase1Rows.Cells[1].Value?.ToString();
                analisisList[i].Riesgo = Fase1Rows.Cells[3].Value?.ToString();
                analisisList[i].Dano = Fase1Rows.Cells[4].Value?.ToString();
                
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView2.Rows.Count < dataGridView1.Rows.Count)
                {
                    dataGridView2.Rows.Add();
                }
                dataGridView2.Rows[i].Cells[0].Value = analisisList[i].Activo;
                dataGridView2.Rows[i].Cells[1].Value = analisisList[i].Riesgo;
                dataGridView2.Rows[i].Cells[2].Value = analisisList[i].Dano;
            }

        }
        public class Analisis
        {
            public string Analista { get; set; }
            public string Activo { get; set; }
            public string Riesgo { get; set; }
            public string Dano { get; set; }
            public string Clasificacion { get; set; }
            public int _id { get; set; }
            public int S { get; set; }
            public int F { get; set; }
            public int P { get; set; }
            public int A { get; set; }
            public int V { get; set; }
            public int E { get; set; }
            public int CR { get; set; }
            public int Pb { get; set; }
            public int ER { get; set; }
        }
        List<Analisis> analisisList = new List<Analisis>();

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cellValues = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if (e.ColumnIndex >= 3)
            {
                if (int.TryParse(cellValues.Value?.ToString(), out int numericValue))
                {
                    switch (numericValue)
                    {
                        case 1:
                            cellValues.Style.BackColor = Color.Lime;
                            break;
                        case 2:
                            cellValues.Style.BackColor = Color.LimeGreen;
                            break;
                        case 3:
                            cellValues.Style.BackColor = Color.Yellow;
                            break;
                        case 4:
                            cellValues.Style.BackColor = Color.Orange;
                            break;
                        case 5:
                            cellValues.Style.BackColor = Color.Red;
                            break;
                        default:
                            MessageBox.Show("Inserte valor entre 1 y 5.", "Valor no Válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow Fase2Rows = dataGridView2.Rows[i];
                analisisList[i].S = Convert.ToInt16(Fase2Rows.Cells[3].Value?.ToString());
                analisisList[i].F = Convert.ToInt16(Fase2Rows.Cells[4].Value?.ToString());
                analisisList[i].P = Convert.ToInt16(Fase2Rows.Cells[5].Value?.ToString());
                analisisList[i].A = Convert.ToInt16(Fase2Rows.Cells[6].Value?.ToString());
                analisisList[i].V = Convert.ToInt16(Fase2Rows.Cells[7].Value?.ToString());
                analisisList[i].E = Convert.ToInt16(Fase2Rows.Cells[8].Value?.ToString());
                if (dataGridView3.Rows.Count < dataGridView1.Rows.Count)
                {
                    dataGridView3.Rows.Add();
                }
                dataGridView3.Rows[i].Cells[0].Value= analisisList[i].Activo;
                dataGridView3.Rows[i].Cells[1].Value = analisisList[i].Riesgo;
                dataGridView3.Rows[i].Cells[2].Value = analisisList[i].Dano;
                int I = analisisList[i].F * analisisList[i].S;
                int D = analisisList[i].P * analisisList[i].E;
                analisisList[i].Pb = analisisList[i].A * analisisList[i].V;
                analisisList[i].CR = I + D;
                analisisList[i].ER = analisisList[i].Pb * analisisList[i].CR;
                dataGridView3.Rows[i].Cells[3].Value = analisisList[i].CR;
                dataGridView3.Rows[i].Cells[4].Value = analisisList[i].Pb;
                dataGridView3.Rows[i].Cells[5].Value = analisisList[i].ER;

                if (dataGridView4.Rows.Count < dataGridView1.Rows.Count)
                {
                    dataGridView4.Rows.Add();
                }
                dataGridView4.Rows[i].Cells[0].Value = analisisList[i].Activo;
                dataGridView4.Rows[i].Cells[1].Value = analisisList[i].Riesgo;
                dataGridView4.Rows[i].Cells[2].Value = analisisList[i].Dano;
                dataGridView4.Rows[i].Cells[3].Value = analisisList[i].ER;

                DataGridViewCell ERValue = dataGridView4.Rows[i].Cells[3];

                if (Convert.ToInt32(ERValue.Value) >= 2 && Convert.ToInt32(ERValue.Value) <= 250)
                {
                    analisisList[i].Clasificacion = "Muy Pequeño";
                    dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
                }
                else if (Convert.ToInt32(ERValue.Value) >= 251 && Convert.ToInt32(ERValue.Value) <= 500)
                {
                    analisisList[i].Clasificacion = "Pequeño";
                    dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
                }
                else if (Convert.ToInt32(ERValue.Value) >= 501 && Convert.ToInt32(ERValue.Value) <= 750)
                {
                    analisisList[i].Clasificacion = "Normal";
                    dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
                }
                else if (Convert.ToInt32(ERValue.Value) >= 751 && Convert.ToInt32(ERValue.Value) <= 1000)
                {
                    analisisList[i].Clasificacion = "Grande";
                    dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
                }
                else if (Convert.ToInt32(ERValue.Value) >= 1001 && Convert.ToInt32(ERValue.Value) <= 1250)
                {
                    analisisList[i].Clasificacion = "Elevado";
                    dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
                }
                else analisisList[i].Clasificacion = "";
                dataGridView4.Rows[i].Cells[4].Value = analisisList[i].Clasificacion;
            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}

