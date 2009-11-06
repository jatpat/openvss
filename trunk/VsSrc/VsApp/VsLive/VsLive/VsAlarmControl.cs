// zbfl	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// fggz	
// fayx	 By downloading, copying, installing or using the software you agree to this license.
// gjfx	 If you do not agree to this license, do not download, install,
// rxqx	 copy or use the software.
// zxxd	
// pfis	                          License Agreement
// cgaw	         For OpenVss - Open Source Video Surveillance System
// wony	
// ykzy	Copyright (C) 2007-2009, Prince of Songkla University, All rights reserved.
// nmtx	
// wbhg	Third party copyrights are property of their respective owners.
// ocey	
// jyxb	Redistribution and use in source and binary forms, with or without modification,
// ebva	are permitted provided that the following conditions are met:
// xnwy	
// zbar	  * Redistribution's of source code must retain the above copyright notice,
// whzh	    this list of conditions and the following disclaimer.
// xrkn	
// dagn	  * Redistribution's in binary form must reproduce the above copyright notice,
// ycea	    this list of conditions and the following disclaimer in the documentation
// cbmx	    and/or other materials provided with the distribution.
// rluw	
// ozbz	  * Neither the name of the copyright holders nor the names of its contributors 
// pvxu	    may not be used to endorse or promote products derived from this software 
// apkg	    without specific prior written permission.
// dxbr	
// ojye	This software is provided by the copyright holders and contributors "as is" and
// vhcv	any express or implied warranties, including, but not limited to, the implied
// ivvy	warranties of merchantability and fitness for a particular purpose are disclaimed.
// pcak	In no event shall the Prince of Songkla University or contributors be liable 
// ncty	for any direct, indirect, incidental, special, exemplary, or consequential damages
// qkxh	(including, but not limited to, procurement of substitute goods or services;
// dlmi	loss of use, data, or profits; or business interruption) however caused
// syxf	and on any theory of liability, whether in contract, strict liability,
// zvjh	or tort (including negligence or otherwise) arising in any way out of
// npbg	the use of this software, even if advised of the possibility of such damage.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;
using Vs.Core;
using Vs.Core.Image;
using Vs.Core.Server;

namespace Vs.Monitor
{
    public partial class VsAlarmControl : UserControl, VsEventInterface
    {
        private VsLiveviewTool vsMonitor;
        private VsCoreServer vsCoreMonitor;
        public event VsMonitorEventHandler vsUpdateEvent;

        public VsLiveviewTool Monitor
        {
            set
            {
                vsMonitor = value;
                vsMonitor.vsUpdateEvent += new VsMonitorEventHandler(vsMonitor_vsUpdateEvent);
                this.vsUpdateEvent += new VsMonitorEventHandler(vsMonitor.VsMonitor_vsUpdateEventAlls);
            }
        }

        public VsCoreServer CoreMonitor
        {
            set { vsCoreMonitor = value; }
        }

        public VsAlarmControl()
        {
            InitializeComponent();
        }

        // update event between any views in application
        void vsMonitor_vsUpdateEvent(object sender, VsMonitorEventArgs e)
        {
            if (e.Parameters.EventTo == VsAppControlType.APP_ALL ||
                e.Parameters.EventTo == VsAppControlType.APP_ALARM &&
                e.Parameters.Device == VsDeviceType.CAMERA)
            {
                try { this.Invoke(new VsMonitorEventHandler(vsAlarm_Update), sender, e); }
                catch { }
            }
        }

        //invoked method
        void vsAlarm_Update(object sender, VsMonitorEventArgs e)
        {
            VsAlarmParas vsAlarmParas = (VsAlarmParas)e.Parameters;
            switch (vsAlarmParas.AlarmParas)
            {
                case VsAlarmType.ALARM_ATTACH:
                    this.vsCoreMonitor.AttachEventView(vsAlarmParas.DeviceName, this);
                    break;
                case VsAlarmType.ALARM_DETACH:
                    this.vsCoreMonitor.DetachEventView(vsAlarmParas.DeviceName, this);
                    break;
            }
        }

        // New frame
        public void FrameIn(object sender, VsMotionEventArgs e)
        {
            this.listView1.Invoke(new VsMotionEventHandler(vsListView_Update), sender, e);
        }

        public void vsListView_Update(object sender, VsMotionEventArgs e)
        {
            VsMotion vsMotion = (VsMotion)e.Motion.Clone();
            
            String [] strItem = {vsMotion.DateStart.ToString(), vsMotion.CameraName, vsMotion.EventName};

            ListViewItem item = new ListViewItem(strItem);
            this.listView1.Items.Add(item);
            item.Selected = true;
            item.EnsureVisible();
        }
    }
}
