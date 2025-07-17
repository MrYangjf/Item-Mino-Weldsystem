using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PclCSharp;
using PointCloudSharp;
using Kitware.VTK;
using System.Security.Policy;
using System.Windows.Forms;
using Sunny.UI.Win32;
using System.IO;
using Sunny.UI;

namespace LaserIntelliWeldingSystem.PCL
{
    public class PCLFileClass
    {
        vtkActor actor;
        vtkActor Contouractor;

        vtkPolyData polydata;
        vtkVertexGlyphFilter glyphFilter;
        vtkPolyDataMapper mapper;

        public PCLFileClass()
        {
            InitPCLDir();
            CheckPCLLife(PCLDir);
        }

        public void StartNewFile()
        {
            PCLFileName = DateTime.Now.ToString("HHmmss");
            cloud.Clear();
        }

        public string PCLFileName = "";
        public string PCLFilePath = "";
        public string PCLDir = "";
        public string PCLOnlineDir = "";
        public uint PCLLiftCycle = 30;
        public string ErrorInfo = "";
        private bool IsError = false;
        public double ZMin = 0, ZMax = 0;

        public PointCloudXYZ cloud = new PointCloudXYZ();

        public PointCloudXYZ cloud_res = new PointCloudXYZ();

        public string Loadurl;

        private void CheckPCLLife(string strPath)
        {
            DateTime LimitTime = DateTime.Now.AddDays(-PCLLiftCycle);
            if (Directory.Exists(strPath))
            {
                string[] strFiles = Directory.GetDirectories(strPath);
                foreach (string SingleFile in strFiles)
                {
                    if (Directory.GetCreationTime(SingleFile) <= LimitTime)
                    {
                        Directory.Delete(SingleFile, true);
                        continue;
                    }
                    CheckPCLLife(SingleFile);
                }
            }
        }
        private void InitPCLDir()
        {
            string name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            this.PCLDir = "";
            string path = "D:";
            if (!IsError)
            {
                if (!Directory.Exists(path))
                {
                    path = "C:";
                    if (!Directory.Exists(path))
                    {
                        char ch = 'E';
                        int num = Convert.ToInt32(ch);
                        for (int i = 0; i < 0x18; i++)
                        {
                            num += i;
                            path = Convert.ToChar(num).ToString();
                            if (Directory.Exists(path))
                            {
                                break;
                            }
                        }
                    }
                }
                string path1, path2;
                path1 = path + @"\IntelliSystemPCLData\PCL\";
                path2 = path + @"\IntelliSystemPCLData\Online\";
                PCLDir = path1;
                PCLOnlineDir = path2;
                if (!Directory.Exists(PCLDir))
                {
                    try
                    {
                        Directory.CreateDirectory(PCLDir);
                    }
                    catch (Exception exception)
                    {
                        IsError = true;
                        ErrorInfo = string.Format("函数[{0}]:创建PCL目录失败:{1},错误信息：{2}", name, PCLDir, exception.Message);
                        PCLDir = "";
                    }
                }
                if (!Directory.Exists(PCLOnlineDir))
                {
                    try
                    {
                        Directory.CreateDirectory(PCLOnlineDir);
                    }
                    catch (Exception exception)
                    {
                        IsError = true;
                        ErrorInfo = string.Format("函数[{0}]:创建PCL目录失败:{1},错误信息：{2}", name, PCLOnlineDir, exception.Message);
                        PCLOnlineDir = "";
                    }
                }
            }
        }
        private void InitOnlinePCLDir()
        {
            string name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            try
            {
                string year = "";
                string month = "";
                string day = "";
                GetDate(ref year, ref month, ref day);
                string yearFile = string.Format(@"{0}\{1}", PCLOnlineDir, year);
                if (!Directory.Exists(yearFile))
                {
                    Directory.CreateDirectory(yearFile);
                }
                string monthFile = string.Format(@"{0}\{1}", yearFile, month);
                if (!Directory.Exists(monthFile))
                {
                    Directory.CreateDirectory(monthFile);
                }
                string dayFile = string.Format(@"{0}\{1}", monthFile, day);
                if (!Directory.Exists(dayFile))
                {
                    Directory.CreateDirectory(dayFile);
                }
                this.PCLFilePath = string.Format(@"{0}\{1}{2}{3}_{4}.online", dayFile, year, month, day, PCLFileName);
            }
            catch (Exception exception)
            {
                this.PCLFilePath = "";
                IsError = true;
                ErrorInfo = string.Format("函数[{0}]:创建PCL目录失败错误信息：{1}", name, exception.Message);
            }
        }
        private void InitPCLFilePath()
        {
            string name = System.Reflection.MethodBase.GetCurrentMethod().Name;
            try
            {
                string year = "";
                string month = "";
                string day = "";
                GetDate(ref year, ref month, ref day);
                string yearFile = string.Format(@"{0}\{1}", PCLDir, year);
                if (!Directory.Exists(yearFile))
                {
                    Directory.CreateDirectory(yearFile);
                }
                string monthFile = string.Format(@"{0}\{1}", yearFile, month);
                if (!Directory.Exists(monthFile))
                {
                    Directory.CreateDirectory(monthFile);
                }
                string dayFile = string.Format(@"{0}\{1}", monthFile, day);
                if (!Directory.Exists(dayFile))
                {
                    Directory.CreateDirectory(dayFile);
                }
                this.PCLFilePath = string.Format(@"{0}\{1}{2}{3}_{4}.ply", dayFile, year, month, day, PCLFileName);
            }
            catch (Exception exception)
            {
                this.PCLFilePath = "";
                IsError = true;
                ErrorInfo = string.Format("函数[{0}]:创建PCL目录失败错误信息：{1}", name, exception.Message);
            }
        }
        private void GetDate(ref string year, ref string month, ref string day)
        {
            DateTime now = DateTime.Now;
            year = now.ToString("yyyy");
            month = now.ToString("MM");
            day = now.ToString("dd");
        }

        /// <summary>
        ///         按照指定的轴设定点云颜色属性
        ///极小值处设置为蓝色（0，0，255），并且蓝色通道的数值由255向中间位置按坐标变化递减至0，
        ///绿色通道的数值由0按坐标变化递增至255；中间位置设置为绿色（0，255，0），
        ///并且绿色通道的数值由255按坐标变化递减至0，红色通道数值由0按坐标变化递增至255；
        ///极大值位置设置为（255，0，0）
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="in_pc"></param>
        /// <returns></returns>
        public vtkUnsignedCharArray setColorBaseAxis(char axis, PointCloudXYZ in_pc)
        {
            vtkUnsignedCharArray colors_rgb = vtkUnsignedCharArray.New();
            //点云的极值,第一第二个元素分别是x的最小最大值，yz依次类推
            double[] minmax = new double[6];
            in_pc.GetMinMaxXYZ(minmax);
            double z = minmax[5] - minmax[4];//z轴的差值
            double y = minmax[3] - minmax[2];//y轴的差值
            double x = minmax[1] - minmax[0];//x轴的差值
            double z_median = z / 2;
            double y_median = y / 2;
            double x_median = x / 2;
            colors_rgb.SetNumberOfComponents(3);//设置颜色的组分，因为是rgb，所以组分为3
            double r = 0, g = 0, b = 0;
            if (axis == 'x')
            {
                for (int i = 0; i < in_pc.Size; i++)
                {
                    //中间值为界，x值大于中间值的b组分为0，r组分逐渐变大
                    if ((in_pc.GetX(i) - minmax[0]) > x_median)
                    {
                        //x值要先归一化再乘以255，不然数值将会超出255

                        r = (255 * ((in_pc.GetX(i) - minmax[0] - x_median) / x_median)); ;
                        g = (255 * (1 - ((in_pc.GetX(i) - minmax[0] - x_median) / x_median)));
                        b = 0;
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                    //中间值为界，x值小于中间值的r组分为0，b组分逐渐变大
                    else
                    {
                        //x值要先归一化再乘以255，不然数值将会超出255
                        r = 0;
                        g = (255 * ((in_pc.GetX(i) - minmax[0]) / x_median));
                        b = (255 * (1 - ((in_pc.GetX(i) - minmax[0]) / x_median))); ;
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                }
            }
            else if (axis == 'y')
            {
                for (int i = 0; i < in_pc.Size; i++)
                {
                    //中间值为界，y值大于中间值的b组分为0，r组分逐渐变大
                    if ((in_pc.GetY(i) - minmax[2]) > y_median)
                    {
                        //y值要先归一化再乘以255，不然数值将会超出255
                        r = (255 * ((in_pc.GetY(i) - minmax[2] - y_median) / y_median)); ;
                        g = (255 * (1 - ((in_pc.GetY(i) - minmax[2] - y_median) / y_median)));
                        b = 0;
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                    //中间值为界，y值小于中间值的r组分为0，b组分逐渐变大
                    else
                    {
                        r = 0;
                        g = (255 * ((in_pc.GetY(i) - minmax[2]) / y_median));
                        b = (255 * (1 - ((in_pc.GetY(i) - minmax[2]) / y_median))); ;
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                }
            }
            else if (axis == 'z')
            {

                for (int i = 0; i < in_pc.Size; i++)
                {
                    //中间值为界，z值大于中间值的b组分为0，r组分逐渐变大
                    if ((in_pc.GetZ(i) - minmax[4]) > z_median)
                    {
                        //z值要先归一化再乘以255，不然数值将会超出255
                        r = (255 * ((in_pc.GetZ(i) - minmax[4] - z_median) / z_median)); ;
                        g = (255 * (1 - ((in_pc.GetZ(i) - minmax[4] - z_median) / z_median)));
                        b = 0;
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                    //中间值为界，z值小于中间值的r组分为0，b组分逐渐变大
                    else
                    {
                        r = 0;
                        g = (255 * ((in_pc.GetZ(i) - minmax[4]) / z_median));
                        b = (255 * (1 - ((in_pc.GetZ(i) - minmax[4]) / z_median)));
                        colors_rgb.InsertNextTuple3(r, g, b);
                    }
                }
            }

            return colors_rgb;
        }

        public vtkFloatArray setScalarArray(char axis, PointCloudXYZ in_pc)
        {
            vtkFloatArray colors_rgb = new vtkFloatArray();
            colors_rgb.SetNumberOfValues(in_pc.Size);
            double[] minmax = new double[6];
            in_pc.GetMinMaxXYZ(minmax);
            ZMax = minmax[5];
            ZMin = minmax[4];
            double z = minmax[5] - minmax[4];//z轴的差值
            if (axis == 'z')
            {
                for (int i = 0; i < in_pc.Size; i++)
                {
                    float rate = (float)((ZMax - in_pc.GetZ(i)) / z);
                    colors_rgb.SetValue(i, rate);
                }
            }
            return colors_rgb;
        }

        public vtkFloatArray setScalarArray(vtkPolyData in_pc)
        {
            vtkFloatArray colors_rgb = new vtkFloatArray();
            long Number = in_pc.GetNumberOfPoints();
            colors_rgb.SetNumberOfValues(Number);
            cloud_res.Clear();
            for (int i = 0; i < Number; i++)
            {
                double[] points = in_pc.GetPoint(i);
                cloud_res.Push(points[0], points[1], points[2]);
            }
            colors_rgb = setScalarArray('z', cloud_res);
            return colors_rgb;
        }

        public vtkActor NewActor()
        {
            //actor = null;
            actor = new vtkActor();
            //显示点云
            vtkPoints points = vtkPoints.New();
            //把点云指针中的点依次放进points
            for (int i = 0; i < cloud.Size; i++)
            {
                points.InsertNextPoint(cloud.GetX(i), cloud.GetY(i), cloud.GetZ(i));

            }
            //创建每个点的属性数据，这里代表颜色
            //scalar类与Opencv的Scalar类似，本质是一组Mat矩阵数据，OpenCV的标准是4维[n，r，g，b]，在VTK中压缩[n,(Float)Color]也可
            //vtkUnsignedCharArray colors_rgb = setColorBaseAxis('z', cloud);
            polydata = vtkPolyData.New();
            //将points数据传进polydata
            polydata.SetPoints(points);
            //将点数据的颜色属性传进polydata
            //此处简化速度更快->setScalarArray
            polydata.GetPointData().SetScalars(setScalarArray('z', cloud));

            //顶点过滤器 文件描述的重复点过滤为单点  本质是3Dglp类的衍生
            glyphFilter = vtkVertexGlyphFilter.New();
            glyphFilter.SetInputConnection(polydata.GetProducerPort());

            // 新建制图映射
            mapper = vtkPolyDataMapper.New();
            //把顶点数据压入Mapper中
            mapper.SetInputConnection(glyphFilter.GetOutputPort());
            //设置颜色模式，这个是默认模式，不加也行
            //即把标量属性数据当作颜色值就算刚刚生成的ScalarArray，不执行隐式。对于其他类型的标量数据，将通过查询表映射
            mapper.SetColorModeToDefault();
            mapper.ScalarVisibilityOn();
            actor.SetMapper(mapper);
            return actor;
        }

        public vtkActor NewSurfActor()
        {
            //显示点云
            vtkPoints points = vtkPoints.New();
            //把点云指针中的点依次放进points
            for (int i = 0; i < cloud.Size; i++)
            {
                points.InsertNextPoint(cloud.GetX(i), cloud.GetY(i), cloud.GetZ(i));

            }

            polydata = vtkPolyData.New();
            vtkSurfaceReconstructionFilter surf = new vtkSurfaceReconstructionFilter();
            vtkContourFilter contourFilter = new vtkContourFilter();
            //将points数据传进polydata
            polydata.SetPoints(points);
            //polydata.GetPointData().SetScalars(colors_rgb);
            surf.SetInput(polydata);
            surf.SetNeighborhoodSize(40);
            //surf.SetSampleSpacing(0.05);
            surf.Update();
            contourFilter.SetInputConnection(surf.GetOutputPort());
            //contourFilter.SetValue(0, 0.0);
            contourFilter.Update();

            vtkPolyData contourdata = vtkPolyData.New();
            contourdata = contourFilter.GetOutput();
            contourdata.GetPointData().SetScalars(setScalarArray(contourdata));

            vtkPolyDataMapper Contourmapper = vtkPolyDataMapper.New();
            Contourmapper.SetInput(contourdata);
            //Contourmapper.SetColorModeToMapScalars();
            Contourmapper.ScalarVisibilityOn();
            Contourmapper.Update();

            Contouractor = vtkActor.New(); // 新建角色
            Contouractor.SetMapper(Contourmapper);
            surf.Dispose();
            contourFilter.Dispose();
            contourdata.Dispose();
            Contourmapper.Dispose();
            return Contouractor;
        }

        public void LoadFile()
        {
            cloud.Clear();
            //打开点云文件
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择点云文件";
            ofd.InitialDirectory = PCLDir;
            ofd.Filter = "点云文件|*.ply";
            ofd.ShowDialog();
            Loadurl = ofd.FileName;
            //加载ply文件，并将点云对象存储到cloud中的PointCloudPointer指针中
            PclCSharp.Io.loadPlyFile(Loadurl, cloud.PointCloudXYZPointer);
        }

        public void LoadDefault()
        {
            PclCSharp.Io.loadPlyFile(PCLFilePath, cloud.PointCloudXYZPointer);
        }

        public void SaveFile()
        {
            Task.Run(() =>
            {
                try
                {
                    InitPCLFilePath();
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.Append("ply\n");
                    stringBuilder.Append("format ascii 1.0\n");
                    stringBuilder.Append($"element vertex {cloud.Size}\n");
                    stringBuilder.Append("property float x\n");
                    stringBuilder.Append("property float y\n");
                    stringBuilder.Append("property float z\n");
                    stringBuilder.Append("end_header\n");

                    for (int i = 0; i < cloud.Size; i++)
                    {
                        stringBuilder.Append($"{cloud.GetX(i)} {cloud.GetY(i)} {cloud.GetZ(i)}\n");
                    }

                    File.WriteAllText(PCLFilePath, stringBuilder.ToString());
                }
                catch (Exception ex)
                {
                    //Log.Logger.Error($" 保存点云出现异常 {ex.Message}");
                }
            });

        }

        public void StorePLYData(double X, double Y, double Z)
        {
            cloud.Push(X, Y, Z);
        }

        public void OnlineSaveFile(double RobotX, double Width, double RobotSpeed, double FeedSpeed, double LaserPower)
        {
            InitOnlinePCLDir();
            if (!File.Exists(PCLFilePath))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("OnlineData\n");
                stringBuilder.Append($"RobotX Width RobotSpeed FeedSpeed LaserPower\n");
                stringBuilder.Append($"{RobotX} {Width} {RobotSpeed} {FeedSpeed} {LaserPower}\n");
                File.WriteAllText(PCLFilePath, stringBuilder.ToString());
            }
            else
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append($"{RobotX} {Width} {RobotSpeed} {FeedSpeed} {LaserPower}\n");
                File.AppendAllText(PCLFilePath, stringBuilder.ToString());
            }
        }
    }
}
