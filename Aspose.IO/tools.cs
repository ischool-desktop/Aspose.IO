using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.IO;

namespace Aspose.IO
{
    public class tools
    {

        // 2017/5/17 穎驊新增此Library 專案，用意為界接 新舊 Aspose 版本功能差異的問題
        // SavePDFtoStream  可以使用新的 Aspose 功能 解決 舊版 Aspose 無法儲存 PDF 格式 的缺點

        public static MemoryStream SavePDFtoStream(MemoryStream stream)
        {
            Document doc = new Document(stream);

            MemoryStream stream_pdf = new MemoryStream();

            doc.Save(stream_pdf, SaveFormat.Pdf);

            return stream_pdf;
        }

        public static void  SavePDFtoLocal(MemoryStream stream, string fileName)
        {
            Document doc = new Document(stream);

            doc.Save(fileName, SaveFormat.Pdf);            
        }
    }
}
