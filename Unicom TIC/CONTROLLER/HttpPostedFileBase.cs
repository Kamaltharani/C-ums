using System;

namespace Unicom_TIC.CONTROLLER
{
    public class HttpPostedFileBase
    {
        public string FileName { get; internal set; }
        public int ContentLength { get; internal set; }

        internal void SaveAs(string path)
        {
            throw new NotImplementedException();
        }
    }
}