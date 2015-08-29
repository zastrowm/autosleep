using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSleep
{
  /// <summary>
  ///  Informs the user that the computer is about to go to sleep, and after 3 minutes, goes to
  ///  sleep.
  /// </summary>
  public partial class SleepWarningDialog : Form
  {
    /// <summary> Default constructor. </summary>
    public SleepWarningDialog()
    {
      InitializeComponent();

      tmrTimeToSleep.Interval = (int)TimeSpan.FromMinutes(3).TotalMilliseconds;
      tmrTimeToSleep.Enabled = true;
    }

    /// <summary> Close the dialog without going to sleep. </summary>
    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    /// <summary> Called when the timer elapses or the user clicks the Sleep button. </summary>
    private void GoToSleep(object sender, EventArgs e)
    {
      Close();
      PutComputerToSleep();
    }

    /// <summary> Puts the computer to sleep. </summary>
    public static void PutComputerToSleep()
    {
      Application.SetSuspendState(PowerState.Suspend, true, false);
    }
  }
}