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
    public partial class MathQuizz : Form
    {
        public MathQuizz()
        {
            InitializeComponent();
        }
        stInfoQuizz InfoQuizz;
        struct stInfoQuizz
        {
            
            public string QuizzLevel ;
            public int NumberOfQuestions;
            public string OperationType;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            InfoQuizz.OperationType = cbOperationType.Text;
            InfoQuizz.QuizzLevel = cbQuizzLevel.Text;
            InfoQuizz.NumberOfQuestions = Convert.ToInt32(nubNumberOfQuestions.Value);
            Form frm10 = new FrmProcessQuizz(InfoQuizz.QuizzLevel,
                InfoQuizz.NumberOfQuestions, InfoQuizz.OperationType);
            this.Hide();
            this.Enabled = false;
            frm10.ShowDialog();
            this.Close();
        }
    }
}
