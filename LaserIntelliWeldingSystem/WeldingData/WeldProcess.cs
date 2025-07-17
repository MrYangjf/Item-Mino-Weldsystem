using LaserIntelliWeldingSystem.Communication;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace LaserIntelliWeldingSystem.WeldingData
{
    public class RobotWeldData
    {
        public double OffsetY;
        public double OffsetZ;

        public double WeldPointX;
        public double WeldPointY;

        public double PosX;
        public double PosY;
        public double PosZ;
        public int PointCount;
        public int StartNum;
        public int EndNum;
        public double Width = 0;
        public double Height = 0;

        public WeldPoint[] Points;

        public RobotWeldData()
        {
            PosX = 0;
            PosY = 0;
            PosZ = 0;

            OffsetY = 0;
            OffsetZ = 0;
        }

        void SetPoints(double[] Y, double[] Z)
        {
            Points = new WeldPoint[PointCount];
            for (int i = 0; i < PointCount; i++)
            {
                Points[i] = new WeldPoint(Y[i], Z[i]);
            }
        }

        bool SetRobotData(string InputX, string InputY, string InputZ)
        {
            if (!double.TryParse(InputX, out PosX)) return false;
            if (!double.TryParse(InputY, out PosY)) return false;
            if (!double.TryParse(InputZ, out PosZ)) return false;
            return true;
        }

        public bool SetPoints(string InputX, string InputY, string InputZ, string inputPointCount, string Xstr, string Ystr, string InputStart, string InputEnd)
        {
            if (!SetRobotData(InputX, InputY, InputZ)) return false;
            if (!int.TryParse(inputPointCount, out PointCount)) return false;
            if (!int.TryParse(InputStart, out StartNum)) return false;
            if (!int.TryParse(InputEnd, out EndNum)) return false;
            string[] Xcood = Xstr.Split(',');
            string[] Ycood = Ystr.Split(',');
            double[] PointsX = new double[PointCount];
            double[] PointsY = new double[PointCount];
            if (Xcood.Length < PointCount || Ycood.Length < PointCount) return false;
            for (int i = 0; i < PointCount; i++)
            {
                if (!double.TryParse(Xcood[i], out PointsX[i])) return false;
                if (!double.TryParse(Ycood[i], out PointsY[i])) return false;
            }
            SetPoints(PointsX, PointsY);
            WeldPointX = PointsX[3];
            WeldPointY = PointsY[3];
            Width = GetWidth();
            return true;
        }


        double GetWidth()
        {
            double w = 0;
            if (EndNum - StartNum > 0)
            {
                w = Points[EndNum].Y - Points[StartNum].Y;
            }
            else
            { w = -1; }
            return w;
        }
    }

    public class LaserWeldData
    {
        public double LaserPower;
        public double Speed;
        public double FeedSpeed;
        public LaserWeldData()
        {
            LaserPower = 0;
            FeedSpeed = 0;
            Speed = 0;
        }

        public bool SetData(string RoVer, string FeedVer, string Power)
        {
            if (!double.TryParse(RoVer, out Speed)) return false;
            if (!double.TryParse(FeedVer, out FeedSpeed)) return false;
            if (!double.TryParse(Power, out LaserPower)) return false;
            return true;
        }
    }

    public class WeldPoint
    {
        public double Y, Z;
        public WeldPoint() { Y = 0; Z = 0; }
        public WeldPoint(double inputY, double inputZ) { Y = inputY; Z = inputZ; }
    }

    public enum SeamType
    {
        None = 0,
        VType = 1,
        TType = 2,
    }

    public class AutoParam
    {

        public SeamType WeldType;

        public string identityInfo;
        public DateTime CreatTime;
        public string WireType;
        public double WireDiameter;
        public double LaserDiameter;
        public double LaserPower;
        public double SeamLength;
        public double SeamWidth;
        public string PlateType;
        public double Platethickness;
        public double FeedSpeed;
        public double RobotSpeed;
        public double SeamWidthMax;
        public double SeamWidthMin;
        public double Sensitivity
;

        public double KVar;
        public double JVar;
        public double MVar;


        public AutoParam(string identity, DateTime creatTime)
        {
            identityInfo = identity;
            CreatTime = creatTime;
            WireType = "Defult";
            PlateType = "Defult";
            Platethickness = 10;
            WireDiameter = 3;
            LaserDiameter = 3;
            LaserPower = 3000;
            SeamLength = 150;
            SeamWidth = 5;
            FeedSpeed = 4000;
            RobotSpeed = 50;
            MVar = 0.6;
            WeldType = 0;
        }


        public void CalVar()
        {
            KVar = ((3.14 / 4) * WireDiameter * WireDiameter * FeedSpeed) / (Platethickness * SeamWidth * RobotSpeed);
            JVar = (MVar * LaserPower) / ((3.14 / 4) * WireDiameter * WireDiameter * FeedSpeed);
        }

    }

    public class LaserSeamData
    {
        public RobotWeldData robotWeldData;
        public LaserWeldData laserWeldData;


        public LaserSeamData()
        {
            robotWeldData = new RobotWeldData();
            laserWeldData = new LaserWeldData();
        }


    }

    public class WeldProcess
    {
        private static WeldProcess instance = null;

        private WeldProcess() { }

        public static WeldProcess Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new WeldProcess();
                }

                return instance;
            }
        }

        public string Filename;

        public string TAG = "";

        public string ProcessName = "";

        public LaserSeamData mLaserSeamData = new LaserSeamData();

        public List<double> SeamWidthList = new List<double>();
        public Dictionary<double, double> LaserPowerDic = new Dictionary<double, double>();
        public Dictionary<double, double> FeedSpeedDic = new Dictionary<double, double>();
        public Dictionary<double, double> RobotSpeedDic = new Dictionary<double, double>();


        public double FeedSpeedCal(AutoParam mAutoParam, double mRobotSpeed, double mSeamWidth)
        {
            double re = 0;
            re = mAutoParam.KVar * mSeamWidth * mAutoParam.Platethickness * mRobotSpeed / ((3.14 / 4) * mAutoParam.WireDiameter * mAutoParam.WireDiameter);
            return re;
        }

        public double LaserPowerCal(AutoParam mAutoParam, double mFeedSpeed)
        {
            double re = 0;
            re = (mAutoParam.JVar * (3.14 / 4) * mAutoParam.WireDiameter * mAutoParam.WireDiameter * mFeedSpeed) / mAutoParam.MVar;
            return re;
        }

        public void GetListValue(AutoParam mAutoParam)
        {
            mAutoParam.CalVar();
            SeamWidthList = new List<double>();
            LaserPowerDic = new Dictionary<double, double>();
            FeedSpeedDic = new Dictionary<double, double>();
            RobotSpeedDic = new Dictionary<double, double>();
            int ArrayAddCount = (int)(Math.Truncate((mAutoParam.SeamWidthMax - mAutoParam.SeamWidth) / mAutoParam.Sensitivity) + 1);
            int ArrayInclineCount = (int)(Math.Truncate((mAutoParam.SeamWidth - mAutoParam.SeamWidthMin) / mAutoParam.Sensitivity) + 1);
            for (int i = 0; i < ArrayAddCount; i++)
            {
                double SeamWidthValue = mAutoParam.SeamWidth + i * mAutoParam.Sensitivity;
                double RobotSpeed = mAutoParam.RobotSpeed;
                double FeedSpeed = FeedSpeedCal(mAutoParam, RobotSpeed, SeamWidthValue);
                double LaserPower = LaserPowerCal(mAutoParam, FeedSpeed);
                SeamWidthList.Add(SeamWidthValue);
                RobotSpeedDic.Add(SeamWidthValue, RobotSpeed);
                FeedSpeedDic.Add(SeamWidthValue, FeedSpeed);
                LaserPowerDic.Add(SeamWidthValue, LaserPower);
            }
            for (int i = 0; i < ArrayInclineCount; i++)
            {
                if (i != 0)
                {
                    double SeamWidthValue = mAutoParam.SeamWidth - i * mAutoParam.Sensitivity;
                    double RobotSpeed = mAutoParam.RobotSpeed;
                    double FeedSpeed = FeedSpeedCal(mAutoParam, RobotSpeed, SeamWidthValue);
                    double LaserPower = LaserPowerCal(mAutoParam, FeedSpeed);
                    SeamWidthList.Add(SeamWidthValue);
                    RobotSpeedDic.Add(SeamWidthValue, RobotSpeed);
                    FeedSpeedDic.Add(SeamWidthValue, FeedSpeed);
                    LaserPowerDic.Add(SeamWidthValue, LaserPower);
                }
            }
            SeamWidthList.Sort();

        }

        public void StartRecord()
        {
            GlobalCommData.PCLFile.StartNewFile();
        }

        public void WriteOnlineFile()
        {
            for (int i = 0; i < mLaserSeamData.robotWeldData.PointCount; i++)
            {
                GlobalCommData.PCLFile.StorePLYData(mLaserSeamData.robotWeldData.PosX, mLaserSeamData.robotWeldData.Points[i].Y, mLaserSeamData.robotWeldData.Points[i].Z);
            }
            GlobalCommData.PCLFile.OnlineSaveFile(mLaserSeamData.robotWeldData.PosX, mLaserSeamData.robotWeldData.Width,
                mLaserSeamData.laserWeldData.Speed, mLaserSeamData.laserWeldData.FeedSpeed, mLaserSeamData.laserWeldData.LaserPower);
        }
    }


}
