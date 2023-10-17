using PowerStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaptopAlarm
{
    public partial class frmMain : Form
    {
        System.Media.SoundPlayer player;
        PowerStatusProvider statusProvider = new PowerStatusProvider();
        public frmMain()
        {

            InitializeComponent();
            statusProvider.Subscribe(
                e => txtEvents.Text += e.ToString(),
                PowerStatusNotification.BatteryProportionChanged(proportion =>
                    txtEvents.Text += $"The battery proportion is {proportion}" + Environment.NewLine),
                PowerStatusNotification.BatterySaverIsOn(isOn =>
                    txtEvents.Text += $"Battery saver {(isOn ? "is" : "is not")} on" + Environment.NewLine),
                PowerStatusNotification.CurrentMonitorDisplayState(state =>
                    txtEvents.Text += $"The current monitor's display state is {state}" + Environment.NewLine),
                PowerStatusNotification.LidIsOpen(isOpen =>
                    txtEvents.Text += $"The lid {(isOpen ? "is" : "is not")} open" + Environment.NewLine),
                PowerStatusNotification.PowerSchemePersonalityChanged(personality =>
                    txtEvents.Text += $"The power scheme is {personality}" + Environment.NewLine),
                PowerStatusNotification.PowerSource(powerSource =>
                    txtEvents.Text += $"The power source is {powerSource}" + Environment.NewLine),
                PowerStatusNotification.PrimaryMonitorIsOn(isOn =>
                    txtEvents.Text += $"The primary monitor {(isOn ? "is" : "is not")} on" + Environment.NewLine),
                PowerStatusNotification.SessionDisplayState(state =>
                    txtEvents.Text += $"The session display is {state}" + Environment.NewLine),
                PowerStatusNotification.SystemAwayModeChanged(awayMode =>
                    txtEvents.Text += $"The system is {awayMode} away mode" + Environment.NewLine),
                PowerStatusNotification.SystemIsBusy(() =>
                    txtEvents.Text += "The system is busy" + Environment.NewLine),
                PowerStatusNotification.UserIsActive(isActive =>
                    txtEvents.Text += $"The user {(isActive ? "is" : "is not")} active" + Environment.NewLine)
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SystemInformation.PowerStatus powerStatus = SystemInformation.PowerStatus;

            //if (powerStatus.PowerLineStatus == PowerLineStatus.Online)
            //{
            //    MessageBox.Show("Running On Power", Convert.ToString(powerStatus.BatteryLifePercent * 100) + "%");
            //}
            //else
            //{
            //    MessageBox.Show("Running On Battery", Convert.ToString(powerStatus.BatteryLifePercent * 100) + "%");
            //}
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = LaptopAlarm.Properties.Resources.alarm;
            player = new System.Media.SoundPlayer(str);
            player.Play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
