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
    public partial class FrmProcessQuizz : Form
    {
        public FrmProcessQuizz( string QuizzLevel,int NumberOfQuestions
         ,string OperationType)
        {
            InitializeComponent();
            Options[0] = btn1; Options[1] = btn2; Options[2] = btn3;Options[3] = btn4;
            _QuizzLevel = QuizzLevel;
            _NumberOfQuestions = NumberOfQuestions;
            _OperationType = OperationType;
            Quizz.OperationType = OperationType;
            Quizz.QuizzLevel = QuizzLevel;
            Quizz.QuestionsCounter = 0;
            lblTotalQuestions.Text = NumberOfQuestions.ToString();
        }
        enum enOperationType { Sub = 0, Add = 1, Div = 2, Mult = 3 };
        enum enQuestionLevel { Easy = 0, Medium = 1, Hard = 2 };
       
        struct stQuestion {
            public enOperationType OpType;
            public enQuestionLevel Level;
            public char Operator;
            public int Operand1;
            public int Operand2;
            public int PlayerAnswer;
            public int CorrectAnswer;
        }
        struct stQuizz {
            public int QuestionsCounter;
            public string QuizzLevel;
            public string OperationType;
        }
        stQuizz Quizz;
        stQuestion Question;
        Random rand = new Random();
        Button[] Options = new Button[4];
        int _NumberOfQuestions; string _QuizzLevel;string _OperationType;
        int Seconds = 60;
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void Swap(ref Button bt1, ref Button bt2)
        {
            Button temp = new Button();
            temp.Text = bt1.Text;
            bt1.Text = bt2.Text;
            bt2.Text = temp.Text;
        }

        void ShuffleOptions()
        {
            for (int i = 0; i < Options.Length; i++)
            {
                Swap(ref Options[rand.Next(0, Options.Length)], ref Options[rand.Next(0, Options.Length)]);
            }
        }
        void ShowGameOver()
        {
            timer1.Enabled = false;
            panelOptions.Enabled = false;

            Form MathQuizzOver = new MathQuizzOver(lblWrongAnswers.Text, lblCorrectAnswers.Text, _QuizzLevel, _OperationType);
            this.Hide();
            MathQuizzOver.ShowDialog();
            this.Close();
        }
        
        void GetQuestionLevel()
        {

            if (_QuizzLevel == "Mixed")
            {
                string[] arr = { "Easy", "Medium", "Hard" };
                Quizz.QuizzLevel = arr[rand.Next(0, 3)];
            }
            switch (Quizz.QuizzLevel)
            {
                case "Easy":
                    Question.Level = enQuestionLevel.Easy;
                    break;
                case "Medium":
                    Question.Level = enQuestionLevel.Medium;
                    break;
                case "Hard":
                    Question.Level = enQuestionLevel.Hard;
                    break;
            }

        }
        
        void GetQuestionOperationType()
        {
            if (_OperationType == "Mixed")
            {
                string[] arr = { "Addition", "Subtraction","Division",
                    "Multiplication" };
                Quizz.OperationType = arr[rand.Next(0, 4)];
            }

            switch (Quizz.OperationType)
            {
                case "Addition":
                    Question.OpType = enOperationType.Add;
                    Operator.Text = '+'.ToString();
                    break;
                case "Subtraction":
                    Question.OpType = enOperationType.Sub;
                    Operator.Text = '-'.ToString();
                    break;
                
                case "Division":
                    Question.OpType = enOperationType.Div;
                    Operator.Text = '/'.ToString();
                    break;
                case "Multiplication":
                    Question.OpType = enOperationType.Mult;
                    Operator.Text = '*'.ToString();
                    break;
            }
        }
        void GetRandomOperands()
        {
            if (Question.Level == enQuestionLevel.Easy)
            {
                Question.Operand1 = rand.Next(1, 10);
                Question.Operand2 = rand.Next(1, 10);
            }
            else if (Question.Level == enQuestionLevel.Medium)
            {
                Question.Operand1 = rand.Next(20, 50);
                Question.Operand2 = rand.Next(20, 50);
            }
            else if (Question.Level == enQuestionLevel.Hard)
            {
                Question.Operand1 = rand.Next(50, 100);
                Question.Operand2 = rand.Next(50, 100);
            }
            Num1.Text = Question.Operand1.ToString();
            Num2.Text = Question.Operand2.ToString();
        }
        void SimpleCalculator()
        {
            switch (Question.OpType)
            {
                case enOperationType.Add:
                    Question.Operator = '+';
                    Question.CorrectAnswer = Question.Operand1 + Question.Operand2;
                    break;
                case enOperationType.Sub:
                    Question.Operator = '-';
                    Question.CorrectAnswer = Question.Operand1 - Question.Operand2;
                    break;
                case enOperationType.Mult:
                    Question.Operator = '*';
                    Question.CorrectAnswer = Question.Operand1 * Question.Operand2;
                    break;
                case enOperationType.Div:
                    Question.Operator = '/';
                    Question.CorrectAnswer = Question.Operand1 / Question.Operand2;
                    break;
            }

        }
        int[] randomNumbers = new int[3];
        void GetRandomNumber(int from, int to)
        {
            int[] numbers = Enumerable.Range(from, to).ToArray();
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(0, numbers.Length);
                randomNumbers[i] = numbers[index];
                numbers = numbers.Where((val, idx) => idx != index).ToArray();
            }
        }
        void GetAnswerOptions()
        {
            int from = 0; int to = 0;
            if (Question.Level == enQuestionLevel.Easy)
            {
                from = 1;
                to = 10;

            }
            else if (Question.Level == enQuestionLevel.Medium)
            {
                from = 20;
                to = 50;
            }
            else
            {
                from = 50;
                to = 100;
            }
            GetRandomNumber(from,to);
            Options[0].Text = Question.CorrectAnswer.ToString();
            Options[1].Text = randomNumbers[0].ToString();
            Options[2].Text = randomNumbers[1].ToString();
            Options[3].Text = randomNumbers[2].ToString();


            /*Options[0].Text = Question.CorrectAnswer.ToString();
            do
            {
                Options[1].Text = rand.Next(from, to).ToString();
            } while (Options[1].Text == Options[0].Text);

            do
            {
                Options[1].Text = rand.Next(from, to).ToString();
            } while (Options[2].Text == Options[1].Text);

            do
            {
                Options[3].Text = rand.Next(from, to).ToString();
            } while (Options[3].Text == Options[2].Text);*/
            ShuffleOptions();
        }

        void AskQuestion()
        {
            GetQuestionLevel();
            GetQuestionOperationType();
            GetRandomOperands();
            SimpleCalculator();
            GetAnswerOptions();
        }
        void StartQuizzGame()
        {
            ++Quizz.QuestionsCounter;
            lblQuestionNumber.Text = Quizz.QuestionsCounter.ToString();
            if (Quizz.QuestionsCounter <= _NumberOfQuestions)
            {
                AskQuestion();
            }
            else
            {
                ShowGameOver();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Enabled = false;
            timer1.Start();
            StartQuizzGame();
        }
        void CheckPlayerAnswer()
        {
            int CorrectAnswer = Convert.ToInt32(lblCorrectAnswers.Text);
            int WrongAnswer = Convert.ToInt32(lblWrongAnswers.Text);
            if (Question.PlayerAnswer == Question.CorrectAnswer)
            {
                MessageBox.Show("Your answer is correct","Great !",MessageBoxButtons.OK,MessageBoxIcon.Information);
                CorrectAnswer++;
                lblCorrectAnswers.Text = CorrectAnswer.ToString();
            }
            else
            {
                MessageBox.Show("Your answer is wrong", "Try Again !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WrongAnswer++;
                lblWrongAnswers.Text = WrongAnswer.ToString();
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            Button pressbtn = (Button)sender;
            Question.PlayerAnswer = Convert.ToInt32(pressbtn.Text);
            CheckPlayerAnswer();
            StartQuizzGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = timer1.ToString();

            if (Seconds >= 0)
            {
                lblTimer.Text = "00:00:" + Seconds.ToString("00");
                Seconds--;
            }

            else
            {
                ShowGameOver();
            }
        }

        private void FrmProcessQuizz_Load(object sender, EventArgs e)
        {
            //lblTimer.Text = timer1.ToString();
        }
    }
}
