using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace AutoShimmming
{
    public static class NMR
    {
        const string dllFullName = @"D:\wuduan\Engineering\MRI_Spectrometer\EDA\CS\DLLDEMO\DLLDEMO\Debug\mridll.dll";
        [DllImport(dllFullName)]
        public static extern int add(int a, int b);
        [DllImport(dllFullName)]
        public static extern void SetVerboseLevel(int vlevel);
        [DllImport(dllFullName)]
        public static extern void SetConfigure(string filename);
        [DllImport(dllFullName)]
        public static extern int parse_boxinf(string filename);
        [DllImport(dllFullName)]
        public static extern int Init(string initfile);
        [DllImport(dllFullName)]
        public static extern int NewParFile(string filename);
        [DllImport("mridll.dll")]
        public static extern void SetChannelValue(shimChannel channel, float value);
        [DllImport(dllFullName)]
        public static extern int SetGradientAllScale(shimChannel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetAllMaxtrixValue(string filename);
        [DllImport(dllFullName)]
        public static extern int SetGradientWave(string filename);

        [DllImport(dllFullName)]
        public static extern int SetTxFreOffsetTable(boxType box, boardType boardno, Channel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetTxPhaseTable(boxType box, boardType boardno, Channel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetTxGainTable(boxType box, boardType boardno, Channel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetTxCenterFre(boxType box, boardType boardno, Channel channel, float freq);
        [DllImport(dllFullName)]
        public static extern int SetRFWaves(string wavename);
        [DllImport(dllFullName)]
        public static extern int SetRxBW(boxType box, boardType boardno, Channel channel, int bandwith);
        [DllImport(dllFullName)]
        public static extern int SetRxFreOffsetTable(boxType box, boardType boardno, Channel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetRxPhaseTable(boxType box, boardType boardno, Channel channel, string filename);
        [DllImport(dllFullName)]
        public static extern int SetRxCenterFre(boxType box, boardType boardno, Channel channel, float freq, bool isAllSet);

        [DllImport(dllFullName)]
        public static extern int SetAllPreempValue(string filename);
        [DllImport(dllFullName)]
        public static extern void SetPreempValue(shimChannel channel, PreempKeys keys, float value);
        [DllImport(dllFullName)]
        public static extern float GetPreempValue(shimChannel channel, PreempKeys keys);
        [DllImport(dllFullName)]
        public static extern float GetChannelValue(shimChannel channel);
        [DllImport(dllFullName)]
        public static extern void Abort();
        [DllImport(dllFullName)]
        public static extern void Pause();
        [DllImport(dllFullName)]
        public static extern void Continue();
        [DllImport(dllFullName)]
        public static extern int Run();
        [DllImport(dllFullName)]
        public static extern int SetupModeRun();
        [DllImport(dllFullName)]
        public static extern int SetOutputFile(string filename);
        [DllImport(dllFullName)]
        public static extern int SetOutputPrefix(string prefix);
        [DllImport(dllFullName)]
        public static extern string GetOutputFile();
        [DllImport(dllFullName)]
        public static extern int SetParameterFile(string filename);
        [DllImport(dllFullName)]
        public static extern int SetParameter(string name, double value);
        [DllImport(dllFullName)]
        public static extern double GetParameter(string name);
        [DllImport(dllFullName)]
        public static extern void CloseSys();
        //for test
        [DllImport(dllFullName)]
        public static extern void ReceiveEnvironmentClear();
        [DllImport(dllFullName)]
        public static extern void ReceiveEnvironmentSet();
        //HW config
        [DllImport(dllFullName)]
        public static extern IntPtr ConfigFile(string filename);
        [DllImport(dllFullName)]
        public static extern int SetTxATT(boxType box, boardType board, Channel channel, float value);
        [DllImport(dllFullName)]
        public static extern int SetRxATT(boxType box, boardType board, Channel channel,float att,float amp1,float amp2,float amp3, int switchValue);
        [DllImport(dllFullName)]
        public static extern int SaveTXCaliValue(boxType box, boardType board);
        [DllImport(dllFullName)]
        public static extern int SaveTXAllCaliValue(boxType box);
        [DllImport(dllFullName)]
        public static extern int SaveParameterFile(string filename);
        [DllImport(dllFullName)]
        public static extern int ConfigSingleReg(boxType box,int addr,int value);
        [DllImport(dllFullName)]
        public static extern void RegisterPrintStr();
        [DllImport(dllFullName)]
        public static extern void ArmExit();
        [DllImport(dllFullName)]
        public static extern int QueryReg(boxType box, int addr);
        [DllImport(dllFullName)]
        public static extern void RegisterImageP(getFiles callback);
        [DllImport(dllFullName)]
        public static extern IntPtr GetDLLVersion();
        [DllImport(dllFullName)]
        public static extern int ScanCompleted();
        [DllImport(dllFullName)]
        public static extern double SetFilter(string filterFileName);

       
    }
    

    public enum boardType
    {
        MAIN_BOARD,
        GRADP,
        GRADR,
        GRADS,
        TX1,
        TX2,
        RX1,
        RX2,
        RX3,
        RX4
    }
    public enum PreempKeys
    {
        A1,
        A2,
        A3,
        A4,
        A5,
        A6,
        T1,
        T2,
        T3,
        T4,
        T5,
        T6,
        A1X,
        A2X,
        A3X,
        T1X,
        T2X,
        T3X,
        A1Y,
        A2Y,
        A3Y,
        T1Y,
        T2Y,
        T3Y,
        A1Z,
        A2Z,
        A3Z,
        T1Z,
        T2Z,
        T3Z
    }
    public enum shimChannel
    {
        CHANNEL_X,
        CHANNEL_Y,
        CHANNEL_Z,
        CHANNEL_B0

    }
    public enum boxType
    {
        M,
        E1,
        E2,
        E3,
    }
    public enum Channel
    {
        C1,
        C2,
        C3,
        C4,
        C5,
        C6,
        C7,
        C8
    }
}
