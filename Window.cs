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
        Asset3d[] _object3d = new Asset3d[1];
        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            //Front Face
            //segitiga front 1
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            ////segitiga front 2
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            //_Vertices.Add(new Vector3(-0.5f,0.5f, -0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));

            ////backface
            ////segitiga back 1
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            ////segitiga back 2
            //_Vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));

            ////left face
            ////segitiga left 1
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            ////segitiga left 2
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));

            ////right face
            ////segitiga right 1
            //_Vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            ////segitiga right 2
            //_Vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));

            ////bottom face
            ////segitiga bottom 1
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, -0.5f, -0.5f));
            ////segitiga bottom 2
            //_Vertices.Add(new Vector3(0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, -0.5f, -0.5f));

            ////top face
            ////segitiga top 1
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            //_Vertices.Add(new Vector3(0.5f, 0.5f, -0.5f));
            ////segitiga top 2
            //_Vertices.Add(new Vector3(0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, 0.5f));
            //_Vertices.Add(new Vector3(-0.5f, 0.5f, -0.5f));

            _object3d[0] = new Asset3d();

        }

        protected override void OnLoad()
        {
            base.OnLoad();

            //Ganti warna background
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1);

            //kubus
            //_object3d[0].createBoxVertices(-0.1f, 0.0f, 0.0f, 0.5f);

            //materi elipsoid
            _object3d[0].createElipsoid(0.25f, 0.125f, 0.15f ,0,0,0);

            // _object3d[0].createElipsoidV2(0.25f, 0.25f, 0.25f ,0,0,0,72,24);

            //_object3d[0].createHyperboloidSatuSisi(0.25f, 0.25f, 0.25f, 0, 0, 0);

            //_object3d[0].createHyperboloidDuaSisi(0.1f, 0.1f, 0.1f, 0, 0, 0);

            //_object3d[0].createCone(0.1f, 0.1f, 0.1f, 0, 0, 0);

            //_object3d[0].createEllipticParaboloid(0.1f, 0.1f, 0.1f, 0, 0, 0);

            //_object3d[0].createHyperboloidParaboloid(0.1f, 0.1f, 0.1f, 0, 0, 0);
            //_object3d[0].loadObjFile("D:/grafkom/C#/ConsoleApp2/assets/box.obj");
            
            //_object3d[0].loadObjFile("D:/grafkom/C#/ConsoleApp2/assets/Toy Train.obj");
            //_object3d[0].load();

            //_object3d[0].createBoxVertices(0.0f, 0.0f, 0.0f, 0.25f);
            //_object3d[0].addChild(0.3f,0.3f,0.0f,0.25f);
            _object3d[0].load(Size.X,Size.Y);
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            base.OnRenderFrame(args);
            
            GL.Clear(ClearBufferMask.ColorBufferBit); //agar frame tidak bertumpuk saat ganti frame
           
            _object3d[0].render(2);
            //_object3d[0].rotate(_object3d[0]._centerPosition, _object3d[0]._euler[1], 1); //euler[0] = x, [1]=y, [2]=z
            _object3d[0].resetEuler();
            SwapBuffers();
        }

        //KEYBOARD FUNCTION
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
            var input = KeyboardState;

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
            if(e.Key == Keys.W){
                _object3d[0].Child[0].rotate(_object3d[0].Child[0]._centerPosition,_object3d[0].Child[0]._euler[0],1);
            }
        }
    }

}
