using System;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Mathematics;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Window : GameWindow /*gamewindow=class windownya openTK*/
    { 

        //List<Vector3> _Vertices = new List<Vector3>();
        Asset3d[] _object3d = new Asset3d[6];
        Asset2d[] _object2d = new Asset2d[3];

        float[] _verticesbez = { };
        uint[] _indicesbez = { };
        Vector3 a;
        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
           
            _object3d[0] = new Asset3d();
            _object3d[1] = new Asset3d();
            _object3d[2] = new Asset3d();
            _object3d[3] = new Asset3d();
            _object3d[4] = new Asset3d();
            _object3d[5] = new Asset3d();

        }

        protected override void OnLoad()
        {
            base.OnLoad();

            //Ganti warna background
            GL.ClearColor(0.02f, 0.6f, 0.63f, 1);

            GL.Enable(EnableCap.DepthTest);
            //kubus
            _object3d[0].createBoxBody(0.0f, 0.0f, 0.0f, 0.65f);
            _object3d[0].addChildBuletanTopi(0.0f, 0.35f, 0.3f, 0.45f,"biru");//topi1
            _object3d[0].addChildBuletanTopi(0.0f, 0.4f, 0.3f, 0.35f, "birumuda");//topi2
            _object3d[0].addChildBox(-0.2f, 0.43f, 0.3f, 0.05f, "");//telinga kiri
            _object3d[0].addChildBox(0.2f, 0.43f, 0.3f, 0.05f, "");//telinga kanan
            _object3d[0].addChildCubes(0.0f, 0.6f, 0.3f, 0.33f, "biru");//topi3
            _object3d[0].addChildCubes(0.0f, -0.1f, 0.65f, 0.25f,"pinkmuda");//hidung
            _object3d[0].addChildHidung(0.0f, -0.1f, 0.8f, 0.25f, "pinkavg");//hidung
            _object3d[0].addChildCubes(-0.05f, -0.06f, 0.81f, 0.05f, "");//hid
            _object3d[0].addChildCubes(0.05f, -0.06f, 0.81f, 0.05f, "");//hid
            _object3d[0].addChildCubes(0.1f, -0.2f, 0.79f, 0.04f, "putih");//taring
            _object3d[0].addChildCubes(-0.1f, -0.2f, 0.79f, 0.04f, "putih");//taring
            _object3d[0].addChildCubes(-0.1f, 0.15f, 0.65f, 0.12f, "putih");//mata
            _object3d[0].addChildCubes(-0.1f, 0.15f, 0.7f, 0.05f, "pinktua");//bolamata
            _object3d[0].addChildCubes(0.1f, 0.15f, 0.65f, 0.12f, "putih");//mata
            _object3d[0].addChildCubes(0.1f, 0.15f, 0.7f, 0.05f, "pinktua");//bolamata
            _object3d[0].addChildlidah(0.0f, -0.2f, 0.81f, 0.04f, "pinklidah");//lidah


            _object3d[0].addChildBoxStand(0.19f, -0.3f, -0.1f, 0.25f,"");//kaki belakang kanan17
            _object3d[0].addChildBoxStand(0.19f, -0.3f, 0.4f, 0.25f, "");//kaki depan kanan
            _object3d[0].addChildBoxStand(-0.19f, -0.3f, -0.1f, 0.25f, "");//kaki belakang kiri
            _object3d[0].addChildBoxStand(-0.19f, -0.3f, 0.4f, 0.25f, "");//kaki depan kiri

            _object3d[0].addChildBoxStand(0.19f, -0.42f, -0.1f, 0.25f,"pinkavg");//kaki belakang kanan
            _object3d[0].addChildBoxStand(0.19f, -0.42f, 0.4f, 0.25f, "pinkavg");//kaki depan kanan
            _object3d[0].addChildBoxStand(-0.19f, -0.42f, -0.1f, 0.25f, "pinkavg");//kaki belakang kiri
            _object3d[0].addChildBoxStand(-0.19f, -0.42f, 0.4f, 0.25f, "pinkavg");//kaki depan kiri

            _object3d[0].addChildBoxStand(0.19f, -0.46f, -0.1f, 0.25f,"pinktua");//kaki belakang kanan
            _object3d[0].addChildBoxStand(0.19f, -0.46f, 0.4f, 0.25f, "pinktua");//kaki depan kanan
            _object3d[0].addChildBoxStand(-0.19f, -0.46f, -0.1f, 0.25f, "pinktua");//kaki belakang kiri
            _object3d[0].addChildBoxStand(-0.19f, -0.46f, 0.4f, 0.25f, "pinktua");//kaki depan kiri

            _object3d[0].addChildTabung(0.002f, 0.13f, -0.37f, 0.01f, 0.08f, 0.02f);//buntut
            //_object3d[0].addChildBox(0.0f, 0.13f, -0.37f, 0.05f, "");//buntut

            _object3d[1].createPersegi(0.0f, 0.3f, 0.0f, 0.65f,"hitam");
            _object3d[1].addChildpersegi(0.0f, 0.7f, 0.0f, 0.15f, "putih");

            //pohon
            _object3d[2].createBoxStandThin(1.2f, -1.0f,-0.5f, 0.5f,"coklat");
            _object3d[2].addChildBall(0.25f, 0.45f, 0.15f ,1.2f,-0.2f,-0.5f,"hijau");

            _object3d[3].createBoxStandThin(-1.2f, -1.0f, -0.5f, 0.5f, "coklat");
            _object3d[3].addChildBall(0.25f, 0.45f, 0.15f, -1.2f, -0.2f, -0.5f, "hijau");
            // _object3d[0].createElipsoidV2(0.25f, 0.25f, 0.25f ,0,0,0,72,24);

            //_object3d[0].createHyperboloidSatuSisi(0.25f, 0.25f, 0.25f, 0, 0, 0);

            //_object3d[0].createHyperboloidDuaSisi(0.1f, 0.1f, 0.1f, 0, 0, 0);

            //_object3d[0].createCone(0.01f, 0.01f, 0.01f, 0, 0, 0);

            //_object3d[0].createEllipticParaboloid(0.1f, 0.1f, 0.1f, 0, 0, 0);

            //_object3d[0].createHyperboloidParaboloid(0.1f, 0.1f, 0.1f, 0, 0, 0);
            //_object3d[0].loadObjFile("D:/grafkom/C#/ConsoleApp2/assets/building.obj");


            //_object3d[1].createBoxVertices(0.3f, -0.5f, 0.1f, 0.025f);
            //_object3d[1].load(Size.X, Size.Y);
            ////_object3d[0].addChild(0.3f,0.3f,0.0f,0.25f);

            //awan
            _object3d[4].createElipsoid(0.45f, 0.25f, 0.25f, 0, 0.8f, -1.0f,"putih");
            _object3d[4].addChildBall(0.15f, 0.15f, 0.15f, -0.5f, 0.8f, -1.0f, "putih");
            _object3d[4].addChildBall(0.15f, 0.15f, 0.15f, 0.5f, 0.8f, -1.0f, "putih");

            //_object3d[5].createEllipsoidVertices(0.002f, 0.001f, 0.002f, 0.01f, 0.05f, 0.02f);
            
            //bezier
            //_object2d[0] = new Asset2d(_verticesbez, _indicesbez);
            //_object2d[0].load();

            _object3d[0].load(Size.X,Size.Y);
            _object3d[1].load(Size.X, Size.Y);
            _object3d[2].load(Size.X, Size.Y);
            _object3d[3].load(Size.X, Size.Y);
            _object3d[4].load(Size.X, Size.Y);
            //_object3d[5].load(Size.X, Size.Y);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //agar frame tidak bertumpuk saat ganti frame

            _object3d[0].render(2);
            _object3d[1].render(2);
            _object3d[2].render(2);
            _object3d[3].render(2);
            _object3d[4].render(2);
            //_object3d[5].render(2);

            //_object3d[5].rotate(_object3d[5]._centerPosition, _object3d[5]._euler[1], 1); //euler[0] = x, [1]=y, [2]=z
            //_object3d[0].resetEuler();
            SwapBuffers();
        }
        int counter = 0;
        //KEYBOARD FUNCTION
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            var input = KeyboardState;

            if (counter < 100)
            {
                _object3d[0].Child[16].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[16 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[16 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);

                _object3d[0].Child[17].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[17 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[17 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);

                _object3d[0].Child[18].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[18 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[18 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);

                _object3d[0].Child[19].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[19 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);
                _object3d[0].Child[19 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], 0.1f);

            }
            else if (counter < 200)
            {
                _object3d[0].Child[16].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[16 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[16 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);

                _object3d[0].Child[17].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[17 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[17 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);

                _object3d[0].Child[18].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[18 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[18 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);

                _object3d[0].Child[19].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[19 + 4].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);
                _object3d[0].Child[19 + 8].rotate(_object3d[0].Child[16]._centerPosition, _object3d[0]._euler[0], -0.1f);

            }
            else
            {
                counter = 0;
            }
            counter++;
            Console.WriteLine(counter);

            //exit with escape keyboard
            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            };
        }

        //Untuk Resize Window
        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Size.X, Size.Y);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            if (e.Button == MouseButton.Left)
            {
                float _x = (MousePosition.X - Size.X / 2) / (Size.X / 2);
                float _y = -(MousePosition.Y - Size.Y / 2) / (Size.Y / 2);
                
            }
            base.OnMouseDown(e);
        }

        protected override void OnKeyDown(KeyboardKeyEventArgs e){
            base.OnKeyDown(e);
            if(e.Key == Keys.A){
                _object3d[0].rotate(_object3d[0]._centerPosition, _object3d[0]._euler[1],1);
            }
            if (e.Key == Keys.D)
            {
                _object3d[0].rotate(_object3d[0]._centerPosition, _object3d[0]._euler[1], -1);
            }
            if (e.Key == Keys.W){
                //_object3d[0].Child[0].rotate(_object3d[0].Child[0]._centerPosition,_object3d[0].Child[0]._euler[0],1);
                _object3d[0].rotate(_object3d[0]._centerPosition, _object3d[0]._euler[0], 1);
            }
            if (e.Key == Keys.S)
            {
                //_object3d[0].Child[0].rotate(_object3d[0].Child[0]._centerPosition,_object3d[0].Child[0]._euler[0],1);
                _object3d[0].rotate(_object3d[0]._centerPosition, _object3d[0]._euler[0], -1);
            }
            if (e.Key == Keys.Left)
            {
                _object3d[4].trans(-0.005f, 0.0f, 0.0f);
                _object3d[4].Child[0].trans(-0.005f, 0.0f, 0.0f);
                _object3d[4].Child[1].trans(-0.005f, 0.0f, 0.0f);
            }
            if (e.Key == Keys.Right)
            {
                _object3d[4].trans(0.005f, 0.0f, 0.0f);
                _object3d[4].Child[0].trans(0.005f, 0.0f, 0.0f);
                _object3d[4].Child[1].trans(0.005f, 0.0f, 0.0f);
            }
            if (e.Key == Keys.Up)
            {
                //_object3d[1].trans(0.0f, 0.005f, 0.0f);
                _object3d[4].scale(1.005f);
                _object3d[4].Child[0].scale(1.005f);
                _object3d[4].Child[1].scale(1.005f);
            }
            //if (e.Key == Keys.Down)
            //{
            //    _object3d[4].scale(-0.005f);
            //    //_object3d[4].Child[0].scale(1.005f);
            //    //_object3d[4].Child[1].scale(1.005f);
            //}
            //if(e.Key == Keys.KeyPad1)
            //{
            //    Console.WriteLine(_object3d[0]+ " " + (box1.getPosY() + box1.getLengthX()));
            //}
        }
    }

}
