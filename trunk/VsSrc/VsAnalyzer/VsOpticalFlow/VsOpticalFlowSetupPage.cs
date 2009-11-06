// zvyv	 IMPORTANT: READ BEFORE DOWNLOADING, COPYING, INSTALLING OR USING. 
// wbao	
// ymjt	 By downloading, copying, installing or using the software you agree to this license.
// ivmo	 If you do not agree to this license, do not download, install,
// morg	 copy or use the software.
// rmca	
// qmhr	                          License Agreement
// arkf	         For OpenVss - Open Source Video Surveillance System
// gtxj	
// xwwm	Copyright (C) 2007-2009, Prince of Songkla University, All rights reserved.
// mxyp	
// sfso	Third party copyrights are property of their respective owners.
// fjjk	
// kibm	Redistribution and use in source and binary forms, with or without modification,
// tyfk	are permitted provided that the following conditions are met:
// ujog	
// cemo	  * Redistribution's of source code must retain the above copyright notice,
// xcrp	    this list of conditions and the following disclaimer.
// sftu	
// omik	  * Redistribution's in binary form must reproduce the above copyright notice,
// ttlr	    this list of conditions and the following disclaimer in the documentation
// izux	    and/or other materials provided with the distribution.
// skqz	
// qlsd	  * Neither the name of the copyright holders nor the names of its contributors 
// jrno	    may not be used to endorse or promote products derived from this software 
// seqc	    without specific prior written permission.
// stre	
// ohyg	This software is provided by the copyright holders and contributors "as is" and
// pvra	any express or implied warranties, including, but not limited to, the implied
// xwyc	warranties of merchantability and fitness for a particular purpose are disclaimed.
// jown	In no event shall the Prince of Songkla University or contributors be liable 
// mryh	for any direct, indirect, incidental, special, exemplary, or consequential damages
// nqkw	(including, but not limited to, procurement of substitute goods or services;
// ztsp	loss of use, data, or profits; or business interruption) however caused
// djzo	and on any theory of liability, whether in contract, strict liability,
// hqjl	or tort (including negligence or otherwise) arising in any way out of
// ljjv	the use of this software, even if advised of the possibility of such damage.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Vs.Core.Analyzer;

namespace Vs.Analyzer.OpticalFlow
{
    public partial class VsOpticalFlowSetupPage : UserControl, VsICoreAnalyzerPage
    {
        private bool completed = false;
        public event EventHandler StateChanged;

        public VsOpticalFlowSetupPage()
        {
            InitializeComponent();
        }

        #region VsICoreAnalyzerPage Members

        bool VsICoreAnalyzerPage.Apply()
        {
            return true;
        }

        bool VsICoreAnalyzerPage.Completed
        {
            get { return completed; }
        }

        void VsICoreAnalyzerPage.Display()
        {
            this.trackBar1.Focus();
        }

        VsICoreAnalyzerConfiguration VsICoreAnalyzerPage.GetConfiguration()
        {
            VsOpticalFlowConfiguration cfg = new VsOpticalFlowConfiguration();

            cfg.ThresholdAlpha = this.trackBar1.Value;
            cfg.ThresholdSigma = this.trackBar2.Value;

            return cfg;
        }

        void VsICoreAnalyzerPage.SetConfiguration(VsICoreAnalyzerConfiguration config)
        {
            VsOpticalFlowConfiguration cfg = (VsOpticalFlowConfiguration)config;

            if (cfg != null)
            {
                this.trackBar1.Value = cfg.ThresholdAlpha ;
                this.trackBar2.Value = cfg.ThresholdSigma;
            }
        }

       #endregion

        // Update state
        private void UpdateState()
        {
            completed = true;

            if (StateChanged != null)
                StateChanged(this, new EventArgs());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateState();
        }
    }
}
