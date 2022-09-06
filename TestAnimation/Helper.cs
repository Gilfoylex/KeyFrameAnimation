using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Media.Imaging;
using System.Windows;
using KeyFrameAnimation;

namespace TestAnimation
{
    static class Helper
    {
        public static List<KeyFrame> GetKeyFrames()
        {
            var duration = 16; // 每一帧间隔
            var k = new List<KeyFrame>();
            for (var index = 1; index < 61; ++index)
            {
                var bitmap = new BitmapImage(new Uri($"pack://application:,,,/Resources/fire/{index}.png"));
                k.Add(new KeyFrame
                {
                    AFrame = bitmap,
                    Duration = duration
                });
            }

            return k;
        }
    }
}
