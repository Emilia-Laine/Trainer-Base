using System;
using System.Windows.Forms;

namespace Trainer_Base
{
    public partial class TrainerWindow : Form
    {
        private Trainer.Trainer trainer;

        public TrainerWindow()
        {
            InitializeComponent();
        }

        private void TrainerWindow_Load(object sender, EventArgs e)
        {
            trainer = new Trainer.Trainer("Your process name here!");
        }

        private void hackButton_Click(object sender, EventArgs e)
        {
            trainer.WriteMemory("Your code here!", "Your type here!", "Your value here!");
        }
    }
}
