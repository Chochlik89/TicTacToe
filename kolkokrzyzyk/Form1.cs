using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;

namespace kolkokrzyzyk
{
    public partial class Form1 : Form
    {
        private Player PlayerO;
        private Player PlayerX;
        private Player CurrentPlayer;
        private Board Board;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame(sender as Form);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.Enabled = false;

            Point coordinates = (Point)button.Tag;
            Board.SetPosition(coordinates.X-1, coordinates.Y-1, CurrentPlayer.Sign);
            button.Text = CurrentPlayer.Sign.ToString();

            bool isAwin = Game.IsAWin(coordinates.X-1, coordinates.Y-1, CurrentPlayer.Sign, Board);
            
            if (isAwin)
            {
                MessageBox.Show($"Wygrał gracz: {CurrentPlayer.Name}");
                ToggleButtons(ActiveForm, false);
                return;
            } 
            
            if (Board.IsBoardFull())
            {
                MessageBox.Show($"Remis!");
                ToggleButtons(ActiveForm, false);
                return;
            }

            CurrentPlayer = CurrentPlayer == PlayerO ? PlayerX : PlayerO;
            SwitchCurrentPlayer();
        }

        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            InitializeGame(ActiveForm);
            ToggleButtons(ActiveForm, true);

            PlayerO.Name = GetPlayerPrompt.ShowDialog();
            PlayerX.Name = GetPlayerPrompt.ShowDialog();

            CurrentPlayer = PlayerO;

            SwitchCurrentPlayer();
        }

        private void InitializeGame(Form form)
        {
            PlayerO = new Player(PlayerSign.O);
            PlayerX = new Player(PlayerSign.X);
            Board = new Board();
            ClearButtons(form);
            form.Controls["CurrentPlayerLbl"].Text = "";
        }

        private void ToggleButtons(Form form, bool enable)
        {
            foreach (var control in form.Controls)
            {
                if (control is Button && (control as Button).Name != "NewGameBtn")
                {
                    (control as Button).Enabled = enable;
                }
            }
        }

        private void ClearButtons(Form form)
        {
            foreach (var control in form.Controls)
            {
                if (control is Button && (control as Button).Name != "NewGameBtn")
                {
                    (control as Button).Text = "";
                }
            }
        }

        private void SwitchCurrentPlayer()
        {
            Form form = ActiveForm;
            form.Controls["CurrentPlayerLbl"].Text = CurrentPlayer.Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
