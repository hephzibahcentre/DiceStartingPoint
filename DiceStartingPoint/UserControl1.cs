using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace DiceStartingPoint
{
    public partial class UserControl1: UserControl
    {
        //Assign values

        //Default values
        int intDie1 = 6;
        int intDie2 = 3;
        int intDie3 = 6;
        int intDiceCorrectScore = 0;
        int intDiceIncorrectScore = 0;

        //Dice roll sound
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.diceroll);

        //Dice roll sides
        Bitmap die1img = Properties.Resources._1;
        Bitmap die2img = Properties.Resources._2;
        Bitmap die3img = Properties.Resources._3;
        Bitmap die4img = Properties.Resources._4;
        Bitmap die5img = Properties.Resources._5;
        Bitmap die6img = Properties.Resources._6;


        public UserControl1()
        {
            InitializeComponent();
            
            //Initialize defaults

            die1Out.Text = intDie1.ToString();
            intDie1img.Image = die6img;
            die2Out.Text = intDie2.ToString();
            intDie2img.Image = die3img;
            die3Out.Text = intDie3.ToString();
            intDie3img.Image = die6img;

            intDiceCS.Text = intDiceCorrectScore.ToString();
            intDiceIS.Text = intDiceIncorrectScore.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            //To dynamically change images based on dice roll
            Image[] images = { die1img, die2img, die3img, die4img, die5img, die6img };

            //Play dice roll sound
            player.Play();

            //Pick dice roll at random
            Random rnd = new Random();
            int dieone = rnd.Next(1, 7);
            int dietwo = rnd.Next(1, 7);
            int diethree = rnd.Next(1, 7);

            //Output based on dice roll
            die1Out.Text = dieone.ToString();
            intDie1img.Image = images[dieone - 1];
            die2Out.Text = dietwo.ToString();
            intDie2img.Image = images[dietwo - 1];
            die3Out.Text = diethree.ToString();
            intDie3img.Image = images[diethree - 1];

            //Determine if guess and dice roll correlate
            int totaldicevalue = dieone + dietwo + diethree;
            if (selectedGuess.Text == totaldicevalue.ToString())
            {
                intDiceCorrectScore = intDiceCorrectScore + 1;
                intDiceCS.Text = intDiceCorrectScore.ToString();
            } else
            {
                intDiceIncorrectScore = intDiceIncorrectScore + 1;
                intDiceIS.Text = intDiceIncorrectScore.ToString();
            }

            //Stop dice roll sound
            player.Stop();
        }
    }
}
