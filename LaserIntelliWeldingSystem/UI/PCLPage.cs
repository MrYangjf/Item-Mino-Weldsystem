using Kitware.VTK;
using LaserIntelliWeldingSystem.Communication;
using Sunny.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;


namespace LaserIntelliWeldingSystem.UI
{
    public partial class PCLPage : UIPage
    {
        bool firstLoad = true;
        vtkRenderer renderer;
        vtkScalarBarActor scalarBar;
        vtkLookupTable hueLut;
        vtkActor actor;

        Task t;
        public PCLPage()
        {
            InitializeComponent();
           
        }


        void AddRenderPCLActor()
        {

            if (firstLoad)
                firstLoad = false;
            else
            { renderer.RemoveActor(actor); renderWindowControl1.RenderWindow.RemoveRenderer(renderer); }

            actor=new vtkActor();
            actor = GlobalCommData.PCLFile.NewActor();

            //给图中添加颜色刻度表,刻度值和颜色表的还没对应
            scalarBar = vtkScalarBarActor.New();
            //scalartocolors分两个组成：1、Lookuptable 提供颜色查找表(包含颜色各维度数据以及其代表的表值范围)  2、Scalars
            //scalarBar为2D画图显示 颜色和标量对应值
            hueLut = new vtkLookupTable();
            hueLut.SetTableRange(GlobalCommData.PCLFile.ZMin, GlobalCommData.PCLFile.ZMax);
            hueLut.SetHueRange(0.67, 0);
            hueLut.SetNumberOfTableValues(6);
            hueLut.Build();
            scalarBar.SetLookupTable(hueLut);
            scalarBar.SetTitle("Point Cloud Height(mm)");
            scalarBar.SetHeight(0.7);
            scalarBar.SetWidth(0.1);
            scalarBar.SetNumberOfLabels(6);
            scalarBar.GetLabelTextProperty().SetFontSize(4);
            hueLut.Dispose();

            renderer = vtkRenderer.New();
            renderer.AddActor(actor);
            //添加颜色刻度表
            renderer.AddActor(scalarBar);
            // 设置Viewport窗口
            renderer.SetViewport(0.0, 0.0, 1.0, 1.0);
            // 打开渐变色背景开关
            renderer.GradientBackgroundOn();
            renderer.SetBackground(0.2, 0.3, 0.3);
            renderer.SetBackground2(0.8, 0.8, 0.8);

            renderWindowControl1.RenderWindow.AddRenderer(renderer);
        }

        void AddRenderPCLSurfActor()
        {

            if (firstLoad)
                firstLoad = false;
            else
            { renderer.RemoveActor(actor); renderWindowControl1.RenderWindow.RemoveRenderer(renderer); }

            actor = new vtkActor();
            actor = GlobalCommData.PCLFile.NewSurfActor();

            renderer = vtkRenderer.New();
            renderer.AddActor(actor);
            //添加颜色刻度表
            // 设置Viewport窗口
            renderer.SetViewport(0.0, 0.0, 1.0, 1.0);
            // 打开渐变色背景开关
            renderer.GradientBackgroundOn();
            renderer.SetBackground(0.2, 0.3, 0.3);
            renderer.SetBackground2(0.8, 0.8, 0.8);

            renderWindowControl1.RenderWindow.AddRenderer(renderer);
        }

        private void btn_LoadFile_Click(object sender, System.EventArgs e)
        {
            GlobalCommData.PCLFile.LoadFile();
        }

        private void btn_ShowPoint_Click(object sender, System.EventArgs e)
        {

            //renderer = GlobalCommData.PCLFile.showPointCloud();
            AddRenderPCLActor();
            Show3DPCL();

        }

        private void uiButton2_Click(object sender, System.EventArgs e)
        {

            AddRenderPCLSurfActor();    
            Show3DPCL();


        }
        public void Show3DPCL()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(Show3DPCL));
            }
            else
            {
                //throw new System.NotImplementedException();
                //renderWindowControl1.RenderWindow.AddRenderer(renderer);

                //刷新panel，这样就不需要点击一下屏幕才会显示点云
                renderWindowControl1.RenderWindow.Render();
                System.GC.Collect();
            }
        }
    }
}
