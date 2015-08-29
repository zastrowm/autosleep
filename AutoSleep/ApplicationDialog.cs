using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSleep
{
  /// <summary> Main driver for the application. </summary>
  public partial class ApplicationDialog : Form
  {
    private readonly MenuItem _enabledMenuItem;
    private readonly TimeSpan _limit = TimeSpan.FromMinutes(25);
    private readonly TimeSpan _timerTick = TimeSpan.FromMinutes(1);

    private SleepWarningDialog _sleepDialog;

    /// <summary> Default constructor. </summary>
    public ApplicationDialog()
    {
      InitializeComponent();

      var menu = new ContextMenu();
      menu.MenuItems.Add(new MenuItem("Sleep Now", (s, a) => SleepWarningDialog.PutComputerToSleep()));
      menu.MenuItems.Add("-");
      menu.MenuItems.Add(_enabledMenuItem = new MenuItem("Enabled", HandleEnabledChanged));
      menu.MenuItems.Add(new MenuItem("Exit", ((sender, args) => Close())));

      components.Add(new NotifyIcon
      {
        Icon = this.Icon,
        Visible = true,
        ContextMenu = menu,
        Text = "Put the computer to sleep after the user is Idle",
      });

      tmrCheckTimer.Interval = (int)_timerTick.TotalMilliseconds;

      HandleEnabledChanged();
    }

    /// <summary> make sure that the form is never visible. </summary>
    protected override void OnVisibleChanged(EventArgs e)
    {
      base.OnVisibleChanged(e);
      this.Visible = false;
    }

    /// <summary> Enable or disable the timer based on the menu item. </summary>
    private void HandleEnabledChanged(object sender = null, EventArgs e = null)
    {
      _enabledMenuItem.Checked = !_enabledMenuItem.Checked;
      tmrCheckTimer.Enabled = _enabledMenuItem.Checked;
      _sleepDialog?.Close();
    }

    /// <summary> If the user hasn't moved in a while, start the sleep dialog. </summary>
    private void HandleTimerTick(object sender, EventArgs e)
    {
      if (InputData.TimeSinceLastInput < _limit)
      {
        // if the user moves the mouse, then hide the dialog
        _sleepDialog?.Close();
      }
      else
      {
        // it's currently taken care of
        if (_sleepDialog != null)
          return;

        // pop up a warning and let the user handle the problem
        _sleepDialog = new SleepWarningDialog();
        _sleepDialog.Closed += delegate
        {
          _sleepDialog.Dispose();
          _sleepDialog = null;
        };
        _sleepDialog.Show();
      }
    }
  }
}