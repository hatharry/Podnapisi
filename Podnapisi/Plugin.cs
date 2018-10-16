using System;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using System.IO;

namespace Podnapisi
{
    public class Plugin : BasePlugin, IHasThumbImage
    {
        private Guid _id = new Guid("9C099C87-C6ED-4E7B-A0D6-AB65AD87280C");
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
