using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class MathQuizzOver : Form
    {
        public MathQuizzOver(string WrongAnswers, string CorrectAnswers, string QuizzLevel, string QuizzType)
        {
            InitializeComponent();
            lblWrongAnswer.Text = WrongAnswers;
            lblCorrectAnswer.Text = CorrectAnswers;
            lblQuizzType.Text = QuizzType;
            lblQuizeeLevel.Text = QuizzLevel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form frm10 = new MathQuizz();
            this.Hide();
            this.Enabled = false;
            frm10.ShowDialog();
            this.Close();
        }
    }
}
