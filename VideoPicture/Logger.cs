using System;
using System.Windows.Forms;

namespace VideoPicture
{
    public class Logger
    {
        Label _Label;
        Action<string> SetText;

        public Logger(Label label)
        {
            _Label = label;
            SetText = (msg) => _Label.Text = msg;
        }

        public void InformUser(string msg)
        {
            if (_Label.InvokeRequired)
                _Label.Invoke(SetText, msg);
            else
                SetText(msg);

            //System.Console.WriteLine("--- " + msg);
        }

        public void Clear()
        {
            InformUser("");
        }
    }
}
