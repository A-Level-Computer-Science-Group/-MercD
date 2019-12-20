using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using main;
using System;
namespace Camera
{
    class CameraRelative
    {
        private Camera camera;
        public CameraRelative(Camera camera)
        {
            this.camera = camera;
        }
        public void Draw(Texture2D texture, Rectangle destinationRectangle, SpriteBatch spriteBatch, ScreenResolution screenResolution)
        {
            float screenScaleRatioX = (float)screenResolution.width / (float)camera.scope.Width;
            float screenScaleRatioY = (float)screenResolution.height / (float)camera.scope.Height;

            Rectangle cameraRelativeRectangle = new Rectangle(
                destinationRectangle.X - camera.scope.X,
                destinationRectangle.Y - camera.scope.Y,
                (int)(destinationRectangle.Width * screenScaleRatioX),
                (int)(destinationRectangle.Height * screenScaleRatioY)
            );
            if (destinationRectangle.Intersects(camera.scope))
            {
                spriteBatch.Draw(texture, cameraRelativeRectangle, Color.White);
            }
        }
    }
}
