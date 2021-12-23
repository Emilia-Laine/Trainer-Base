using System.Diagnostics;
using System.Windows.Forms;

namespace Trainer_Base.Trainer
{
    public class Trainer
    {
        public string ProcessName;

        private Memory.Mem memory;

        public Trainer(string processName)
        {
            ProcessName = processName;
            InitializeTrainer();
        }

        private void InitializeTrainer()
        {
            memory = new Memory.Mem();
        }

        public bool ProcessIsOpen()
        {
            return Process.GetProcessesByName(ProcessName).Length > 0;
        }

        public void WriteMemory(string code, string type, string write)
        {
            if (ProcessIsOpen())
            {
                memory.OpenProcess(ProcessName);
            }
            else
            {
                Utilities.ShowErrorMessage("The process is not open!");
                return;
            }

            if (memory.WriteMemory(code, type, write))
            {
                return;
            }
            else
            {
                Utilities.ShowErrorMessage("Failed to write memory to the process!");
            }
        }

        public void KillProcess()
        {
            foreach (Process process in Process.GetProcessesByName(ProcessName))
            {
                process.Kill();
            }
        }
    }

    public static class Utilities
    {
        public static void ShowErrorMessage(string content)
        {
            MessageBox.Show(content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
