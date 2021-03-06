﻿using System;
using System.Windows.Forms;

namespace TCS.Util
{
    internal class Message
    {
        public enum Mode { Info = 0, Warning = 1, Error = 2 };
        public static void Show(string content, Mode messageMode = Mode.Info)
        {
            switch (messageMode)
            {
                case Mode.Error:
                    MessageBox.Show(content, "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Mode.Info:
                    MessageBox.Show(content, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Mode.Warning:
                    MessageBox.Show(content, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }

        }

        public Message(string content, Mode messageMode = Mode.Info) => Show(content, messageMode);
    }
}
