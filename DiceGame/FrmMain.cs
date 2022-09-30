using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class FrmMain : Form
    {

        private DiceHandler DiceHandler { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DiceHandler = new DiceHandler()
            {
                DiceAmount = (int)NudAmountDices.Value
            };
        }

        private void BtnPlayDices_Click(object sender, EventArgs e)
        {
            DiceHandler.PlayDices();
            LblResult.Text = DiceHandler.Result.ToString();
        }

        private void CkBoxAmountDices_CheckedChanged(object sender, EventArgs e)
        {
            NudAmountDices.Enabled = CkBoxAmountDices.Checked;
        }

        private void NudAmountDices_ValueChanged(object sender, EventArgs e)
        {
            DiceHandler.DiceAmount = (int)NudAmountDices.Value;
        }
    }
}
