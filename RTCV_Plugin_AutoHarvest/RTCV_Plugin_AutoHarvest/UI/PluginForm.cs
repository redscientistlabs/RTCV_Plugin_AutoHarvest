namespace AUTOHARVEST.UI
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using NLog;
    using RTCV.CorruptCore;

    using RTCV.Common;
    using RTCV.UI;
    using static RTCV.CorruptCore.RtcCore;
    using RTCV.Vanguard;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Runtime.InteropServices;
    using System.Drawing.Imaging;
    using RTCV.NetCore;
    using System.Diagnostics;
    using System.Net;
    using System.Collections.Specialized;

    using System.IO.Compression;
    using System.Windows.Documents.Serialization;
    using RTCV.UI.Modular;
    using RTCV.UI.Components.Controls;

    //using System.Windows;

    public partial class PluginForm : ComponentForm, IColorize
    {
        public AUTOHARVEST plugin;

        public volatile bool HideOnClose = true;

        Logger logger = NLog.LogManager.GetCurrentClassLogger();

        WebClient wc = new WebClient();

        //This dictionary will inflate forever but it would take quite a while to be noticeable.
        Dictionary<string, bool> encounteredIds = new Dictionary<string, bool>();

        private System.Windows.Forms.Timer ticker = null;

        public PluginForm(AUTOHARVEST _plugin)
        {
            plugin = _plugin;

            this.InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.PluginForm_FormClosing);
            this.Text = "Auto-Harvest";// CORRUPTCLOUD_LIVE.CamelCase(nameof(CORRUPTCLOUD_LIVE).Replace("_", " ")); //automatic window title

            this.version.Text = $"{plugin.Version.ToString()}"; //automatic window title
        }


        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            encounteredIds.Clear();

            if (HideOnClose)
            {
                e.Cancel = true;
                this.Hide();
            }    
        }

        private void btnStashPrevCorruption_Click(object sender, EventArgs e)
        {
            if (btnAutoHarvest.Text != "Start Auto-Harvest")
                btnAutoHarvest_Click(null, null);

            S.GET<StashHistoryForm>().MoveSelectedStashUp(null, null);
        }

        private void btnStashNextCorruption_Click(object sender, EventArgs e)
        {
            if (btnAutoHarvest.Text != "Start Auto-Harvest")
                btnAutoHarvest_Click(null, null);

            S.GET<StashHistoryForm>().MoveSelectedStashDown(null, null);
        }

        private void btnAutoHarvest_Click(object sender, EventArgs e)
        {
            if(btnAutoHarvest.Text == "Start Auto-Harvest")
            {
                btnAutoHarvest.Text = "Stop Auto-Harvest";
                StartAutoHarvest();
            }
            else
            {
                btnAutoHarvest.Text = "Start Auto-Harvest";
                StopAutoHarvest();
            }
        }

        public void StartAutoHarvest()
        {
            if (ticker != null)
            {
                ticker.Stop();
                ticker = null;
            }

            ticker = new Timer();
            ticker.Interval = Convert.ToInt32(nmHarvestDelay.Value * 1000);
            ticker.Tick += Ticker_Tick;
            ticker.Start();

            Ticker_Tick(null, null);
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {

            SyncObjectSingleton.FormExecute(() =>
            {
                S.GET<GlitchHarvesterBlastForm>().loadBeforeOperation = true;
                S.GET<GlitchHarvesterBlastForm>().Corrupt(null, null);
            });
        }

        public void StopAutoHarvest()
        {
            if (ticker != null)
            {
                ticker.Stop();
                ticker = null;
            }
        }

        private void btnSendLastCorruptions_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(nmCorruptionsToBeSent.Value);

            for(int i = 0;i<number;i++)
            {
                SyncObjectSingleton.FormExecute(() =>
                {
                    S.GET<StashHistoryForm>().AddStashToStockpile(false);
                });
            }
        }

        private void nmHarvestDelay_ValueChanged(object sender, EventArgs e)
        {
            if (btnAutoHarvest.Text != "Start Auto-Harvest")
            {
                StopAutoHarvest();
                btnAutoHarvest_Click(null, null);
            }

        }

        private void btnReplayCorruption_Click(object sender, EventArgs e)
        {
            if (btnAutoHarvest.Text != "Start Auto-Harvest")
                btnAutoHarvest_Click(null, null);


            SyncObjectSingleton.FormExecute(() =>
            {
                var sh = S.GET<StashHistoryForm>();
                var sm = S.GET<StockpileManagerForm>();
                var ghb = S.GET<GlitchHarvesterBlastForm>();

                if (sh.lbStashHistory.SelectedIndex != -1)
                {
                    sh.HandleStashHistorySelectionChange(null, null);
                }
                else
                {
                    var rows = sm.dgvStockpile.SelectedRows;
                    var mainRow = rows[0];

                    if (rows.Count > 1)
                    {
                        ghb.Corrupt(null, null);
                    }
                    else
                    {
                        sm.HandleCellClick(sm.dgvStockpile, new DataGridViewCellEventArgs(0, mainRow.Index));
                    }
                }
            });
        }
    }



}
