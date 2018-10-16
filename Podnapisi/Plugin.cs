using System;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using System.IO;

namespace Podnapisi
{
    public class Plugin : BasePlugin, IHasThumbImage
    {
        private Guid _id = new Guid("0A70BB83-E28F-4633-923D-B87244697831");
        public override Guid Id
        {
            get { return _id; }
        }

        public override string Name
        {
            get { return StaticName; }
        }

        public static string StaticName
        {
            get { return "Podnapisi"; }
        }

        public override string Description
        {
            get
            {
                return "Download subtitles from Podnapisi";
            }
        }

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.png");
        }

        public ImageFormat ThumbImageFormat
        {
            get
            {
                return ImageFormat.Png;
            }
        }
    }
}
