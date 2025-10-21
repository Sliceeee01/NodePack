using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @new
{
    public partial class Form1: Form{
        private enum LightState
        {
            Red,
            Yellow,
            Green
        }
        private LightState currentState = LightState.Green;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e){
            SwitchToNextState();
            ShowLight();



        }

        private void ShowLight() {
            panelRed.BackColor = Color.Gray;
            panelYellow.BackColor = Color.Gray;
            panelGreen.BackColor = Color.Gray;
            switch (currentState)
            {
                case LightState.Red:
                    panelRed.BackColor = Color.Red;
                    break;
                case LightState.Yellow:
                    panelYellow.BackColor = Color.Yellow;
                    break;
                case LightState.Green:
                    panelGreen.BackColor = Color.Green;
                    break;
            }


        }

        private void SwitchToNextState(){
            switch (currentState)
            {
                case LightState.Red: currentState = LightState.Yellow;
                    break;
                case LightState.Yellow:
                    currentState = LightState.Green;
                    break;
                case LightState.Green:
                    currentState = LightState.Red;
                    break;

            }


        }

        private void buttonstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
