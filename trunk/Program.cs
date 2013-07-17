﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TenhouViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hash = "2013070808gm-0089-0000-2f83b7da";
            string FileName = Hash + ".xml";

            Tenhou.Downloader D = new Tenhou.Downloader(Hash);
            if (!D.Download(FileName)) return;

            Tenhou.ReplayDecoder R = new Tenhou.ReplayDecoder();
            R.OpenPlainText(FileName, Hash);

            Mahjong.Replay Replay = R.R;

            Replay.Save();
        }
    }
}
