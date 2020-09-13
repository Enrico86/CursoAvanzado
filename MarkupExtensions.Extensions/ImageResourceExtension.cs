using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Xaml.Internals;

namespace MarkupExtensions.Extensions
{
        [ContentProperty("Source")]
        public class ImageResourceExtension : IMarkupExtension<ImageSource>
        {
            public string Source { get; set; }
            public ImageSource ProvideValue(IServiceProvider serviceProvider)
            {
                if (String.IsNullOrEmpty(Source))
                {
                    IXmlLineInfoProvider lineInfoProvider = serviceProvider
                        .GetService(typeof(XmlLineInfoProvider)) as IXmlLineInfoProvider;
                    IXmlLineInfo lineInfo;
                    if(lineInfoProvider!=null)
                    {
                        lineInfo = lineInfoProvider.XmlLineInfo;
                    }
                    else
                    {
                        lineInfo = new XmlLineInfo();
                    }
                    throw new XamlParseException("" + "La extensión requiere que la propiedad Source no sea vacía", lineInfo);           
                }


                var assembly = GetType().GetTypeInfo().Assembly;
                string assemblyName = assembly.GetName().Name;
                var image = assemblyName + "." + Source;
                return ImageSource.FromResource(image, assembly);
            }

            object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
            {
                return (this as IMarkupExtension<ImageSource>).ProvideValue(serviceProvider); 
            }
        }
}
