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

namespace Programa_de_Emergencia
{
    public partial class UserControl1: UserControl
    {
        private int currentQuestion = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        
        private void DisplayQuestion(int questionNumber)
        {
            if (questionNumber == 0)
            {
                lblQuestion.Text = "Edad del paciente";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Menor de 10", "Entre 10-20", "Entre 21-40", "Mayor a 40" });
                progressBar1.Value = 14;
            }
            if (questionNumber == 1)
            {
                lblQuestion.Text = "¿Cuál es su nivel de fiebre?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Muy Alto", "Alto", "Normal" });
                progressBar1.Value = 28;
            }
            else if (questionNumber == 2)
            {
                lblQuestion.Text = "¿Tienes dificultad para respirar?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No siempre", "No" });
                progressBar1.Value = 42;
            }
            else if (questionNumber == 3)
            {
                lblQuestion.Text = "¿Tienes dolor muscular?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No" });
                progressBar1.Value = 56;
            }
            else if (questionNumber == 4)
            {
                lblQuestion.Text = "¿Sientes mareos y/o nauceas?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No" });
                progressBar1.Value = 70;
            }
            else if (questionNumber == 5)
            {
                lblQuestion.Text = "¿Se le dificulta hablar?";
                cmbAnswer.Items.Clear();
                cmbAnswer.Items.AddRange(new string[] { "Sí", "No" });
                btnNext.Text = "Evaluar";
                progressBar1.Value = 84;
            }
            else if (questionNumber == 6)
            {
                EvaluateEmergency();
                progressBar1.Value = 100;
            }
        }


        private void btnNext_Click_1(object sender, EventArgs e)
        {
            string selectedAnswer = cmbAnswer.SelectedItem as string;

            if (currentQuestion <= 5)
            {
                ProcessAnswer(currentQuestion, selectedAnswer);
                currentQuestion++;
                DisplayQuestion(currentQuestion);
            }
        }
        //  para cada respuesta individualmente
        private void ProcessAnswer(int questionNumber, string answer)
        {
            if (questionNumber == 1)
            {
                if (answer == "Normal")
                {
                    MessageBox.Show("Mantente hidratado junto a un buen descanso.");
                }
                else if (answer == "Alto")
                {
                    MessageBox.Show("Toma medicamentos para bajar la fiebre y reposa");
                }
                else if (answer == "Muy Alto")
                {
                    MessageBox.Show("Acude a atención médica de inmediato.");
                }
            }
            else if (questionNumber == 2)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Busca atención médica de inmediato y haga uso de un ihnalador o respirador.");
                }
                if (answer == "No siempre")
                {
                    MessageBox.Show(" Haga rehabilitacion pulmunar y terapia fisica.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("Descansa y mantente pendiente de tus síntomas.");
                }
            }
            else if (questionNumber == 3)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Aplica crema en el musculo y visita un experto.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("Continúa al tanto de tus síntomas.");
                }
            }
            else if (questionNumber == 4)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Descansa, mantente hidratado e interrumpa la dosis de cualquie medicamento.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("Continúa monitoreando tus síntomas.");
                }
            }
            else if (questionNumber == 5)
            {
                if (answer == "Sí")
                {
                    MessageBox.Show("Busca atención médica de inmediato, es posible que te den terapia del habla y el lenguaje.");
                }
                else if (answer == "No")
                {
                    MessageBox.Show("Descansa y permanece en tranquilidad.");
                }
            }
        }

        private void EvaluateEmergency()
        {
            // Realiza la evaluación final de las respuestas y presenta un procedimiento
            MessageBox.Show("¡Situacion evaluada! Seguir las recomendaciones.");
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            DisplayQuestion(currentQuestion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedAnswer = cmbAnswer.SelectedItem as string;

            if (currentQuestion <= 5)
            {
                ProcessAnswer(currentQuestion, selectedAnswer);
                currentQuestion++;
                DisplayQuestion(currentQuestion);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
