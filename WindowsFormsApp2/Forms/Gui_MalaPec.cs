using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Gui_MalaPec : Form
    {
        bool debugDontDisableGuiOnConnectionLost = false;
        Prop1 p = Val.logocontroler.Prop1;
        Thread DisableGuiOnConnectionLossThread;    
        
        public Gui_MalaPec()
        {
            InitializeComponent();
            FormatTopPanel();
            FormClosed += Gui_MalaPec_FormClosed;
            Resize += Gui_MalaPec_Resize;
            SetupForm();
            Load += Gui_MalaPec_Load;    
            
            connectedButton1.ID = 1;
            DisableGuiOnConnectionLossThread = new Thread(DisableGuiOnConnectionLoss);           
           
        }
               
        void enableGui(bool _enable)
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                try
                {

                    if (Controls[i].GetType() == typeof(Panel) || Controls[i].GetType().Name == typeof(ConnectedButton).Name)
                    {

                    }
                    else
                    {                        
                        Controls[i].Enabled = _enable;                        
                    }

                }
                catch
                {

                }                
                addMessageConnectionLost(_enable);
            }
        }

        void DisableGuiOnConnectionLoss()
        {
            
            var m = new MethodInvoker(delegate
            {
                if (debugDontDisableGuiOnConnectionLost)
                {
                    return;
                }
                if (LogoControler.LOGOConnection[1].connectionStatusLOGO != Connection.Status.Connected)
                {
                    enableGui(false);
                }
                else
                {
                    enableGui(true);
                }
                

            });

            while (true)
            {
                Invoke(m);
                Thread.Sleep(Settings.UpdateValuesPCms);
            }
        }

        void addMessageConnectionLost(bool _add )
        {
            if (!_add)
            {
                WarningManager.AddMessageForUser_Warning(WarningManager.NoConnWarningPLC1);
            }
            else
            {
                WarningManager.RemoveMessageForUser_Warning(WarningManager.NoConnWarningPLC1);
            }
        }
                     
        string formatTemp1(string temperature)
        {
            return ("[" + temperature + "°C]");
        }

            
        private void Gui_MalaPec_Load(object sender, EventArgs e)
        {           
            registerEvents();
            DisableGuiOnConnectionLossThread.Start();            
        }

        private void Gui_MalaPec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Helper.ExitApp();
        }
       
        private void FormatTopPanel()
        {            
            panelTop.Width = Width;   
            positionBtnSettings();

        }

        void positionBtnSettings()
        {
            btnSettings.Left = panelTop.Right - btnSettings.Width - 50;
        }

        private void ReFormatTopPannel()
        {
            panelTop.Width = Width;
            positionBtnSettings();
        }

        private void SetupForm()
        {
            DoubleBuffered = true;
            Shown += Gui_MalaPec_Shown;
        }

        private void Gui_MalaPec_Shown(object sender, EventArgs e)
        {
            FormControl.Form_settings.Hide();
        }

        private void Gui_MalaPec_Resize(object sender, EventArgs e)
        {
            ReFormatTopPannel();           
        }

        void registerEvents()
        {
            btnSettings.Click += BtnSettings_Click;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FormControl.ShowForm_Settings();
            this.Hide();

        }
       
    }

    class SysTimer : System.Timers.Timer
    {
        public SysTimer() : base()
        {

        }
        public SysTimer(double interval) : base(interval)
        {

        }
    }
}
